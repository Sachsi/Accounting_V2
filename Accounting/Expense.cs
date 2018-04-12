namespace Accounting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Expanses")]
    public partial class Expense
    {
        public int Id { get; set; }

        [Column("Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Column("Dealer")]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Dealer { get; set; }

        [Column("Payment")]
        [DataType(DataType.Text)]
        [StringLength(10)]
        public string Payment { get; set; }

        [Column("Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Column("Details")]
        [DataType(DataType.Text)]
        public string Details { get; set; } 

        [NotMapped]
        public int ObjectState { get; set; }
    }
}
