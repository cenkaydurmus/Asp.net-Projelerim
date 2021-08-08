using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityApproval
    {
        private int basvuruid;

        public int BasvuruID
        {
            get { return basvuruid; }
            set { basvuruid = value; }
        }

        private int basogrid;

        public int BasOgrID
        {
            get { return basogrid; }
            set { basogrid = value; }
        }

        private int basdersid;

        public int BasDersID
        {
            get { return basdersid; }
            set { basdersid = value; }
        }

        private int basogrtid;

        public int BasOgrtID
        {
            get { return basogrtid; }
            set { basogrtid = value; }
        }
    }
}
