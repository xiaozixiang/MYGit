namespace _44CodeFirstDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dept")]
    public partial class dept
    {
        [Key]
        [StringLength(20)]
        public string deptcode { get; set; }

        [StringLength(20)]
        public string deptName { get; set; }

        [StringLength(20)]
        public string parantCode { get; set; }
    }
}
