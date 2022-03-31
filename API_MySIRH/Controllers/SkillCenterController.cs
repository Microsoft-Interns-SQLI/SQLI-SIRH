using API_MySIRH.Entities;
using API_MySIRH.DTOs;
using Microsoft.AspNetCore.Mvc;
using API_MySIRH.Interfaces;

namespace API_MySIRH.Controllers
{
    public class SkillCenterController : MdmController<SkillCenter, SkillCenterDTO>
    {
        public SkillCenterController(IMdmService<SkillCenter, SkillCenterDTO> mdmService) : base(mdmService)
        {
        }


        [HttpGet("skillcenters")]
        public async Task<ActionResult<IEnumerable<SkillCenterDTO>>> GetSkillCenter()
        {
            var result = await _mdmService.GetAll();
            return Ok(result);
        }

        [HttpGet("skillcenters/{id}")]
        public async Task<ActionResult<SkillCenterDTO>> GetSkillCenter(int id)
        {
            var skillCenter = await _mdmService.GetById(id);

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
                await _mdmService.Update(id, skillCenter);
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
            var returnedSkillCenter = await _mdmService.Add(skillCenter);
            return CreatedAtAction(nameof(GetSkillCenter), new { id = returnedSkillCenter.Id }, returnedSkillCenter);
        }

        [HttpDelete("skillcenters/{id}")]
        public async Task<IActionResult> DeleteSkillCenter(int id)
        {
            var skillCenterToDelete = await _mdmService.GetById(id);
            if (skillCenterToDelete == null)
            {
                return NotFound();
            }

            await _mdmService.Delete(id);

            return NoContent();
        }
    }
}
