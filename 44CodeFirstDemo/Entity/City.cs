namespace _44CodeFirstDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("City")]
    public partial class City
    {
        public int id { get; set; }

        [Column("City")]
        [StringLength(50)]
        public string City1 { get; set; }

        public int Pid { get; set; }
    }
}
