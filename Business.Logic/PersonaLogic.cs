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
    public class PersonaLogic:BusinessLogic
    {
        private Data.Database.PersonaAdapter _PersonaData;
        public Data.Database.PersonaAdapter PersonaData
        {
            get { return _PersonaData; }
            set { _PersonaData = value; }
        }
        public PersonaLogic()
        {
        }
        public PersonaLogic(Data.Database.PersonaAdapter x)
        {
            this.PersonaData = x;
        }
        public List<Persona> GetAllP()
        {
            this.PersonaData = new Data.Database.PersonaAdapter();
            return this.PersonaData.GetAllP();
        }
        public List<Persona> GetAllA()
        {
            this.PersonaData = new Data.Database.PersonaAdapter();
            return this.PersonaData.GetAllA();
        }
        public Business.Entities.Persona GetOne(int ID)
        {
            this.PersonaData = new Data.Database.PersonaAdapter();
            return PersonaData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            this.PersonaData = new Data.Database.PersonaAdapter();
            PersonaData.Delete(ID);
        }

        public void Save(Business.Entities.Persona per)
        {
            this.PersonaData = new Data.Database.PersonaAdapter();
            PersonaData.Save(per);
        }
 
    }
}
