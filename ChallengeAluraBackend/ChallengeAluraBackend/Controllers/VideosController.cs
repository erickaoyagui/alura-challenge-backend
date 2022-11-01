using ChallengeAluraBackend.Data;
using ChallengeAluraBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeAluraBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private VideoContext _videoContext;

        public VideosController(VideoContext videoContext)
        {
            _videoContext = videoContext;
        }

        [HttpGet]
        public IActionResult RecuperaVideo()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AdicionaVideo ([FromBody]Video video)
        {
            //videos.Add(video);
            return Ok(video);
        }

    }
}
