using ChallengeAluraBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeAluraBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private static List<Video> videos = new List<Video>();
        [HttpGet]
        public IActionResult RecuperaVideo()
        {
            return Ok(videos);
        }

        [HttpPost]
        public IActionResult AdicionaVideo ([FromBody]Video video)
        {
            videos.Add(video);
            return Ok(video);
        }

    }
}
