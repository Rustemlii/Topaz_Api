﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
    public class ScoreDTO
    {
        public int ID { get; set; }
        public string? Home { get; set; }
        public string? Away { get; set; }
        public string? ScoreNumber { get; set; }
        public DateTime Date { get; set; }
    }
}
