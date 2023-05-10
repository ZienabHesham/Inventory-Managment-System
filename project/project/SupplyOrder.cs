using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class SupplyOrder
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        [Column(TypeName ="date")]
        public DateTime OrderDate { get; set; }
        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public Store Store { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        [Column(TypeName = "date")]
        public DateTime ProductionDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime ExpiryDate { get; set; }
        public ICollection<SupplyOrderItem> OrderItems { get; set; }

    }



}
