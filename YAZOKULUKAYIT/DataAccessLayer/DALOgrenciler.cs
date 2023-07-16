using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenciler
    {
        public static int AddStudent(EntityOgrenciler ogrenciler)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_OGRENCILER(OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTOGRAF,OGRSIFRE)values" +
                "(@p1,@p2,@p3,@p4,@p5)", Connection.sqlConn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1", ogrenciler.Ad);
            cmd.Parameters.AddWithValue("@p2", ogrenciler.Soyad);
            cmd.Parameters.AddWithValue("@p3", ogrenciler.Numara);
            cmd.Parameters.AddWithValue("@p4", ogrenciler.Fotograf);
            cmd.Parameters.AddWithValue("@p5", ogrenciler.Sifre);
            return cmd.ExecuteNonQuery();

        }
        public static List<EntityOgrenciler> OgrenciListesi()
        {
            List<EntityOgrenciler> degerler = new List<EntityOgrenciler>();
            SqlCommand cmd = new SqlCommand("Select * from TBL_OGRENCILER", Connection.sqlConn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenciler ent = new EntityOgrenciler();
                ent.Id = dr["OGRID"].ToString();
                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Fotograf = dr["OGRFOTOGRAF"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool DeleteStudent(int parametre)
        {
            SqlCommand cmd1 = new SqlCommand("Delete from TBL_OGRENCILER where OGRID=@p1", Connection.sqlConn);
            if (cmd1.Connection.State != ConnectionState.Open)
            {
                cmd1.Connection.Open();
            }
            cmd1.Parameters.AddWithValue("@p1", parametre);
            //1 ise dondur.
            return cmd1.ExecuteNonQuery() > 0;
        }
        public static bool UpdateStudent(EntityOgrenciler ogrenciler)
        {
            SqlCommand cmdUp = new SqlCommand("Update TBL_OGRENCILER set OGRAD=@p2,OGRSOYAD=@p3,OGRNUMARA=@p4,OGRFOTOGRAF=@p5,OGRSIFRE=@p6 where OGRID=@p1", Connection.sqlConn);
            if (cmdUp.Connection.State != ConnectionState.Open)
            {
                cmdUp.Connection.Open();
            }
            cmdUp.Parameters.AddWithValue("@p1", ogrenciler.Id);
            cmdUp.Parameters.AddWithValue("@p2", ogrenciler.Ad);
            cmdUp.Parameters.AddWithValue("@p3", ogrenciler.Soyad);
            cmdUp.Parameters.AddWithValue("@p4", ogrenciler.Numara);
            cmdUp.Parameters.AddWithValue("@p5", ogrenciler.Fotograf);
            cmdUp.Parameters.AddWithValue("@p6", ogrenciler.Sifre);
            return cmdUp.ExecuteNonQuery() > 0;
            
        }
        public static List<EntityOgrenciler> OgrenciDetay(int id)
        {
            List<EntityOgrenciler> degerler = new List<EntityOgrenciler>();
            SqlCommand cmd = new SqlCommand("Select * from TBL_OGRENCILER  where OGRID=@p1", Connection.sqlConn);
            cmd.Parameters.AddWithValue("@p1", id);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenciler ent = new EntityOgrenciler();

                ent.Ad = dr["OGRAD"].ToString();
                ent.Soyad = dr["OGRSOYAD"].ToString();
                ent.Numara = dr["OGRNUMARA"].ToString();
                ent.Sifre = dr["OGRSIFRE"].ToString();
                ent.Fotograf = dr["OGRFOTOGRAF"].ToString();
                ent.Bakiye = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

    }
}
