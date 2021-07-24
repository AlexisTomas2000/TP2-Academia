using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Modulo : BusinessEntity
    {
        private String desc;
        public String Descripcion { get =>this.desc; set =>this.desc=value; }
    }
}
