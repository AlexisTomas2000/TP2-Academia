using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class CCMAdapter:Adapter
    {
        public List<CCM> GetAll()
        {
            List<CCM> ccms = new List<CCM>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdccm = new SqlCommand("SELECT cursos.id_materia, cursos.id_comision, materias.desc_materia, comisiones.desc_comision, cursos.id_curso, cursos.anio_calendario,cursos.cupo " +
                                                    "FROM cursos INNER JOIN comisiones ON cursos.id_comision = comisiones.id_comision INNER JOIN "+
                                                    "materias ON cursos.id_materia = materias.id_materia", sqlConn);
                SqlDataReader drCcms = cmdccm.ExecuteReader();
                while (drCcms.Read())
                {
                    CCM c = new CCM();
                    c.Id_Comision = (int)drCcms["id_comision"];
                    c.Id_Materia= (int)drCcms["id_materia"];
                    c.Id_Curso= (int)drCcms["id_curso"];
                    c.Desc = (String)drCcms["desc_materia"] +" "+ (String)drCcms["desc_comision"];
                    c.Anio=(int)drCcms["anio_calendario"];
                    c.Cupo = (int)drCcms["cupo"];
                    c.DescComision= (String)drCcms["desc_comision"];
                    c.Desc_Materia = (String)drCcms["desc_materia"];
                    ccms.Add(c);
                }//concat(, ' ')Matcom
                drCcms.Close();
                return ccms;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista random", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
