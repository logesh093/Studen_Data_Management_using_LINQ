using StudentData.Core.IRepository;
using StudentData.Core.IServices;
using StudentData.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetail.Services
{
    public class Services : IServices
    {

        private readonly IRepository _repository;
        public Services(IRepository repository)
        {
            _repository = repository;
        }
        public void SaveandUpdateStudentDetails(Studentmodel model)
        {
            _repository.SaveandUpdateStudentDetails(model);
        }
        public List<Studentmodel> StudentDashBoard()
        {
            return _repository.StudentDashBoard();
        }
        public Studentmodel GetStudentdetail(int id)
        {
            return _repository.GetStudentdetail(id);
        }
        public void Delete(int id)
        {

            _repository.Delete(id);

        }
    }
}
