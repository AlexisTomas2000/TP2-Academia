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
                SqlCommand cmdccm = new SqlCommand("SELECT cursos.id_materia, cursos.id_comision, concat(materias.desc_materia, ' ', comisiones.desc_comision)Matcom, cursos.id_curso "+
                                                    "FROM cursos INNER JOIN comisiones ON cursos.id_comision = comisiones.id_comision INNER JOIN "+
                                                    "materias ON cursos.id_materia = materias.id_materia", sqlConn);
                SqlDataReader drCcms = cmdccm.ExecuteReader();
                while (drCcms.Read())
                {
                    CCM c = new CCM();
                    c.Id_Comision = (int)drCcms["id_comision"];
                    c.Id_Materia= (int)drCcms["id_materia"];
                    c.Id_Curso= (int)drCcms["id_curso"];
                    c.Desc = (String)drCcms["Matcom"];
                    ccms.Add(c);
                }
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
