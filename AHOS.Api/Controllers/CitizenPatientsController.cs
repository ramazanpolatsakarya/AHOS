using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AHOS.Api.Models;
using AHOS.Api.Models.Patient;

namespace AHOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizenPatientsController : ControllerBase
    {
        private readonly AhosContext _context;

        public CitizenPatientsController(AhosContext context)
        {
            _context = context;
        }

        // GET: api/CitizenPatients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitizenPatient>>> GetCitizenPatients()
        {
            return await _context.CitizenPatients.ToListAsync();
        }

        // GET: api/CitizenPatients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CitizenPatient>> GetCitizenPatient(Guid id)
        {
            var citizenPatient = await _context.CitizenPatients.FindAsync(id);

            if (citizenPatient == null)
            {
                return NotFound();
            }

            return citizenPatient;
        }

        // PUT: api/CitizenPatients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCitizenPatient(Guid id, CitizenPatient citizenPatient)
        {
            if (id != citizenPatient.Id)
            {
                return BadRequest();
            }

            _context.Entry(citizenPatient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitizenPatientExists(id))
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

        // POST: api/CitizenPatients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CitizenPatient>> PostCitizenPatient(CitizenPatient citizenPatient)
        {
            _context.CitizenPatients.Add(citizenPatient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CitizenPatientExists(citizenPatient.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCitizenPatient", new { id = citizenPatient.Id }, citizenPatient);
        }

        // DELETE: api/CitizenPatients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitizenPatient(Guid id)
        {
            var citizenPatient = await _context.CitizenPatients.FindAsync(id);
            if (citizenPatient == null)
            {
                return NotFound();
            }

            _context.CitizenPatients.Remove(citizenPatient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CitizenPatientExists(Guid id)
        {
            return _context.CitizenPatients.Any(e => e.Id == id);
        }
    }
}
