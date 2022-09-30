using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using DataAccess;

namespace BusinessFacade
{
    public class MHSSystem
    {
        public bool UpdateDataMHS(DBMahasiswa objMahasiswa)
        {
            try
            {
                return new MahasiswaDB().UpdateDataMHS(objMahasiswa);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        
    }
}
