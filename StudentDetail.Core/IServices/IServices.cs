using StudentData.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Core.IServices
{
    public interface IServices
    {

        void SaveandUpdateStudentDetails(Studentmodel model);
        List<Studentmodel> StudentDashBoard();
        Studentmodel GetStudentdetail(int id);

        void Delete(int id);     
    }
}
