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
    public class EntityDersler
    {
        private int id;
        private string dersAd;
        private int minKont;
        private int maxKont;

        public string DersAd { get => dersAd; set => dersAd = value; }
        public int MinKont { get => minKont; set => minKont = value; }
        public int MaxKont { get => maxKont; set => maxKont = value; }
        public int Id { get => id; set => id = value; }
    }
}
