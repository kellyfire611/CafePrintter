//namespace CafePrintter.Model
//{
//    using Base;
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    [Table("sys_user")]
//    public partial class sys_user : EntityBase, IVersionedRow
//    {
//        [StringLength(50)]
//        public string username { get; set; }

//        [StringLength(50)]
//        public string password { get; set; }

//        public long rowVersion { get; set; }
//    }
//}
