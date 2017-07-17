using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CafePrintter2.Model.Base
{
    public interface IVersionedRow
    {
        long rowVersion { get; set; }
    }
}
