using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private Data.Database.UsuarioAdapter _UsuarioData;

        public Data.Database.UsuarioAdapter UsuarioData
        {
            get { return _UsuarioData; }
            set { _UsuarioData = value; }
        }
        public UsuarioLogic()
        {
        }
        public UsuarioLogic(Data.Database.UsuarioAdapter x)
        {
            this.UsuarioData = x;
        }
        public List<Usuario> GetAll()
        {
            this.UsuarioData = new Data.Database.UsuarioAdapter();
            return this.UsuarioData.GetAll();
        }
        public Business.Entities.Usuario GetOne(int ID)
        {
            this.UsuarioData = new Data.Database.UsuarioAdapter();
            return UsuarioData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            this.UsuarioData = new Data.Database.UsuarioAdapter();
            UsuarioData.Delete(ID);
        }

        public void Save(Business.Entities.Usuario usu)
        {
            this.UsuarioData = new Data.Database.UsuarioAdapter();
            UsuarioData.Save(usu);
        }
        public bool GetOne(string usu, string pass)
        {
            this.UsuarioData = new Data.Database.UsuarioAdapter();
            return UsuarioData.GetOne(usu, pass);
        }
    }
}