using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusniessLogicLayer
{
    public class BllLesson
    {
        DalLesson dalLesson = new DalLesson();

        public List<EntityLesson> BllListLesson()
        {
            return dalLesson.ListLesson();
        }

        public void BllDeleteLesson(int id)
        {
            dalLesson.DeleteLesson(id);
        }

        public void BllAddLesson(EntityLesson lesson)
        {
            dalLesson.AddLesson(lesson);
        }

        public void BllEditLesson(EntityLesson lesson,int id)
        {
            dalLesson.EditLesson(lesson,id);
        }
    }
}
