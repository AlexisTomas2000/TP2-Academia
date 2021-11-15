using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CursoLogic:BusinessLogic
    {
        
        private Data.Database.CursoAdapter _CursoData;

        public Data.Database.CursoAdapter CursoData
        {
            get { return _CursoData; }
            set { _CursoData = value; }
        }
        public CursoLogic()
        {
        }
        public CursoLogic(Data.Database.CursoAdapter x)
        {
            this.CursoData = x;
        }
        public List<Curso> GetAll()
        {
            this.CursoData = new Data.Database.CursoAdapter();
            return this.CursoData.GetAll();
        }
        public Business.Entities.Curso GetOne(int ID)
        {
            this.CursoData = new Data.Database.CursoAdapter();
            return CursoData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            this.CursoData = new Data.Database.CursoAdapter();
            CursoData.Delete(ID);
        }

        public void Save(Business.Entities.Curso cur)
        {
            this.CursoData = new Data.Database.CursoAdapter();
            CursoData.Save(cur);
        }

        public bool HayCupos(Business.Entities.Curso cur) {
             bool rta = false;
            if (cur.Cupo>0)
            {
                rta = true;

            }

            return rta; 
        }
    }
}
