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
        private readonly IPollOptionService _pollOptionService;
        private readonly IOptionService _optionService;
        private readonly IMapper _mapper;

        public PollController(IPollService pollService, IMapper mapper, IPollOptionService pollOptionService, IOptionService optionService)
        {
            _pollService = pollService;
            _mapper = mapper;
            _pollOptionService = pollOptionService;
            _optionService = optionService;
        }
        #endregion

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            try
            {
                var poll = _mapper.Map<PollOptionsVM>(_pollService.GetById(id));
                if (poll == null)
                    return NotFound();
                _pollService.UpdateViews(id);
                var pollOption = _mapper.Map<PollOptionsVM>(poll);
                pollOption.Options = _pollOptionService.GetOptionsByPoll(id);

                return Ok(poll);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] PollOptionsJsonVM poll)
        {
            try
            {
                var pollId = _pollService.SavePoll(poll);

                return Ok(new { poll_id = pollId });
            }
            catch (Exception)
            {
                return NotFound();
                throw;
            }
        }

        [HttpPost("{id:int}/vote")]
        public ActionResult<IEnumerable<string>> Post(int id, [FromBody] OptionVoteVM option)
        {
            try
            {
                var poll = _mapper.Map<PollVM>(_pollService.GetById(id));
                if (poll == null)
                    return NotFound();

                option.Id = id;
                _optionService.Vote(option);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
            
        }

        [HttpGet("{id:int}/stats")]
        public ActionResult<IEnumerable<string>> Stats(int id)
        {
            try
            {
                StatsVM stats = new StatsVM();
                var poll = _pollService.GetById(id);
                if (poll == null)
                    return NotFound();

                stats.Views = poll.Views;
                stats.votes = _optionService.GetOptionStats(id);

                return Ok(stats);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }
    }
}
