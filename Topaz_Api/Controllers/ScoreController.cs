using Business.Abstrack;
using Business.Concrete;
using DTO.DTOEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Topaz_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreService _scoreService;
        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }
        [HttpGet]
        public IActionResult GetScore()
        {
            var values = _scoreService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult ScoreAdd(ScoreDTO s)
        {
            s.Date = DateTime.Now;
            _scoreService.Insert(s);
            return Ok();
        }
        [HttpPut]
        public IActionResult ScoreUpdate(ScoreDTO s)
        {
            string answer = "Succes";
            s.Date= DateTime.Now;
            _scoreService.Update(s);
            return Ok(answer);
        }
        [HttpDelete]
        public IActionResult DeleteScore(int id)
        {
            string answer = "Deleted";
            _scoreService.DeleteById(id);
            return Ok(answer);
        }
    }
}
