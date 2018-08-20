namespace Accounting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportIncome")]
    public partial class ReportIncome
    {
        public int Id { get; set; }

        [Column("Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Column("Customer")]
        public string Customer { get; set; }

        [Column("Payment")]
        [StringLength(20)]
        public string Payment { get; set; }

        [Column("Price")]
        [DataType(DataType.Currency)]
        public Double Price { get; set; }

        [Column("Products")]
        [DataType(dataType: DataType.Text)]
        public string Products { get; set; }

        [NotMapped]
        public int ObjectState { get; set; }
    }
}
