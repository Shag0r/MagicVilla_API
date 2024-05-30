using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController: ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {

            return Ok(VillaStore.VillaList);


        }
        [HttpGet("{id:int}", Name = "GetVillas")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<VillaDto> GetVillas(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa= VillaStore.VillaList.FirstOrDefault(u => u.Id == id);
            if(villa== null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        //Creating A resource
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<VillaDto> CrertaVilla([FromBody]VillaDto villaDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(villaDto == null)
            {
                return BadRequest(villaDto);
            }
            if(villaDto.Id>0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            villaDto.Id = VillaStore.VillaList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            VillaStore.VillaList.Add(villaDto);

            return CreatedAtRoute("GetVillas", new { id = villaDto.Id }, villaDto);
        }
    }
}
