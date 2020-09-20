using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkTestApi.DataLayer;
using WorkTestApi.DataLayer.Entities;
using WorkTestApi.Models;

namespace WorkTestApi.BussinesLayer
{
    public class ImageService : IImagesService
    {
        private readonly IImageRepostiory _imageRepostiory;

        private readonly List<DbImage> _images;
        public ImageService(IImageRepostiory imageRepostiory)
        {
            _imageRepostiory = imageRepostiory;
            _images = new List<DbImage>();
        }
        
        public async Task AddAsync(List<ImageDetailViewModel> imageDetails)
        {
            //this should do automapper
            var files = imageDetails.Select(image => new DbImage
            {
                HasEffectOne = image.HasEffectOne,
                HasEffectTwo = image.HasEffectTwo,
                HasEffectThree = image.HasEffectThree,
                Name = image.File.FileName,
                Radius = image.Radius,
                Size = image.Size,
            });

            _images.AddRange(files);
        }

        public async Task<List<ImageDetailViewModel>> GetAllAsync()
        {
            var resultList = new List<ImageDetailViewModel>();
            //returns dummy data 
            var res = new ImageDetailViewModel
            {
                HasEffectOne = true,
                HasEffectTwo = false,
                HasEffectThree = false,
                Name = "dummy name",
                Radius = 150,
                Size = 120,
            };

            resultList.Add(res);

            return resultList;
        }
    }
}
