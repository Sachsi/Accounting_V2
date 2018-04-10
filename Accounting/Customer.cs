namespace Accounting
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [DisplayColumn("Full_Name")]
    [Table("Customer")]
    public partial class Customer
    {
        public Customer()
        {
            this.Incomes = new HashSet<Income>();
        }

        public int Id { get; set; }

        [Column("Full Name")]
        [StringLength(100)]
        public string Full_Name { get; set; }

        [Column("E-Mail Address")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string E_Mail { get; set; }

        [Column("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(50)]
        public string PhoneNr { get; set; }

        [Column("CSA")]
        public bool CSA { get; set; }

        [Column("Neightbarhood")]
        public bool Neighbarhood { get; set; }

        [Column("Hors Barn")]
        public bool Hors_Barn { get; set; }

        [Column("Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
       

        public virtual ICollection<Income> Incomes { get; set; }

        [NotMapped]
        public int ObjectState { get; set; }
    }
}
