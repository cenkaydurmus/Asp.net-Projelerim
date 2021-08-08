using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOGR
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string ograd;

        public string OGRAD
        {
            get { return ograd; }
            set { ograd = value; }
        }

        private string ogrsoyad;

        public string OGRSOYAD
        {
            get { return ogrsoyad; }
            set { ogrsoyad = value; }
        }

        private string ogrmail;

        public string OGRMAIL
        {
            get { return ogrmail; }
            set { ogrmail = value; }
        }

        private string ogrsifre;

        public string OGRSIFRE
        {
            get { return ogrsifre; }
            set { ogrsifre = value; }
        }

        private int bakiye;

        public int BAKIYE
        {
            get { return bakiye; }
            set { bakiye = value; }
        }

        private string ogrokulno;

        public string OGROKULNO
        {
            get { return ogrokulno; }
            set { ogrokulno = value; }
        }
    }
}
