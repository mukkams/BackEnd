using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.PFActivities.Queries.GetActivities;
using Domain;
using Domain.Models.ProcessFlow;
using Domain.Models.UserStore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace ProcessFlowAPI.Controllers.ProcessFlow
{
    [Route("api/[controller]")]
    [ApiController]
    public class PFActivitiesController: ControllerBase
    {
        private readonly IMediator _context;

        public PFActivitiesController(IMediator context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PFActivity>>> Get()
        {
            var values = await _context.Send(new GetActivities.Query());
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PFActivity>> Get(Guid id)
        {
            var value = await _context.Send(new GetActiivity.Query{Id = id});
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
