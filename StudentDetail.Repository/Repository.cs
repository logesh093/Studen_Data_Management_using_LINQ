using Entity.Models;
using StudentData.Core.IRepository;
using StudentData.Core.Model;


namespace StudentDetail.Repository
{
    public class Repository : IRepository
    {
        public demoContext entity;
        public Repository(demoContext demoContext)
        {
            entity = demoContext;
        }

        public void SaveandUpdateStudentDetails(Studentmodel studentmodel)
        {
            
                bool isExist = false;
                var studentDetail = entity.StudentDetailTbl_LINQ_s.Where(s => s.Student_Id == studentmodel.StudentId).SingleOrDefault();

                if (studentDetail == null)
                {

                    studentDetail = new Entity.Models.StudentDetailTbl_LINQ_();   
                }
                else
                {
                    isExist = true;
                }

                studentDetail.Student_Name = studentmodel.StudentName;
                studentDetail.DOB = studentmodel.DOB;
                studentDetail.Gender = studentmodel.Gender;
                studentDetail.Address = studentmodel.Address;
                studentDetail.Contact_Number = studentmodel.ContactNumber;
                studentDetail.Email = studentmodel.Email;
                studentDetail.Course = studentmodel.Course;
                studentDetail.Is_Mathmatics = studentmodel.IsMathmatics;
                studentDetail.Is_English = studentmodel.IsEnglish;
                studentDetail.Is_Chemistry = studentmodel.IsChemistry;
                studentDetail.Is_Physics = studentmodel.IsPhysics;
                studentDetail.Is_Biology = studentmodel.IsBiology;

            if (!isExist)
                {
                    studentDetail.Create_Time_Stamp = DateTime.Now;
                    entity.StudentDetailTbl_LINQ_s.Add(studentDetail);  
                }
                studentDetail.Update_Time_Stamp = DateTime.Now;
                entity.SaveChanges();



            
        }
        public List<Studentmodel> StudentDashBoard()
        {
            List<Studentmodel> model = new List<Studentmodel>();
            var student = entity.StudentDetailTbl_LINQ_s.Where( x=>!x.Is_Deleted).ToList();
            foreach (var str1 in student)
            {
                if (str1.Is_Deleted == false)
                {
                    Studentmodel model1 = new Studentmodel();
                    model1.StudentId = str1.Student_Id;
                    model1.StudentName = str1.Student_Name;
                    model1.DOB = str1.DOB;
                    model1.Gender = str1.Gender;
                    model1.Address = str1.Address;
                    model1.ContactNumber = str1.Contact_Number;
                    model1.Email = str1.Email;
                    model1.Course = str1.Course;

                    model.Add(model1);
                }
            }
            
            return model;
        }

        public Studentmodel GetStudentdetail(int id)
        {

            Studentmodel obj = new Studentmodel();
            var existingStudent = entity.StudentDetailTbl_LINQ_s.SingleOrDefault(s => s.Student_Id == id);
            obj.StudentId = existingStudent.Student_Id;
            obj.StudentName = existingStudent.Student_Name;
            obj.DOB = existingStudent.DOB;
            obj.Gender = existingStudent.Gender;
            obj.Address = existingStudent.Address;
            obj.ContactNumber = existingStudent.Contact_Number;
            obj.Email = existingStudent.Email;
            obj.Course = existingStudent.Course;
            obj.IsMathmatics = existingStudent.Is_Mathmatics;
            obj.IsEnglish = existingStudent.Is_English;
            obj.IsChemistry = existingStudent.Is_Chemistry;
            obj.IsPhysics = existingStudent.Is_Physics;
            obj.IsBiology = existingStudent.Is_Biology;
            return obj;
        }

        #region Delete Student detail by Id
        public void Delete(int id)
        {
            var studentToDelete = entity.StudentDetailTbl_LINQ_s.SingleOrDefault(s => s.Student_Id == id);
            if (studentToDelete != null)
            {
                studentToDelete.Is_Deleted = true;
                entity.SaveChanges();
            }
        }
        #endregion


    }
}
