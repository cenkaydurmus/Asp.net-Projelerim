using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusniessLogicLayer
{
   public class BllStudent
    {
        DalStudent x = new DalStudent();
        public void BllAddStudent(EntityStudent student)
        {
            
            x.AddStudent(student);

        }

        public List<EntityStudent> BllListStudents()
        {
            return x.listStudents();
        }

        public void BllDeleteStudent(int id)
        {
            x.DeleteStudent(id);
        }

        public void BllEditStudent(EntityStudent student)
        {
            x.EditStudent(student);
        }
    }
}
