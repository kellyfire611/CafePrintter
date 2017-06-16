namespace CafePrintter.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cafeprinter.device")]
    public partial class device
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(255)]
        public string macAddress { get; set; }
    }
}
