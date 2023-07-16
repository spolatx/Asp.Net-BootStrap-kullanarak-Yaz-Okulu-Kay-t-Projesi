using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
using DataAccessLayer;


namespace BusinessLogicLayer
{
    public class BLLBasvuruForm
    {
        public static bool ClassRequestBLL(EntityBasvuruForm bsv)
        {
            if (bsv.BasvuruDersId != null && bsv.BasvuruOgrId != null)
            {
                return DALDersler.ClassRequest(bsv) > 0;
            }
            return false;
           
        }
    }
}
