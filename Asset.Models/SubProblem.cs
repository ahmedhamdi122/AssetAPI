﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset.Models
{
    public class SubProblem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public  Nullable< int> ProblemId { get; set; }
        [ForeignKey("ProblemId")]
        public virtual Problem Problem { get; set; }
    }
}
