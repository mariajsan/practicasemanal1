﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class ciudades
    {
        [Key] public int cityId { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }

    }
}