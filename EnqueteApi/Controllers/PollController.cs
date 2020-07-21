using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Enquete.ApplicationCore.Interfaces.Services;
using Enquete.ApplicationCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Enquete.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollController : Controller
    {

        #region Injeção de Dependência
        private readonly IPollService _pollService;
        private readonly IMapper _mapper;

        public PollController(IPollService pollService, IMapper mapper)
        {
            _pollService = pollService;
            _mapper = mapper;
        }
        #endregion

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            try
            {
                var polls = _mapper.Map<List<PollVM>>(_pollService.GetAll().ToList());

                return Ok(polls);
            }
            catch (Exception)
            {
                return NotFound();
                throw;
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
