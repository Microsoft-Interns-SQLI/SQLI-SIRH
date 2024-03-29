using API_MySIRH.DTOs;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;
using API_MySIRH.Helpers;
using API_MySIRH.Extentions;
using Syncfusion.XlsIO;
using AutoMapper;
using API_MySIRH.Entities;
using Microsoft.AspNetCore.Authorization;

namespace API_MySIRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()]
    public class CollaborateursController : ControllerBase
    {
        private readonly ICollaborateurService _collaborateurService;
        private readonly ICarriereService _carriereService;
        private readonly ICollaborateurTypeContratService _collaborateurTypeContratService;
        private readonly IDemissionService _demissionService;
        private readonly IMdmService<Niveau, NiveauDTO> _mdmServiceNiveau;
        private readonly IMdmService<Site, SiteDTO> _mdmServiceSite;
        private readonly IMdmService<Post, PostDTO> _mdmServicePoste;
        private readonly IMdmService<TypeContrat, TypeContratDTO> _mdmServiceTypeContrat;
        private readonly IMdmService<SkillCenter, SkillCenterDTO> _mdmServiceSkillCenter;
        private readonly IMdmService<ModeRecrutement, ModeRecrutementDTO> _mdmServiceModeRecrutement;
        private readonly IMapper _mapper;

        public CollaborateursController(ICollaborateurService collaborateurService, ICarriereService carriereService, ICollaborateurTypeContratService collaborateurTypeContratService,IDemissionService demissionService, IMdmService<Niveau, NiveauDTO> mdmServiceNiveau, IMdmService<Site, SiteDTO> mdmServiceSite, IMdmService<Post, PostDTO> mdmServicePoste, IMdmService<TypeContrat, TypeContratDTO> mdmServiceTypeContrat, IMdmService<SkillCenter, SkillCenterDTO> mdmServiceSkillCenter, IMdmService<ModeRecrutement, ModeRecrutementDTO> mdmServiceModeRecrutement, IMapper mapper)
        {
            _collaborateurService = collaborateurService;
            _carriereService = carriereService;
            _collaborateurTypeContratService = collaborateurTypeContratService;
            _demissionService = demissionService;
            _mdmServiceNiveau = mdmServiceNiveau;
            _mdmServiceSite = mdmServiceSite;
            _mdmServicePoste = mdmServicePoste;
            _mdmServiceTypeContrat = mdmServiceTypeContrat;
            _mdmServiceSkillCenter = mdmServiceSkillCenter;
            _mdmServiceModeRecrutement = mdmServiceModeRecrutement;
            _mapper = mapper;
        }

        [HttpGet("IntrgrationsRange")]
        public async Task<ActionResult<IEnumerable<int>>> GetIntegrationsRange()
        {
            var res = await _collaborateurService.GetIntegrationsYearsRange();
            return Ok(res);
        }

        [HttpGet("integrations")]
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetIntegrations([FromQuery] FilterParams filterParams)
        {
            var res = await _collaborateurService.GetIntegrations(filterParams);
            Response.AddPaginationHeader(res.CurrentPage, res.PageSize, res.TotalCount, res.TotalPages);
            return Ok(res);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetCollaborateurs([FromQuery] FilterParams filterParams)
        {
            var collabs = await _collaborateurService.GetCollaborateurs(filterParams);
            Response.AddPaginationHeader(collabs.CurrentPage, collabs.PageSize, collabs.TotalCount, collabs.TotalPages);
            return Ok(collabs);
            //return Ok(list.OrderByDescending(x => x.Certifications.Where(x => x.Libelle == "AZ-104").Any() ? x.Certifications.Where(x => x.Libelle == "AZ-104").FirstOrDefault().Libelle : null));
        }

        [HttpGet("demission")]
        public async Task<ActionResult<IEnumerable<CollaborateurDTO>>> GetDemissions([FromQuery] FilterParams filterParams)
        {
            var collabs = await _collaborateurService.GetDemissions(filterParams);
            Response.AddPaginationHeader(collabs.CurrentPage, collabs.PageSize, collabs.TotalCount, collabs.TotalPages);
            return Ok(collabs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CollaborateurDTO>> GetCollaborateur(int id)
        {
            var entity = await this._collaborateurService.GetCollaborateurById(id);
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult> AddCollaborateur(CollaborateurDTO collaborateurDTO)
        {
            var collaborateurToCreate = await this._collaborateurService.AddCollaborateur(collaborateurDTO);

            return CreatedAtAction(nameof(GetCollaborateurs), new { id = collaborateurToCreate.Id }, collaborateurToCreate);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCollaborateur(int id, CollaborateurDTO collaborateurDTO)
        {
            if (id != collaborateurDTO.Id)
            {
                return BadRequest();
            }
            try
            {
                await this._collaborateurService.UpdateCollaborateur(collaborateurDTO);
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
            ////Save Excel file into Archive folder
            //await ImportFeatures.UploadFileLocaly(file);



            var result = await ImportFile(file);

            return Ok(result);
        }

        [HttpGet("export")]
        public async Task<IActionResult> Export([FromQuery] List<int> ids, [FromQuery] FilterParams filtres)
        {
            var exportfile = await export(ids, filtres);
            return exportfile;
        }

        private async Task<CollaborateurDTO> InvokeOperation(Collaborateur collaborateur)
        {

            //if collab is not a freelancer
            if (collaborateur.Matricule != "0")
            {
                if (await _collaborateurService.CollaborateurExistsByMatricule(collaborateur.Matricule))
                {
                    return null;
                }
                else
                {
                    return await _collaborateurService.AddCollaborateur(_mapper.Map<CollaborateurDTO>(collaborateur));
                }
            }
            //if collab ==> freelancer (freelancer doesn't have a matricule so we verify by email)
            else
            {
                if (await _collaborateurService.CollaborateurExistsByEmail(collaborateur.Email))
                {
                    return null;
                }
                else
                {
                    return await _collaborateurService.AddCollaborateur(_mapper.Map<CollaborateurDTO>(collaborateur));
                }
            }
        }

        private async Task<ImportResult> ImportFile(IFormFile file)
        {

            ImportResult compteRendu = new ImportResult();

            ExcelEngine excelEngine = new ExcelEngine();

            //Instantiate the Excel application object
            IApplication application = excelEngine.Excel;

            IWorkbook workbook = application.Workbooks.Open(file.OpenReadStream());



            foreach (IWorksheet worksheet in workbook.Worksheets)
            {
                for (int i = 1; i < worksheet.Rows.Count(); i++)
                {
                    if (!worksheet.Rows[i].IsBlank)
                    {
                        Collaborateur collaborateur = new Collaborateur();

                        //Split full name into lastname and firstname
                        var nomComplet = worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ","").Equals("NOMCOMPLET")).First().Cells[i].Value.ToString().Split(' ');
                        var Nom = nomComplet[1];
                        var Prenom = nomComplet[0];
                        if (nomComplet.Length > 2)
                            Nom += $"{string.Join(" ", nomComplet.Skip(2))}";

                        collaborateur.Nom = Nom;
                        collaborateur.Prenom = Prenom;

                        //Matricule
                        //collaborateur.Matricule = worksheet.Rows[i].Cells[0].Value.ToString();
                        collaborateur.Matricule = worksheet.Columns.Where(x => x.DisplayText.ToUpper().Equals("MATRICULE")).First().Cells[i].Value.ToString();
                        //Email
                        //collaborateur.Email = worksheet.Rows[i].Cells[2].Value.ToString();
                        collaborateur.Email = worksheet.Columns.Where(x => x.DisplayText.ToUpper().Equals("EMAIL")).First().Cells[i].Value.ToString();
                        //Civilite
                        //collaborateur.Civilite = worksheet.Rows[i].Cells[5].Value.ToString();
                        collaborateur.Civilite = worksheet.Columns.Where(x => x.DisplayText.ToUpper().Equals("CIVILITE")).First().Cells[i].Value.ToString();

                        //Diplomes
                        //var diplomes = SerializeDiplomes(worksheet.Rows[i].Cells[16].Value.ToString());
                        var diplomes = SerializeDiplomes(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Equals("DIPLOMES")).First().Cells[i].Value.ToString());
                        collaborateur.Diplomes = diplomes.ToList();

                        //Mode recrutement
                        //var modeRecrutement = await _mdmServiceModeRecrutement.GetByName(worksheet.Rows[i].Cells[11].Value.ToString());
                        var modeRecrutement = await _mdmServiceModeRecrutement.GetByName(
                           worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("RECRUTEMENTMODE")).First().Cells[i].Value.ToString());
                        collaborateur.ModeRecrutement = _mapper.Map<ModeRecrutement>(modeRecrutement);

                        //Site
                        var site = await _mdmServiceSite.GetByName(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Equals("AGENCE") || x.DisplayText.ToUpper().Equals("SITE")).First().Cells[i].Value.ToString());
                        collaborateur.Site = _mapper.Map<Site>(site);

                        //Skill center
                        var skillCenter = await _mdmServiceSkillCenter.GetByName(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ","").Equals("SKILLSCENTER")).First().Cells[i].Value.ToString());
                        collaborateur.SkillCenter = _mapper.Map<SkillCenter>(skillCenter);
                        
                        //Date de naissance
                        if (worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATENAISSANCE")).First().Cells[i].Value.ToString() != "")
                            collaborateur.DateNaissance = Convert.ToDateTime(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATENAISSANCE")).First().Cells[i].Value.ToString());

                        //Date de 1ere Experience
                        if (worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATE1EREEXPERIENCE")).First().Cells[i].Value.ToString() != "")
                            collaborateur.DatePremiereExperience = Convert.ToDateTime(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATE1EREEXPERIENCE")).First().Cells[i].Value.ToString());
                        
                        //Date d'entree à SQLI
                        if (worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATED'ENTREE")).First().Cells[i].Value.ToString() != "")
                            collaborateur.DateEntreeSqli = Convert.ToDateTime(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATED'ENTREE")).First().Cells[i].Value.ToString());

                        //Date debut de stage
                        if (worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATEDEDEBUTDESTAGE")).First().Cells[i].Value.ToString() != "")
                            collaborateur.DateDebutStage = Convert.ToDateTime(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATEDEDEBUTDESTAGE")).First().Cells[i].Value.ToString());


                        var op = await InvokeOperation(collaborateur);
                        if (op == null)
                        {
                            compteRendu["ExistsCollab"]++;
                        }
                        else
                        {
                            //Poste & Niveau
                            //var poste = await _mdmServicePoste.GetByName(worksheet.Rows[i].Cells[8].Value.ToString());
                            var poste = await _mdmServicePoste.GetByName(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Equals("POSTE")).First().Cells[i].Value.ToString());

                            //var niveau = await _mdmServiceNiveau.GetByName(worksheet.Rows[i].Cells[9].Value.ToString());
                            var niveau = await _mdmServiceNiveau.GetByName(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Equals("NIVEAU")).First().Cells[i].Value.ToString());

                            await this._carriereService.Add(new CarriereDTO
                            {
                                CollaborateurId = op.Id,
                                Annee = DateTime.Now.Year,
                                Niveau = niveau,
                                Poste = poste,
                                ProfilDeCout = "ST0",
                                SalaireNet = 15000,
                                VariableNet = 15000,
                                SalaireBrut = 5000,
                                VariableBrut = 5000,
                                TLRH = "TEMP DATA", // todo : will the excel sheet contain the TLRH's info ??
                            });

                            //Type contrat
                            var typeContrat = await _mdmServiceTypeContrat.GetByName(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("TYPEDECONTRAT")).First().Cells[i].Value.ToString());
                            if (typeContrat != null)
                            {
                                await _collaborateurTypeContratService.AddCollabContrat(new CollaborateurTypeContratDTO()
                                {
                                    CollaborateurId = op.Id,
                                    //date debut must be added in this file!
                                    //date fin must be added in this file!
                                    TypeContratId = typeContrat.Id,
                                });
                            }

                            //Date sortie de SQLI
                            if (worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATEDESORTIE")).First().Cells[i].Value.ToString() != "")
                            {
                                await _demissionService.AddDemission(new DemissionDTO()
                                {
                                    CollaborateurId = op.Id,
                                    DateDemission = Convert.ToDateTime(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATEDESORTIE")).First().Cells[i].Value.ToString()),
                                    DateSortieSqli = Convert.ToDateTime(worksheet.Columns.Where(x => x.DisplayText.ToUpper().Replace(" ", "").Equals("DATEDESORTIE")).First().Cells[i].Value.ToString())
                                });
                            }

                            compteRendu["AddingCollab"]++;
                        }


                    }
                }

            }
            workbook.Close();

            excelEngine.Dispose();

            return compteRendu;
        }
        private IEnumerable<Diplome> SerializeDiplomes(string str)
        {
            List<Diplome> resultDiplomes = new List<Diplome>();
            var diplomes = str.Split('|');

            foreach (var diplome in diplomes)
            {
                if (diplome == "")
                {
                    continue;
                }

                var diplomeEntity = diplome.Trim().Split(':', StringSplitOptions.TrimEntries);
                var annee = diplomeEntity[0];
                var detail = diplomeEntity[1];
                resultDiplomes.Add(new Diplome { Annee = Int32.Parse(annee), Detail = detail });
            }

            return resultDiplomes;
        }

        private async Task<FileContentResult> export(List<int> ids, FilterParams filtres)
        {
            var collabs = new List<CollaborateurDTO>();
            if (!ids.Any())
            {
                collabs = _collaborateurService.GetNoPagingCollaborateurs(filtres).ToList();
            }
            else
            {
                for (int index = 0; index < ids.Count; index++)
                {
                    var en = await _collaborateurService.GetCollaborateurById(ids[index]);
                    collabs.Add(en);
                }
            }

            ExcelEngine excelEngine = new ExcelEngine();

            IApplication application = excelEngine.Excel;

            application.DefaultVersion = ExcelVersion.Excel2016;

            IWorkbook workbook = application.Workbooks.Create(1);
            IWorksheet worksheet = workbook.Worksheets[0];

            //worksheet.ImportData(collabs, 1, 1, true);

            //worksheet.UsedRange.CellStyle.ShrinkToFit = true;

            worksheet.Name = "collabs";



            worksheet["A1"].Value = "Matricule";
            worksheet["B1"].Value = "Login";
            worksheet["C1"].Value = "Email";
            worksheet["D1"].Value = "Nom";
            worksheet["E1"].Value = "Prenom";
            worksheet["F1"].Value = "Agence";
            worksheet["G1"].Value = "Civilité";
            worksheet["H1"].Value = "Date Naissance";
            worksheet["I1"].Value = "Skill Center";
            worksheet["J1"].Value = "Poste";
            worksheet["K1"].Value = "Niveau";
            worksheet["L1"].Value = "Type de Contrat";
            worksheet["M1"].Value = "Recrutement Mode";
            worksheet["N1"].Value = "Date 1ere expérience";
            worksheet["O1"].Value = "Date d'entrée";
            worksheet["P1"].Value = "Date de début de stage";
            worksheet["Q1"].Value = "Date de sortie";
            worksheet["R1"].Value = "Diplomes";

            int i = 2;
            foreach (var collab in collabs)
            {


                worksheet[$"A{i}"].Value = collab.Matricule;
                worksheet[$"B{i}"].Value = collab.Prenom.Substring(0, 1) + collab.Nom;
                worksheet[$"C{i}"].Value = collab.Email;
                worksheet[$"D{i}"].Value = collab.Nom;
                worksheet[$"E{i}"].Value = collab.Prenom;
                worksheet[$"F{i}"].Value = collab.Site.Name;
                worksheet[$"G{i}"].Value = collab.Civilite;
                worksheet[$"H{i}"].Value = collab.DateNaissance.ToString("dd/MM/yyyy");
                worksheet[$"I{i}"].Value = collab.SkillCenter.Name;
                worksheet[$"J{i}"].Value = this._mapper.Map<Collaborateur>(collab).GetCurrentCarriere()?.Poste?.Name;
                worksheet[$"K{i}"].Value = this._mapper.Map<Collaborateur>(collab).GetCurrentCarriere()?.Niveau?.Name;

                var typeContrat = await _collaborateurTypeContratService.GetCurrentContrat(collab.Id);
                worksheet[$"L{i}"].Value = typeContrat == null ? "" : typeContrat.TypeContrat.Name;

                worksheet[$"M{i}"].Value = collab.ModeRecrutement == null ? "" : collab.ModeRecrutement.Name;
                worksheet[$"N{i}"].Value = collab.DatePremiereExperience == null ? "" : collab.DatePremiereExperience?.ToString("dd/MM/yyyy");
                worksheet[$"O{i}"].Value = collab.DateEntreeSqli == null ? "" : collab.DateEntreeSqli?.ToString("dd/MM/yyyy");
                worksheet[$"P{i}"].Value = collab.DateDebutStage == null ? "" : collab.DateDebutStage?.ToString("dd/MM/yyyy");
                worksheet[$"Q{i}"].Value = collab.Demissions.Any() ? collab.Demissions.Last().DateSortieSqli?.ToString("dd/MM/yyyy") : "";

                var diplomes = "";
                if (collab.Diplomes != null)
                    diplomes = String.Join(" | ", collab.Diplomes.Select(x => $"{x.Annee} : {x.Detail}"));
                worksheet[$"R{i}"].Value = diplomes;

                worksheet[$"H{i}"].CellStyle.ShrinkToFit = true;
                worksheet[$"N{i}"].CellStyle.ShrinkToFit = true;
                worksheet[$"O{i}"].CellStyle.ShrinkToFit = true;
                worksheet[$"P{i}"].CellStyle.ShrinkToFit = true;
                worksheet[$"Q{i}"].CellStyle.ShrinkToFit = true;
                i++;
            }

            var stream = new MemoryStream();


            workbook.SaveAs(stream);

            stream.Position = 0;



            var content = stream.ToArray();
            workbook.Close();
            excelEngine.Dispose();
            return File(
                content,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "collaborateurs.xlsx"
                );

        }

    }
}