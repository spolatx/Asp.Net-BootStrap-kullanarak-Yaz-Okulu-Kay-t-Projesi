using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDersler
    {
        public static List<EntityDersler> ListBLL()
        {
            return DALDersler.ClassList();
        }
    }
}
