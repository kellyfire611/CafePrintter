//namespace CafePrintter.Model
//{
//    using Base;
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    //using System.Data.Entity.Spatial;

//    [Table("control_type_use_control")]
//    public partial class control_type_use_control : EntityBase
//    {
//        [Index("IX_ControlTypeUseControlUnique", 1, IsUnique = true)]
//        public int controlTypeId { get; set; }

//        [Index("IX_ControlTypeUseControlUnique", 2, IsUnique = true)]
//        public int controlId { get; set; }

//        [ForeignKey("controlTypeId")]
//        public virtual control_type control_type { get; set; }

//        [ForeignKey("controlId")]
//        public virtual control control { get; set; }
//    }
//}
