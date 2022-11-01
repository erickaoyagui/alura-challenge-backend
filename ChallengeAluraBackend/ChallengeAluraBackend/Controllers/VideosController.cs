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

        [HttpPost]
        public IActionResult AdicionaVideo([FromBody] Video video)
        {
            _videoContext.Add(video);
            _videoContext.SaveChanges();
            return CreatedAtAction(nameof(RecuperaVideoPorId), new { Id = video.Id }, video);
        }

        [HttpGet]
        public IActionResult RecuperaVideos()
        {
            return Ok(_videoContext.Videos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaVideoPorId(int id)
        {
            Video video = _videoContext.Videos.FirstOrDefault(video => video.Id == id);
            if (video == null)
            {
                return NotFound();
            }
            return Ok(video);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaVideo(int id, [FromBody] Video videoNovo)
        {
            Video video = _videoContext.Videos.FirstOrDefault(video => video.Id == id);
            if (video == null)
            {
                return NotFound();
            }
            _videoContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveVideo (int id)
        {
            Video video = _videoContext.Videos.FirstOrDefault(video => video.Id == id);
            if (video == null)
            {
                return NotFound();
            }
            _videoContext.Videos.Remove(video);
            _videoContext.SaveChanges();
            return NoContent();
        }
    }
}
