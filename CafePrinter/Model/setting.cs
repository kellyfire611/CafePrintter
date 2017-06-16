namespace CafePrintter.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cafeprinter.setting")]
    public partial class setting
    {
        public int id { get; set; }

        [StringLength(255)]
        public string key { get; set; }

        [StringLength(4000)]
        public string value { get; set; }

        [StringLength(50)]
        public string createdUser { get; set; }

        public DateTime? createdDate { get; set; }

        [StringLength(50)]
        public string modifiedUser { get; set; }

        public DateTime? modifiedDate { get; set; }

        [StringLength(50)]
        public string deletedUser { get; set; }

        public DateTime? deletedDate { get; set; }
    }
}
