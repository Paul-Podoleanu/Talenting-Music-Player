using Microsoft.AspNetCore.Mvc;
using back_end.Service;
using back_end.DataLayer.Models;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistsController : ControllerBase
    {
        private readonly ArtistService _artistService;

        public ArtistsController(ArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpPost("addArtist")]
        public IActionResult AddArtist([FromBody] Artist artist)
        {
            if (artist == null)
            {
                return BadRequest("Artist cannot be null.");
            }

            _artistService.AddArtist(artist);
            return Ok();
        }

        [HttpGet("getTopSongs/{artistId:int}")]
        public IActionResult GetTopSongs(int artistId)
        {
            var songs = _artistService.GetTopSongs(artistId);
            if (songs == null || !songs.Any())
            {
                return NotFound("No top songs found for the artist.");
            }
            return Ok(songs);
        }

        [HttpGet("getAlbums/{artistId:int}")]
        public IActionResult GetAlbums(int artistId)
        {
            var albums = _artistService.GetAlbums(artistId);
            if (albums == null || !albums.Any())
            {
                return NotFound("No albums found for the artist.");
            }
            return Ok(albums);
        }
    }
}
