using AutoMapper;
using ChallengeAluraBackend.Data;
using ChallengeAluraBackend.Data.Dtos;
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
        private IMapper _mapper;

        public VideosController(VideoContext videoContext, IMapper mapper)
        {
            _videoContext = videoContext;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaVideo([FromBody] CreateVideoDto videoDto)
        {
            Video video = _mapper.Map<Video>(videoDto);
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
            ReadVideoDto videoDto = _mapper.Map<ReadVideoDto>(video);
            return Ok(videoDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaVideo(int id, [FromBody] UpdateVideoDto videoDto)
        {
            Video video = _videoContext.Videos.FirstOrDefault(video => video.Id == id);
            if (video == null)
            {
                return NotFound();
            }
            _mapper.Map(videoDto, video);
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
