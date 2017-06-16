using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CafePrintter.Model.Base
{
    public abstract class EntityBase
    {
        [Key]
        public int id { get; set; }

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
