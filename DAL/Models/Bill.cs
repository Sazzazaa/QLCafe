namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public int BillID { get; set; }

        public int OrderDetailID { get; set; }

        public DateTime? PaymentDate { get; set; }

        [StringLength(50)]
        public string PaymentStatus { get; set; }

        public decimal Total { get; set; }

        public virtual OrderDetail OrderDetail { get; set; }
    }
}
