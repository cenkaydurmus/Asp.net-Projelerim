using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusniessLogicLayer
{
    public class BLLOGR
    {
        public static int bllogrekle(EntityOGR p)
        {
            if (p.OGRAD!=null && p.OGRSOYAD!=null && p.OGRMAIL!=null && p.OGRSIFRE!=null && p.OGROKULNO != null) 
            {
                return DALOGR.OgrEkle(p);
            }

            return -1;
        }

        public static List<EntityOGR> bllogrlistele()
        {
            return DALOGR.OgrListele();
        }

        public static bool bllogrsil(int p)
        {
            if (p!=0)
            {
                return DALOGR.OgrSil(p);
            }
            return false;
        }

        public static List<EntityOGR> bllogrguncellegoster(int p)
        {

            return DALOGR.OgrGuncelleGoster(p);
        }

        public static bool bllogrguncelle(EntityOGR p)
        {
            if (p.ID != 0 && p.OGRAD != null && p.OGRSOYAD != null && p.OGRSIFRE != null && p.OGRMAIL != null && p.OGROKULNO!=null)
            {
                return DALOGR.OgrGuncelle(p);
            }
            return false;
        }
    }
}
