using StudentData.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Core.IRepository
{
    public interface IRepository
    {
        void SaveandUpdateStudentDetails(Studentmodel Studentmodel);
        List<Studentmodel> StudentDashBoard();
        Studentmodel GetStudentdetail(int id);
        void Delete(int id);
        //Student_model Search(Student_model id);

    }
}
