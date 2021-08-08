using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityTeacher
    {
        private int ogrtid;

        public int OgrtID
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }

        private string ogrtadsoyad;

        public string OgrtAdSoyad
        {
            get { return ogrtadsoyad; }
            set { ogrtadsoyad = value; }
        }


        private int ogrtdersid;

        public int OgrtDersID
        {
            get { return ogrtdersid; }
            set { ogrtdersid = value; }
        }

        private string dersad;

        public string DersAd
        {
            get { return dersad; }
            set { dersad = value; }
        }
    }
}
