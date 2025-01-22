using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AHOS.Api.Models;
using AutoMapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using AHOS.Api.Models.Patient.NonCitizen;
using AHOS.Api.Models.Patient;
using AHOS.Api.Dto.CitizenApplication.NonCitizen;

namespace AHOS.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NonCitizenApplicationsController : ControllerBase
    {
        private readonly AhosContext _context;
        private readonly IMapper _mapper;

        public NonCitizenApplicationsController(AhosContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/NonCitizenApplications/GetNonCitizenApplications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NonCitizenApplication>>> GetNonCitizenApplications()
        {
            return await _context.NonCitizenApplications.ToListAsync();
        }

        // GET: api/NonCitizenApplications/GetNonCitizenApplication/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NonCitizenApplication>> GetNonCitizenApplication(Guid id)
        {
            var NonCitizenApplication = await _context.NonCitizenApplications.FindAsync(id);

            if (NonCitizenApplication == null)
            {
                return NotFound();
            }

            return NonCitizenApplication;
        }

        // PUT: api/NonCitizenApplications/PutNonCitizenApplication/5

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNonCitizenApplication(Guid id, NonCitizenApplication dto)
        {
            if (id != dto.Id)
            {
                return BadRequest();
            }

            _context.Entry(dto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NonCitizenApplicationExists(id))
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

        // POST: api/NonCitizenApplications/PostNonCitizenApplication
        [HttpPost]
        public async Task<ActionResult<NonCitizenApplication>> PostNonCitizenApplication(CreateNonCitizenApplicationDto dto)
        {
            //vasi seçilmiş ise de otomatik getirebiliriz. 
            var patient = await GetNonCitizenPatient(); // otomatik sistemden çekecek



            var data = new NonCitizenApplication
            {
                PatientId = patient.Id
            };
            //data.NonCitizenApplicationServices = _mapper.Map<List<NonCitizenApplicationService>>(NonCitizenApplication.Services);

            foreach (var service in dto.Services)
            {

                data.NonCitizenApplicationServices.Add(new NonCitizenApplicationService()
                {
                    CityId = service.CityId,
                    FamilyDoctorId = service.FamilyDoctorId,
                    ServiceId = service.ServiceId,
                    ServiceReferanceCode = "", //TODO bu kısım bankaya gidecek olan
                    Price = 0, //TODO bu kısım servise göre son ödenecek ücret

                });

            }
            _context.NonCitizenApplications.Add(data);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw;
            }

            return CreatedAtAction("GetNonCitizenApplication", new { id = data.Id }, dto);
        }

        private async Task<NonCitizenPatient> GetNonCitizenPatient()
        {
            var patient =  new Models.Patient.NonCitizen.NonCitizenPatient();
            //eğer sistemde yoksa kaydedelim.
            if (false)
            {
                await _context.NonCitizenPatients.AddAsync(patient);
                await _context.SaveChangesAsync();
            }
            return patient;
        }

    


        // DELETE: api/NonCitizenApplications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNonCitizenApplication(Guid id)
        {
            var NonCitizenApplication = await _context.NonCitizenApplications.FindAsync(id);
            if (NonCitizenApplication == null)
            {
                return NotFound();
            }

            _context.NonCitizenApplications.Remove(NonCitizenApplication);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NonCitizenApplicationExists(Guid id)
        {
            return _context.NonCitizenApplications.Any(e => e.Id == id);
        }
    }
}
