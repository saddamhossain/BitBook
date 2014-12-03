using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BitBookLoginApp.Models
{
    public class UserWorkAndStudyInfo
    {
        public int Id { set; get; }

        [DisplayName("Work")]
        public string WorkStation { set; get; }

        [DisplayName("PROFESSIONAL SKILLS")]
        public string ProfessionalSkill { set; get; }

        [DisplayName("UNIVERSITY")]
        public string University { set; get; }

        [DisplayName("COLLEGE")]
        public string College { set; get; }

        [DisplayName("HIGH SCHOOL")]
        public string HighSchool { set; get; }
    }
}