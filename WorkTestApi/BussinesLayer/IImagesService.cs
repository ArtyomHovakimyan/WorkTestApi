using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkTestApi.Models;

namespace WorkTestApi.BussinesLayer
{
    public interface IImagesService
    {
        Task AddAsync(List<ImageDetailViewModel> imageDetails);
        Task<List<ImageDetailViewModel>> GetAllAsync();
    }
}
