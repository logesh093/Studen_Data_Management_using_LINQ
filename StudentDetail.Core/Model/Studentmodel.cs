using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Core.Model
{
    public class Studentmodel
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string DOB { get; set; }

        public string Gender { get; set; }

        public string Course { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsEnglish { get; set; }

        public bool IsMathmatics { get; set; }

        public bool IsPhysics { get; set; }

        public bool IsChemistry { get; set; }

        public bool IsBiology { get; set; }

        public DateTime CreateTime_Stamp { get; set; }

        public DateTime Update_Time_Stamp { get; set; }
    }
}
