using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AHOS.Api.Models;
using AHOS.Api.Models.Patient;
using AHOS.Api.Dto;

namespace AHOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizenApplicationsController : ControllerBase
    {
        private readonly AhosContext _context;

        public CitizenApplicationsController(AhosContext context)
        {
            _context = context;
        }

        // GET: api/CitizenApplications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitizenApplication>>> GetCitizenApplications()
        {
            return await _context.CitizenApplications.ToListAsync();
        }

        // GET: api/CitizenApplications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CitizenApplication>> GetCitizenApplication(Guid id)
        {
            var citizenApplication = await _context.CitizenApplications.FindAsync(id);

            if (citizenApplication == null)
            {
                return NotFound();
            }

            return citizenApplication;
        }

        // PUT: api/CitizenApplications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCitizenApplication(Guid id, CitizenApplication citizenApplication)
        {
            if (id != citizenApplication.Id)
            {
                return BadRequest();
            }

            _context.Entry(citizenApplication).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitizenApplicationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CitizenApplications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CitizenApplication>> PostCitizenApplication(CreateCitizenGetatApplicationDto citizenApplication)
        {
            _context.CitizenApplications.Add(citizenApplication);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CitizenApplicationExists(citizenApplication.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCitizenApplication", new { id = citizenApplication.Id }, citizenApplication);
        }

        // DELETE: api/CitizenApplications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitizenApplication(Guid id)
        {
            var citizenApplication = await _context.CitizenApplications.FindAsync(id);
            if (citizenApplication == null)
            {
                return NotFound();
            }

            _context.CitizenApplications.Remove(citizenApplication);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CitizenApplicationExists(Guid id)
        {
            return _context.CitizenApplications.Any(e => e.Id == id);
        }
    }
}
