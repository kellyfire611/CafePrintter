//namespace CafePrintter.Model
//{
//    using Base;
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    [Table("sys_setting")]
//    public partial class sys_setting : EntityBase, IVersionedRow
//    {
//        [StringLength(255)]
//        public string key { get; set; }

//        [StringLength(4000)]
//        public string value { get; set; }

//        public long rowVersion { get; set; }
//    }
//}
