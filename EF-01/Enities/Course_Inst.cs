using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01.Enities
{
    internal class Course_Inst
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int inst_ID {  get; set; }
        public int Course_ID {  get; set; }

        public string? Evaluate {  get; set; }

    }
}
