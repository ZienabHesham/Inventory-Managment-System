﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Store
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }        
        public virtual Employee PersonInCharge { get; set; }
        public virtual ICollection<TransferOrder> TransferOrders { get; set; } 

    }
}
