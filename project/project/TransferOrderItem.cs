﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project
{
    public class TransferOrderItem
    {
        public int Id { get; set; }
        [ForeignKey("TransferOrder")]
        public int TransferOrderId { get; set; }
        public TransferOrder TransferOrder { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}