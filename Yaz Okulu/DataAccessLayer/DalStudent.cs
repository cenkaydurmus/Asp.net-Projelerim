using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
   public class DalStudent
    {
        public void AddStudent(EntityStudent student)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into ÖğrenciTablosu (OgrAd,OgrSoyad,OgrMail,OgrSifre,OgrOkulNo) values (@pad,@psoyad,@pmail,@psif,@pno)", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandAdd.Parameters.AddWithValue("@pad", student.OgrAd);
            commandAdd.Parameters.AddWithValue("@psoyad", student.OgrSoyad);
            commandAdd.Parameters.AddWithValue("@pmail", student.OgrMail);
            commandAdd.Parameters.AddWithValue("@psif", student.OgrSifre);
            commandAdd.Parameters.AddWithValue("@pno", student.OgrOkulNo);

            commandAdd.ExecuteNonQuery();
        }

        public List<EntityStudent> listStudents()
        {
            List<EntityStudent> tempList = new List<EntityStudent>();

            SqlCommand commandRead = new SqlCommand("Select *from ÖğrenciTablosu", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            SqlDataReader dataReader = commandRead.ExecuteReader();

            while (dataReader.Read())
            {
                EntityStudent student = new EntityStudent();
                student.OgrID = (int)dataReader[0];
                student.OgrAd = dataReader[1].ToString();
                student.OgrSoyad = dataReader[2].ToString();
                student.OgrMail = dataReader[3].ToString();
                student.OgrSifre = dataReader[4].ToString();
                student.Bakiye = Convert.ToInt32(dataReader[5]);
                student.OgrOkulNo = dataReader[6].ToString();
                tempList.Add(student);
            }

            dataReader.Close();

            return tempList;
        }

        public void DeleteStudent(int id)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from ÖğrenciTablosu where OgrID=@p1", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandDelete.Parameters.AddWithValue("@p1", id);

            commandDelete.ExecuteNonQuery();
        }

        public void EditStudent(EntityStudent student)
        {
            SqlCommand commandEdit = new SqlCommand("Update ÖğrenciTablosu set OgrAd=@pad , OgrSoyad=@psoyad , OgrMail=@pmail , OgrOkulNo=@pno , OgrSifre=@psif where OgrID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@pad", student.OgrAd);
            commandEdit.Parameters.AddWithValue("@psoyad", student.OgrSoyad);
            commandEdit.Parameters.AddWithValue("@pmail", student.OgrMail);
            commandEdit.Parameters.AddWithValue("@pno", student.OgrOkulNo);
            commandEdit.Parameters.AddWithValue("@psif", student.OgrSifre);
            commandEdit.Parameters.AddWithValue("@pid", student.OgrID);


            commandEdit.ExecuteNonQuery();
        }
    }
}
