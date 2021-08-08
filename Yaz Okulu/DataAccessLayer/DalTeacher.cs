using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DalTeacher
    {
        public List<EntityTeacher> ListTeacher()
        {
            List<EntityTeacher> tempListe = new List<EntityTeacher>();

            SqlCommand commandRead = new SqlCommand("Select OgrtID,OgrtAdSoyad,OgrtDersID,DersAd from ÖğretmenTablosu inner join DersTablosu on ÖğretmenTablosu.OgrtDersID=DersTablosu.DersID", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            SqlDataReader dataReader = commandRead.ExecuteReader();

            while (dataReader.Read())
            {
                EntityTeacher teacher = new EntityTeacher();
                teacher.OgrtID = Convert.ToInt32(dataReader[0]);
                teacher.OgrtAdSoyad = dataReader[1].ToString();
                teacher.OgrtDersID = Convert.ToInt32(dataReader[2]);
                teacher.DersAd = dataReader[3].ToString();
                tempListe.Add(teacher);
            }

            dataReader.Close();

            return tempListe;
        }

        public void DeleteTeacher(int id)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from ÖğretmenTablosu where OgrtID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandDelete.Parameters.AddWithValue("@pid", id);

            commandDelete.ExecuteNonQuery();

        }

        public void AddTeacher(EntityTeacher teacher)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into ÖğretmenTablosu (OgrtAdSoyad,OgrtDersID) values (@pad,@pders)", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            
            commandAdd.Parameters.AddWithValue("@pad", teacher.OgrtAdSoyad);
            commandAdd.Parameters.AddWithValue("@pders", teacher.OgrtDersID);

            commandAdd.ExecuteNonQuery();

        }

        public List<EntityLesson> ListLessons()
        {
            List<EntityLesson> tempList = new List<EntityLesson>();

            SqlCommand commandRead = new SqlCommand("Select *from DersTablosu", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            SqlDataReader dataReader = commandRead.ExecuteReader();

            while (dataReader.Read())
            {
                EntityLesson lesson = new EntityLesson();
                lesson.DersID = Convert.ToInt32(dataReader[0]);
                lesson.DersAd = dataReader[1].ToString();
                lesson.MaxKont = Convert.ToInt32(dataReader[2]);
                lesson.MinKont = Convert.ToInt32(dataReader[3]);
                lesson.OgrSayısı = Convert.ToInt32(dataReader[4]);
                tempList.Add(lesson);
            }

            dataReader.Close();

            return tempList;
        } 

        public void EditTeacher(EntityTeacher teacher,int id)
        {
            SqlCommand commandEdit = new SqlCommand("Update ÖğretmenTablosu set OgrtAdSoyad=@pad, OgrtDersID=@pders where OgrtID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@pad", teacher.OgrtAdSoyad);
            commandEdit.Parameters.AddWithValue("@pders", teacher.OgrtDersID);
            commandEdit.Parameters.AddWithValue("@pid", id);

            commandEdit.ExecuteNonQuery();
        }
    }
}
