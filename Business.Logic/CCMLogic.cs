using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CCMLogic
    {
        private Data.Database.CCMAdapter _ccmData;

        public CCMAdapter CcmData { get => _ccmData; set => _ccmData = value; }
        public CCMLogic()
        {

        }
        public CCMLogic(Data.Database.CCMAdapter x)
        {
            CcmData = x;
        }
        public List<CCM> GetAll()
        {
            this.CcmData = new Data.Database.CCMAdapter();
            return this.CcmData.GetAll();
        }
    }
}
