using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Models.ProcessFlow;
using Domain.Models.UserStore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace ProcessFlowAPI.Controllers.ProcessFlow
{
    [Route("api/[controller]")]
    [ApiController]
    public class PFActivitiesController: ControllerBase
    {

        private readonly ProcessFlowDataContext _context;
        public PFActivitiesController(ProcessFlowDataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PFActivity>>> Get()
        {
            var values = await _context.PFActivity.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PFActivity>> Get(int id)
        {
            var value = await _context.PFActivity.FindAsync(id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
