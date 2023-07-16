using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccessLayer;


namespace DataAccessLayer
{
    public class DALDersler
    {
        public static List<EntityDersler> ClassList()
        {
            List<EntityDersler> dersler = new List<EntityDersler>();
            SqlCommand cmdDers = new SqlCommand("Select * from TBL_DERSLER", Connection.sqlConn);
            if (cmdDers.Connection.State!=ConnectionState.Open)
            {
                cmdDers.Connection.Open();
            }
            SqlDataReader dr = cmdDers.ExecuteReader();
            while (dr.Read())
            {
                EntityDersler ders = new EntityDersler();
                ders.Id = Convert.ToInt32(dr["DERSID"].ToString());
                ders.DersAd = dr["DERSAD"].ToString();
                ders.MinKont = int.Parse(dr["DERSMINKONT"].ToString());
                ders.MaxKont = int.Parse(dr["DERSMAXKONT"].ToString());
                dersler.Add(ders);

            }
            dr.Close();
            return dersler;
        }
        public static int ClassRequest(EntityBasvuruForm bsv)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_BASVURUFORM(OGRID,DERSID) values(@p1,@p2) ", Connection.sqlConn);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", bsv.BasvuruOgrId);
            cmd.Parameters.AddWithValue("@p2", bsv.BasvuruDersId);
            return cmd.ExecuteNonQuery();
        }


    }
}
