using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class DalLesson
    {
        public List<EntityLesson> ListLesson()
        {
            List<EntityLesson> tempList = new List<EntityLesson>();

            SqlCommand commandRead = new SqlCommand("Select *from DersTablosu",SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            SqlDataReader dataReader = commandRead.ExecuteReader();

            while (dataReader.Read())
            {
                EntityLesson lesson = new EntityLesson();
                lesson.DersID= Convert.ToInt32(dataReader[0]);
                lesson.DersAd = dataReader[1].ToString();
                lesson.MaxKont = Convert.ToInt32(dataReader[2]);
                lesson.MinKont = Convert.ToInt32(dataReader[3]);
                lesson.OgrSayısı = Convert.ToInt32(dataReader[4]);
                tempList.Add(lesson);
            }

            dataReader.Close();

            return tempList;
        }

        public void DeleteLesson(int id)
        {
            SqlCommand commandDelete = new SqlCommand("Delete from DersTablosu where DersID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandDelete.Parameters.AddWithValue("@pid", id);

            commandDelete.ExecuteNonQuery();
        }

        public void AddLesson(EntityLesson lesson)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into DersTablosu (DersAd,MaxKont,MinKont,OgrSayısı) values (@pname,@pmax,@pmin,@pogr)", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            

            commandAdd.Parameters.AddWithValue("@pname", lesson.DersAd);

            commandAdd.Parameters.AddWithValue("@pmax", lesson.MaxKont);

            commandAdd.Parameters.AddWithValue("@pmin", lesson.MinKont);

            commandAdd.Parameters.AddWithValue("@pogr", lesson.OgrSayısı);

            commandAdd.ExecuteNonQuery();
        }

        public void EditLesson(EntityLesson lesson,int id)
        {
            SqlCommand commandEdit = new SqlCommand("Update DersTablosu set DersAd=@pad , MaxKont=@pmax , MinKont=@pmin , OgrSayısı=@pogr where DersID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandEdit.Parameters.AddWithValue("@pid", id);

            commandEdit.Parameters.AddWithValue("@pad", lesson.DersAd);
            
            commandEdit.Parameters.AddWithValue("@pmax", lesson.MaxKont);
            
            commandEdit.Parameters.AddWithValue("@pmin", lesson.MinKont);
            
            commandEdit.Parameters.AddWithValue("@pogr", lesson.OgrSayısı);
            
            commandEdit.ExecuteNonQuery();
        }
    }
}
