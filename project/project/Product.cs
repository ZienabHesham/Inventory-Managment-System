using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string MeasuringUnit { get; set; }
        public int Quantity { get; set; }   
        public virtual Store Store { get; set; }

    }
}
