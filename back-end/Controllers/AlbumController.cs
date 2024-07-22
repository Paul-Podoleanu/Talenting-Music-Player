using Microsoft.AspNetCore.Mvc;
using back_end.Service;
using back_end.DataLayer.Models;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly AlbumService _albumService;

        public AlbumController(AlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpPost("addAlbum")]
        public IActionResult AddAlbum([FromBody] Album album)
        {
            if (album == null)
            {
                return BadRequest("Album cannot be null.");
            }

            _albumService.AddAlbum(album);
            return Ok();
        }

        [HttpGet("getAlbumsByArtist/{artistId:int}")]
        public IActionResult GetAlbumsByArtist(int artistId)
        {
            var albums = _albumService.GetAlbumsByArtist(artistId);
            if (albums == null || !albums.Any())
            {
                return NotFound("No albums found for the artist.");
            }
            return Ok(albums);
        }
    }
}
