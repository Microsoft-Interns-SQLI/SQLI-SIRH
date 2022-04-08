using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API_MySIRH.Helpers;
using API_MySIRH.Extentions;
using Syncfusion.XlsIO;
using System.Collections;
using AutoMapper;
using API_MySIRH.Entities;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize()]
    public class CollaborateursController : ControllerBase
    {
        private readonly ICollaborateurService _collaborateurService;
        private readonly IMapper _mapper;


        public CollaborateursController(ICollaborateurService collaborateurService, IMapper mapper)
        {
            _collaborateurService = collaborateurService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetCollaborateurs([FromQuery] FilterParams filterParams)
        {
            var collabs = await _collaborateurService.GetCollaborateurs(filterParams);
            Response.AddPaginationHeader(collabs.CurrentPage, collabs.PageSize, collabs.TotalCount, collabs.TotalPages);
            return Ok(collabs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CollaborateurDTO>> GetCollaborateur(int id)
        {
            return Ok(await this._collaborateurService.GetCollaborateurById(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddCollaborateur(CollaborateurDTO collaborateurDTO)
        {
            var collaborateurToCreate = await this._collaborateurService.AddCollaborateur(collaborateurDTO);
            return CreatedAtAction(nameof(GetCollaborateurs), new { id = collaborateurToCreate.Id }, collaborateurToCreate);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CollaborateurDTO>> UpdateCollaborateur(int id, CollaborateurDTO collaborateurDTO)
        {
            if (id != collaborateurDTO.Id)
            {
                return BadRequest();
            }
            try
            {
                await this._collaborateurService.UpdateCollaborateur(id, collaborateurDTO);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCollaborateur(int id)
        {
            var collaborateur = await this._collaborateurService.GetCollaborateurById(id);
            if (collaborateur is null)
                return NotFound();
            await this._collaborateurService.DeleteCollaborateur(id);
            return NoContent();
        }

        [HttpPost("import")]
        public async Task<IActionResult> UploadFileCSV([FromForm] IFormFile file)
        {

            await AddOrUpdateInDB(file);

            //Save Excel file into Archive folder
            await ImportFeatures.UploadFileLocaly(file);

            



            return Ok();
        }

        private async Task InvokeOperation(Collaborateur collaborateur)
        {
            //if collab is not a freelancer
            if (collaborateur.Matricule != "0")
            {
                if (await _collaborateurService.CollaborateurExistsByMatricule(collaborateur.Matricule))
                {
                    var collab = await _collaborateurService.GetCollaborateurByMatricule(collaborateur.Matricule);
                    var collabDto = _mapper.Map<CollaborateurDTO>(collaborateur);
                    collabDto.Id = collab.Id;
                    await _collaborateurService.UpdateCollaborateur(collab.Id, collabDto);
                }
                else
                {
                    await _collaborateurService.AddCollaborateur(_mapper.Map<CollaborateurDTO>(collaborateur));
                }
            }
            //if collab ==> freelancer (freelancer doesn't have a matricule so we verify by email)
            else
            {
                if (await _collaborateurService.CollaborateurExistsByEmail(collaborateur.Email))
                {
                    var collab = await _collaborateurService.GetCollaborateurByEmail(collaborateur.Email);
                    var collabDto = _mapper.Map<CollaborateurDTO>(collaborateur);
                    collabDto.Id = collab.Id;

                    await _collaborateurService.UpdateCollaborateur(collab.Id, collabDto);
                }
                else
                {
                    await _collaborateurService.AddCollaborateur(_mapper.Map<CollaborateurDTO>(collaborateur));
                }
            }
        }

        private async Task AddOrUpdateInDB(IFormFile file)
        {

            ExcelEngine excelEngine = new ExcelEngine();

            //Instantiate the Excel application object
            IApplication application = excelEngine.Excel;

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Archives", file.FileName);

            FileStream fileStream = new FileStream(path, FileMode.Open);

            IWorkbook workbook = application.Workbooks.Open(fileStream);

            fileStream.Close();


            foreach (IWorksheet worksheet in workbook.Worksheets)
            {
                for (int i = 1; i < worksheet.Rows.Count(); i++)
                {

                    var nomComplet = worksheet.Rows[i].Cells[3].Value.Split(' ');

                    var Nom = nomComplet[1];

                    var Prenom = nomComplet[0];

                    if (nomComplet.Length > 2)
                        Nom += $"{string.Join(" ", nomComplet.Skip(2))}";

                    Collaborateur collaborateur = new Collaborateur();
                    collaborateur.Matricule = worksheet.Rows[i].Cells[0].Value.ToString();
                    collaborateur.Nom = Nom;
                    collaborateur.Prenom = Prenom;
                    collaborateur.Email = worksheet.Rows[i].Cells[2].Value.ToString();
                    collaborateur.Civilite = worksheet.Rows[i].Cells[5].Value.ToString();
                    collaborateur.Diplomes = worksheet.Rows[i].Cells[16].Value.ToString();
                    collaborateur.ModeRecrutement = worksheet.Rows[i].Cells[11].Value.ToString();

                    if (worksheet.Rows[i].Cells[6].Value != "")
                        collaborateur.DateNaissance = Convert.ToDateTime(worksheet.Rows[i].Cells[6].Value);
                    if (worksheet.Rows[i].Cells[12].Value != "")
                        collaborateur.DatePremiereExperience = Convert.ToDateTime(worksheet.Rows[i].Cells[12].Value);
                    if (worksheet.Rows[i].Cells[13].Value != "")
                        collaborateur.DateEntreeSqli = Convert.ToDateTime(worksheet.Rows[i].Cells[13].Value);
                    if (worksheet.Rows[i].Cells[14].Value != "")
                        collaborateur.DateDebutStage = Convert.ToDateTime(worksheet.Rows[i].Cells[14].Value);
                    if (worksheet.Rows[i].Cells[15].Value != "")
                        collaborateur.DateSortieSqli = Convert.ToDateTime(worksheet.Rows[i].Cells[15].Value);

                    await InvokeOperation(collaborateur);
                }

            }
            workbook.Close();

            excelEngine.Dispose();
        }

    }
}