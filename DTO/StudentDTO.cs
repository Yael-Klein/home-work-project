using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class StudentDTO
    {
        public int studentId { get; set; }
        public string studentTz { get; set; }
        public string studentFirstName { get; set; }
        public string studentLastName { get; set; }
        public string studentPel { get; set; }
        public string studentCity { get; set; }
        public string studentAddress { get; set; }
        public string studentParentName { get; set; }
        public string studentParentPel { get; set; }
        public string studentParentEmail { get; set; }
        public StudentDTO()
        {

        }

        public StudentDTO(int studentId, string studentTz, string studentFirstName, string studentLastName, string studentPel, string studentCity, string studentAddress, string studentParentName, string studentParentPel, string studentParentEmail)
        {
            this.studentId = studentId;
            this.studentTz = studentTz;
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
            this.studentPel = studentPel;
            this.studentCity = studentCity;
            this.studentAddress = studentAddress;
            this.studentParentName = studentParentName;
            this.studentParentPel = studentParentPel;
            this.studentParentEmail = studentParentEmail;
        }
    }
}
