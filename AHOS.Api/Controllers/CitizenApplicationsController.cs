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
using AutoMapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AHOS.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CitizenApplicationsController : ControllerBase
    {
        private readonly AhosContext _context;
        private readonly IMapper _mapper;

        public CitizenApplicationsController(AhosContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/CitizenApplications/GetCitizenApplications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitizenApplication>>> GetCitizenApplications()
        {
            return await _context.CitizenApplications.ToListAsync();
        }

        // GET: api/CitizenApplications/GetCitizenApplication/5
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

        // PUT: api/CitizenApplications/PutCitizenApplication/5
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

        // POST: api/CitizenApplications/PostCitizenApplication
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CitizenApplication>> PostCitizenApplication(CreateCitizenApplicationDto citizenApplication)
        {
            //vasi seçilmiş ise de otomatik getirebiliriz. 
            CitizenPatient patient = await GetCitizenPatient(); // otomatik sistemden çekecek



            var data = new CitizenApplication
            {
                PatientId = patient.Id
            };
            //data.CitizenApplicationServices = _mapper.Map<List<CitizenApplicationService>>(citizenApplication.Services);

            foreach (var service in citizenApplication.Services)
            {

                data.CitizenApplicationServices.Add(new CitizenApplicationService()
                {
                    CityId = service.CityId,
                    FamilyDoctorId = service.FamilyDoctorId,
                    ServiceId = service.ServiceId,
                    ServiceReferanceCode = "", //TODO bu kısım bankaya gidecek olan
                    Price = 0, //TODO bu kısım servise göre son ödenecek ücret

                });

            }
            _context.CitizenApplications.Add(data);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }

            return CreatedAtAction("GetCitizenApplication", new { id = data.Id }, citizenApplication);
        }

        private async Task<CitizenPatient> GetCitizenPatient()
        {
            var patient =  new Models.Patient.CitizenPatient();
            //eğer sistemde yoksa kaydedelim.
            if (false)
            {
                await _context.CitizenPatients.AddAsync(patient);
                await _context.SaveChangesAsync();
            }
            return patient;
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
