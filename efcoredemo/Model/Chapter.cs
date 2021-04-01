﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcoredemo.Model
{
    public class Chapter
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public virtual Book Book { get; set; }
    }
}
