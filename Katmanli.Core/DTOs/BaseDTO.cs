using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katmanli.Core.DTOs
{
    public abstract class BaseDTO
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
