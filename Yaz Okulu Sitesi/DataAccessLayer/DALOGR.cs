using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOGR
    {
        public static int OgrEkle(EntityOGR p)
        {
            SqlCommand komutekle = new SqlCommand("Insert into ÖğrenciTablosu (OgrAd,OgrSoyad,OgrMail,OgrSifre,OgrOkulNo) values (@p1,@p2,@p3,@p4,@p5)", SQLCONNECTION.con);

            if (komutekle.Connection.State!=ConnectionState.Open)
            {
                komutekle.Connection.Open();
            }

            komutekle.Parameters.AddWithValue("@p1", p.OGRAD);
            komutekle.Parameters.AddWithValue("@p2", p.OGRSOYAD);
            komutekle.Parameters.AddWithValue("@p3", p.OGRMAIL);
            komutekle.Parameters.AddWithValue("@p4", p.OGRSIFRE);
            komutekle.Parameters.AddWithValue("@p5", p.OGROKULNO);

            return komutekle.ExecuteNonQuery();
        }


        public static List<EntityOGR> OgrListele()
        {
            List<EntityOGR> ogrenciler = new List<EntityOGR>();

            SqlCommand komutlistele = new SqlCommand("Select *from ÖğrenciTablosu", SQLCONNECTION.con);

            if (komutlistele.Connection.State != ConnectionState.Open)
            {   
                komutlistele.Connection.Open();
            }

            SqlDataReader dr = komutlistele.ExecuteReader();

            while (dr.Read())
            {
                EntityOGR ent = new EntityOGR();
                ent.ID = Convert.ToInt32(dr[0]);
                ent.OGRAD = dr[1].ToString();
                ent.OGRSOYAD = dr[2].ToString();
                ent.OGRMAIL = dr[3].ToString();
                ent.OGRSIFRE = dr[4].ToString();
                ent.OGROKULNO = dr[6].ToString();
                ogrenciler.Add(ent);
            }

            dr.Close();

            return ogrenciler;

        }

        public static bool OgrSil(int p)
        {
            SqlCommand komutsil = new SqlCommand("Delete from ÖğrenciTablosu where OgrID=@p1", SQLCONNECTION.con);

            komutsil.Parameters.AddWithValue("@p1", p);

            return komutsil.ExecuteNonQuery() > 0;
        }

        public static List<EntityOGR> OgrGuncelleGoster(int p)
        {
            List<EntityOGR> ogrenciler = new List<EntityOGR>();

            SqlCommand komutlistele = new SqlCommand("Select *from ÖğrenciTablosu where OgrID=@p1", SQLCONNECTION.con);

            if (komutlistele.Connection.State != ConnectionState.Open)
            {
                komutlistele.Connection.Open();
            }

            komutlistele.Parameters.AddWithValue("@p1", p);

            SqlDataReader dr = komutlistele.ExecuteReader();

            while (dr.Read())
            {
                EntityOGR ent = new EntityOGR();
              
                ent.OGRAD = dr[1].ToString();
                ent.OGRSOYAD = dr[2].ToString();
                ent.OGRMAIL = dr[3].ToString();
                ent.OGRSIFRE = dr[4].ToString();
                ent.OGROKULNO = dr[6].ToString();
                ogrenciler.Add(ent);
            }

            dr.Close();

            return ogrenciler;

        }

        public static bool OgrGuncelle(EntityOGR p)
        {
            SqlCommand komutgüncelle = new SqlCommand("Update ÖğrenciTablosu set OgrAd=@p1 , OgrSoyad=@p2 , OgrMail=@p3 , OgrSifre=@p4 , OgrOkulNo=@p5 where OgrID=@pid", SQLCONNECTION.con);

            if (komutgüncelle.Connection.State!=ConnectionState.Open)
            {
                komutgüncelle.Connection.Open();
            }

            komutgüncelle.Parameters.AddWithValue("@p1", p.OGRAD);
            komutgüncelle.Parameters.AddWithValue("@p2", p.OGRSOYAD);
            komutgüncelle.Parameters.AddWithValue("@p3", p.OGRMAIL);
            komutgüncelle.Parameters.AddWithValue("@p4", p.OGRSIFRE);
            komutgüncelle.Parameters.AddWithValue("@p5", p.OGROKULNO);
            komutgüncelle.Parameters.AddWithValue("@pid", p.ID);

            return komutgüncelle.ExecuteNonQuery() > 0;
        }
    }
}
