using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruId;
        private int basvuruDersId;
        private int basvuruOgrId;

        public int BasvuruId { get => basvuruId; set => basvuruId = value; }
        public int BasvuruDersId { get => basvuruDersId; set => basvuruDersId = value; }
        public int BasvuruOgrId { get => basvuruOgrId; set => basvuruOgrId = value; }
    }
}
