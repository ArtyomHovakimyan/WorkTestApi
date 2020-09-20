using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTestApi.Models
{
    public class ImageDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Radius { get; set; }
        public double Size { get; set; }
        public bool? HasEffectThree { get; set; }
        public bool? HasEffectOne { get; set; }
        public bool? HasEffectTwo { get; set; }
        public IFormFile File { get; set; }

    }
}
