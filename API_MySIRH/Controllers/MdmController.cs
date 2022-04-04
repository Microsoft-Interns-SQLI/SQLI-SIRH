using API_MySIRH.DTOs;
using API_MySIRH.Entities;
using API_MySIRH.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_MySIRH.Controllers
{
    [ApiController]
    [Route("/api/mdm")]
    public class MdmController : ControllerBase
    {
        protected readonly IMdmService<Niveau, NiveauDTO> _mdmServiceNiveau;
        protected readonly IMdmService<Site, SiteDTO> _mdmServiceSite;
        protected readonly IMdmService<Post, PostDTO> _mdmServicePoste;
        protected readonly IMdmService<TypeContrat, TypeContratDTO> _mdmServiceTypeContrat;
        protected readonly IMdmService<SkillCenter, SkillCenterDTO> _mdmServiceSkillCenter;

        public MdmController(IMdmService<Niveau, NiveauDTO> mdmServiceNiveau, IMdmService<Site, SiteDTO> mdmServiceSite, IMdmService<Post, PostDTO> mdmServicePoste, IMdmService<TypeContrat, TypeContratDTO> mdmServiceTypeContrat, IMdmService<SkillCenter, SkillCenterDTO> mdmServiceSkillCenter)
        {
            _mdmServiceNiveau = mdmServiceNiveau;
            _mdmServiceSite = mdmServiceSite;
            _mdmServicePoste = mdmServicePoste;
            _mdmServiceTypeContrat = mdmServiceTypeContrat;
            _mdmServiceSkillCenter = mdmServiceSkillCenter;
        }

        [HttpGet("niveaux")]
        public async Task<ActionResult<IEnumerable<NiveauDTO>>> GetNiveaux()
        {
            return Ok(await _mdmServiceNiveau.GetAll());
        }

        [HttpGet("niveaux/{id}")]
        public async Task<ActionResult<NiveauDTO>> GetNiveau(int id)
        {
            return Ok(await _mdmServiceNiveau.GetById(id));
        }

        [HttpPost("niveaux")]
        public async Task<ActionResult> AddNiveau(NiveauDTO niveau)
        {
            var niveauToCreate = await _mdmServiceNiveau.Add(niveau);
            return CreatedAtAction(nameof(GetNiveau), new { id = niveauToCreate.Id }, niveauToCreate);
        }

        [HttpPut("niveaux/{id}")]
        public async Task<ActionResult<NiveauDTO>> UpdateNiveau(int id, NiveauDTO niveau)
        {
            if (id != niveau.Id)
            {
                return BadRequest();
            }

            try
            {
                await _mdmServiceNiveau.Update(id, niveau);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }

        [HttpDelete("niveaux/{id}")]
        public async Task<IActionResult> DeleteToDoItem(int id)
        {
            var niveau = await _mdmServiceNiveau.GetById(id);
            if (niveau == null)
            {
                return NotFound();
            }

            await _mdmServiceNiveau.Delete(id);

            return NoContent();
        }

        [HttpGet("postes")]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetPosts()
        {
            var result = await _mdmServicePoste.GetAll();
            return Ok(result);
        }

        [HttpGet("postes/{id}")]
        public async Task<ActionResult<PostDTO>> GetPost(int id)
        {
            var post = await _mdmServicePoste.GetById(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        [HttpPut("postes/{id}")]
        public async Task<IActionResult> PutPost(int id, PostDTO post)
        {
            if (id != post.Id)
            {
                return BadRequest();
            }

            try
            {
                await _mdmServicePoste.Update(id, post);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }


        [HttpPost("postes")]
        public async Task<ActionResult<PostDTO>> PostPost(PostDTO post)
        {
            var returnedPost = await _mdmServicePoste.Add(post);
            return CreatedAtAction("GetPost", new { id = returnedPost.Id }, returnedPost);
        }

        [HttpDelete("postes/{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var postToDelete = await _mdmServicePoste.GetById(id);
            if (postToDelete == null)
            {
                return NotFound();
            }

            await _mdmServicePoste.Delete(id);

            return NoContent();
        }
        [HttpGet("skillcenters")]
        public async Task<ActionResult<IEnumerable<SkillCenterDTO>>> GetSkillCenter()
        {
            var result = await _mdmServiceSkillCenter.GetAll();
            return Ok(result);
        }

        [HttpGet("skillcenters/{id}")]
        public async Task<ActionResult<SkillCenterDTO>> GetSkillCenter(int id)
        {
            var skillCenter = await _mdmServiceSkillCenter.GetById(id);

            if (skillCenter == null)
            {
                return NotFound();
            }

            return skillCenter;
        }

        [HttpPut("skillcenters/{id}")]
        public async Task<IActionResult> PutSkillCenter(int id, SkillCenterDTO skillCenter)
        {
            if (id != skillCenter.Id)
            {
                return BadRequest();
            }

            try
            {
                await _mdmServiceSkillCenter.Update(id, skillCenter);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }


        [HttpPost("skillcenters")]
        public async Task<ActionResult<SkillCenterDTO>> PostSkillCentert(SkillCenterDTO skillCenter)
        {
            var returnedSkillCenter = await _mdmServiceSkillCenter.Add(skillCenter);
            return CreatedAtAction(nameof(GetSkillCenter), new { id = returnedSkillCenter.Id }, returnedSkillCenter);
        }

        [HttpDelete("skillcenters/{id}")]
        public async Task<IActionResult> DeleteSkillCenter(int id)
        {
            var skillCenterToDelete = await _mdmServiceSkillCenter.GetById(id);
            if (skillCenterToDelete == null)
            {
                return NotFound();
            }

            await _mdmServiceSkillCenter.Delete(id);

            return NoContent();
        }
        [HttpGet("sites")]
        public async Task<ActionResult<IEnumerable<SiteDTO>>> GetSites()
        {
            var result = await _mdmServiceSite.GetAll();
            return Ok(result);
        }

        [HttpGet("sites/{id}")]
        public async Task<ActionResult<SiteDTO>> GetSite(int id)
        {
            var skillCenter = await _mdmServiceSite.GetById(id);

            if (skillCenter == null)
            {
                return NotFound();
            }

            return skillCenter;
        }

        [HttpPut("sites/{id}")]
        public async Task<IActionResult> PutSite(int id, SiteDTO skillCenter)
        {
            if (id != skillCenter.Id)
            {
                return BadRequest();
            }

            try
            {
                await _mdmServiceSite.Update(id, skillCenter);
            }
            catch
            {
                throw;
            }

            return NoContent();
        }


        [HttpPost("sites")]
        public async Task<ActionResult<SiteDTO>> PostSite(SiteDTO skillCenter)
        {
            var returnedSkillCenter = await _mdmServiceSite.Add(skillCenter);
            return CreatedAtAction(nameof(GetSkillCenter), new { id = returnedSkillCenter.Id }, returnedSkillCenter);
        }

        [HttpDelete("sites/{id}")]
        public async Task<IActionResult> DeleteSite(int id)
        {
            var skillCenterToDelete = await _mdmServiceSite.GetById(id);
            if (skillCenterToDelete == null)
            {
                return NotFound();
            }

            await _mdmServiceSite.Delete(id);

            return NoContent();
        }

        [HttpGet("contrats/{id}")]
        public async Task<ActionResult<TypeContratDTO>> get(int id)
        {
            var type = await _mdmServiceTypeContrat.GetById(id);
            if (type != null)
                return Ok(type);
            else
            {
                return NotFound();
            }
        }

        [HttpGet("contrats")]
        public async Task<ActionResult<IEnumerable<TypeContratDTO>>> get()
        {
            var type = await _mdmServiceTypeContrat.GetAll();
            if (type != null)
                return Ok(type);
            else
            {
                return NotFound();
            }
        }

        [HttpPost("contrats")]
        public async Task<ActionResult<TypeContratDTO>> post([FromBody] TypeContratDTO type)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _mdmServiceTypeContrat.Add(type);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok($"Type de contrat : {type.Name} add successfully !");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("contrats/{id}")]
        public async Task<IActionResult> update(int id, [FromBody] TypeContratDTO type)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _mdmServiceTypeContrat.Update(id, type);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
                return Ok($"Type of contract with id : {id} updated successfully!");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("contrats/{id}")]
        public async Task<IActionResult> delete(int id)
        {
            try
            {
                await _mdmServiceTypeContrat.Delete(id);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

            return Ok($"Type of contract with id : {id} deleted successfully!");
        }
    }
}