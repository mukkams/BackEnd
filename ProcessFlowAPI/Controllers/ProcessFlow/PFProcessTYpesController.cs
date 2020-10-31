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
    public class PFProcessTypesController: ControllerBase
    {

        private readonly ProcessFlowDataContext _context;
        public PFProcessTypesController(ProcessFlowDataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PFProcessType>>> Get()
        {
            var values = await _context.PFProcessType.ToListAsync();
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PFProcessType>> Get(int id)
        {
            var value = await _context.PFProcessType.FindAsync(id);
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
