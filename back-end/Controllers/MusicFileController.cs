using Microsoft.AspNetCore.Mvc;
using back_end.Service;
using back_end.DataLayer.Models;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicFileController : ControllerBase
    {
        private readonly MusicFileService _musicFileService;

        public MusicFileController(MusicFileService musicFileService)
        {
            _musicFileService = musicFileService;
        }

        [HttpPost("addMusicFile")]
        public IActionResult AddMusicFile([FromBody] MusicFile musicFile)
        {
            if (musicFile == null)
            {
                return BadRequest("Music file cannot be null.");
            }

            _musicFileService.AddMusicFile(musicFile);
            return Ok();
        }

        [HttpGet("listFiles")]
        public IActionResult ListFiles()
        {
            var files = _musicFileService.GetAllMusicFiles();
            return Ok(files);
        }
    }
}
