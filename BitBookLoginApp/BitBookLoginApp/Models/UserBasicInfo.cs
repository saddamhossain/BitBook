using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BitBookLoginApp.Models
{
    public class UserBasicInfo
    {
        public int Id { set; get; }

        [DisplayName("Phone")]
        public string MobileNumber { set; get; }

        [DisplayName("Website")]
        public string WebsiteName { set; get; }

        [DisplayName("Email")]
        public string Email { set; get; }

        [DisplayName("Birth Date")]
        public DateTime BirthDate { set; get; }

        [DisplayName("Gender")]
        public string Gender { set; get; }
        [DisplayName("Interested In")]
        public string InterestedIn { set; get; }
        [DisplayName("Language")]
        public string Language { set; get; }
        [DisplayName("Religious View")]
        public string Relegious { set; get; }

        [DisplayName("Political Views")]
        public string Political { set; get; }
    }
}