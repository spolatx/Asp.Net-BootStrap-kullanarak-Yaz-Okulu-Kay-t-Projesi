using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenciler
    {
        public static int AddStudentBLL(EntityOgrenciler p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null)
            {
                return DALOgrenciler.AddStudent(p);
            }
            return -1;
        }
        public static List<EntityOgrenciler> ListBLL()
        {
            //Entitye gidip değerleri okur sonrasında BLLOgencileri gelip ListBLL yi çalıştırır Sonrasında
            //DALOgrencilere gidip OgrenciListesini çalıştırıcak okuma işlemi başarılıysa bunu geriye döndericek
            //sonrasında presentetiona gidicek ve verileri çekmiş olucak
            return DALOgrenciler.OgrenciListesi();
        }
        public static List<EntityOgrenciler> UpdateListBLL(int p)
        {

            return DALOgrenciler.OgrenciDetay(p);
        }
        public static bool DeleteStudentBLL(int p)
        {
            if (p >= 0)
            {
                return DALOgrenciler.DeleteStudent(p);
            }
            return false;
        }
        public static bool UpdateStudentBLL(EntityOgrenciler p)
        {
            if (p.Ad != null && p.Soyad != null && p.Numara != null && p.Sifre != null && p.Fotograf != null && Convert.ToInt32(p.Id)>0)
            {
                return DALOgrenciler.UpdateStudent(p);
            }
            return false;
        }
    }
}