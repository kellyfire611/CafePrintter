//namespace CafePrintter2.Model
//{
//    using Base;
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    //using System.Data.Entity.Spatial;

//    [Table("control")]
//    public partial class control : EntityBase, IVersionedRow
//    {
//        [StringLength(50)]
//        public string code { get; set; }

//        [StringLength(50)]
//        public string name { get; set; }

//        public long rowVersion { get; set; }

//        public virtual ICollection<control_type_use_control> control_type_use_control { get; set; }
//    }
//}
