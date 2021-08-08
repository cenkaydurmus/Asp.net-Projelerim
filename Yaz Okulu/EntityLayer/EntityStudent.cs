using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityStudent
    {
        private int ogrid;

        public int OgrID
        {
            get { return ogrid; }
            set { ogrid = value; }
        }

        private string ograd;

        public string OgrAd
        {
            get { return ograd; }
            set { ograd = value; }
        }

        private string ogrsoyad;

        public string OgrSoyad
        {
            get { return ogrsoyad; }
            set { ogrsoyad = value; }
        }

        private string ogrmail;

        public string OgrMail
        {
            get { return ogrmail; }
            set { ogrmail = value; }
        }

        private string ogrokulno;

        public string OgrOkulNo
        {
            get { return ogrmail; }
            set { ogrmail = value; }
        }

        private string ogrsifre;

        public string OgrSifre
        {
            get { return ogrsifre; }
            set { ogrsifre = value; }
        }

        private int bakiye;

        public int Bakiye
        {
            get { return bakiye; }
            set { bakiye = value; }
        }
    }
}
