using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DataAccess
{
    public class MahasiswaDB
    {
        private Database objekDB;

        public MahasiswaDB()
        {
            try
            {
                objekDB = DatabaseFactory.CreateDatabase("ConnectDBMahasiswa");
            }
            catch (Exception e)
            {

            }
        }

        public bool UpdateDataMHS(DBMahasiswa objMahasiswa)
        {
            bool retVal = false;

            try
            {
                using (DbConnection dbCon = objekDB.CreateConnection())
                {
                    DbCommand cmdUpdate = objekDB.GetStoredProcCommand("SP_UpdateDataMHS");

                    objekDB.AddInParameter(cmdUpdate, "SiswaID", System.Data.DbType.String, objMahasiswa.SiswaID);
                    objekDB.AddInParameter(cmdUpdate, "DoB", System.Data.DbType.String, objMahasiswa.DoB);
                    objekDB.AddInParameter(cmdUpdate, "Gender", System.Data.DbType.String, objMahasiswa.Gender);
                    objekDB.AddInParameter(cmdUpdate, "Agama", System.Data.DbType.String, objMahasiswa.Agama);
                    objekDB.AddInParameter(cmdUpdate, "Email", System.Data.DbType.String, objMahasiswa.Email);
                    objekDB.AddInParameter(cmdUpdate, "Alamat", System.Data.DbType.String, objMahasiswa.Alamat);
                    objekDB.AddInParameter(cmdUpdate, "BI1", System.Data.DbType.Double, objMahasiswa.BI1);
                    objekDB.AddInParameter(cmdUpdate, "BI2", System.Data.DbType.Double, objMahasiswa.BI2);
                    objekDB.AddInParameter(cmdUpdate, "Ing1", System.Data.DbType.Double, objMahasiswa.Ing1);
                    objekDB.AddInParameter(cmdUpdate, "Ing2", System.Data.DbType.Double, objMahasiswa.Ing2);
                    objekDB.AddInParameter(cmdUpdate, "Mat1", System.Data.DbType.Double, objMahasiswa.Mat1);
                    objekDB.AddInParameter(cmdUpdate, "Mat2", System.Data.DbType.Double, objMahasiswa.Mat2);
                    objekDB.AddInParameter(cmdUpdate, "IPA1", System.Data.DbType.Double, objMahasiswa.IPA1);
                    objekDB.AddInParameter(cmdUpdate, "IPA2", System.Data.DbType.Double, objMahasiswa.IPA2);
                    
                    objekDB.ExecuteNonQuery(cmdUpdate);
                }

                retVal = true;
            }
            catch (Exception e)
            {
                retVal = false;
            }

            return retVal;
        }

        

        
    }
}
