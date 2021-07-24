using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Business.Logic
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER = GIL-GALAD; DATABASE = Academia1; Integrated security = true");
            cn.Open();
            return cn;
        }
    }
}
