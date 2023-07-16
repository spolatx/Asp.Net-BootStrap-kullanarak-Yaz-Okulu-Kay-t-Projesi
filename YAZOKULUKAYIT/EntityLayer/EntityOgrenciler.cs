using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityLayer
{
    public class EntityOgrenciler
    {
        private string ad;
        private string soyad;
        private string id;
        private string numara;
        private string fotograf;
        private double bakiye;
        private string sifre;
        
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Id { get => id; set => id = value; }
        public string Numara { get => numara; set => numara = value; }
        public string Fotograf { get => fotograf; set => fotograf = value; }
        public double Bakiye { get => bakiye; set => bakiye = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}