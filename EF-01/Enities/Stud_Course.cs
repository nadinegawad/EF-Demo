﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Enities
{
    internal class Stud_Course
    {
        [Key]
        public int stud_ID {  get; set; }
        public int Course_ID {  get; set; }
        public int Grade {  get; set; }

    }
}
