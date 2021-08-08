using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityLesson
    {
        private int dersid;

        public int DersID
        {
            get { return dersid; }
            set { dersid = value; }
        }


        private string dersad;

        public string DersAd
        {
            get { return dersad; }
            set { dersad = value; }
        }

        private int maxkont;

        public int MaxKont
        {
            get { return maxkont; }
            set { maxkont = value; }
        }

        private int minkont;

        public int MinKont
        {
            get { return minkont; }
            set { minkont = value; }
        }

        private int ogrsayısı;

        public int OgrSayısı
        {
            get { return ogrsayısı; }
            set { ogrsayısı = value; }
        }


    }
}
