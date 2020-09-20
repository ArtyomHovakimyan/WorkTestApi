using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkTestApi.BussinesLayer;
using WorkTestApi.Models;

namespace WorkTestApi.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {
        private readonly IImagesService _imagesService;
        public ImagesController(IImagesService imagesService)
        {
            _imagesService = imagesService;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] List<ImageDetailViewModel> imageDetails)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _imagesService.AddAsync(imageDetails);

            return Ok();
        }
        

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _imagesService.GetAllAsync());
        }
    }
}
