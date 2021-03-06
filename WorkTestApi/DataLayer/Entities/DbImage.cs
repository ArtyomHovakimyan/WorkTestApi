﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTestApi.DataLayer.Entities
{
    public class DbImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Radius { get; set; }
        public double Size { get; set; }
        public bool? HasEffectThree { get; set; }
        public bool? HasEffectOne { get; set; }
        public bool? HasEffectTwo { get; set; }
    }
}
