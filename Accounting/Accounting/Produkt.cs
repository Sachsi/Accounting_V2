namespace Accounting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produkts")]
    public partial class Produkt
    {
        public int Id { get; set; }

        [Column("Date")]
        [DataType(DataType.Date)]
        public DateTime  Date { get; set; }

        [Column("Farmer")]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Farmer { get; set; }

        [Column("Produce")]
        [DataType(DataType.Text)]
        [StringLength(20)]
        public string Produce { get; set; }

        [Column("Price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Column("Unit")]
        public int Unit { get; set; }

        [NotMapped]
        public List<string> Units { get { return new List<string>() { "Piece", "Gramm", "Pound" }; } }

        [Column("Quantity")]
        public int Quantity { get; set; }

        [NotMapped]
        public int ObjectState { get; set; }

    }
}
