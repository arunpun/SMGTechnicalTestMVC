using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMGTechnicalTestMVC.Models
{
    public class Game
    {
        [Key]
        public int Id{ get; set; }
        public String PlayerChoice { get; set; }
        public String ComputerChoice { get; set; }
        public String GameResult { get; set; }
    }
}
