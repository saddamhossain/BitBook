using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BitBookLoginApp.Models
{
    public class UserLivedInfo
    {
        public int Id { set; get; }

        [DisplayName("Current Home Town")]
        public string HomeTown { set; get; }

        [DisplayName("Current Division")]
        public string Division { set; get; }

        [DisplayName("Country")]
        public string Country { set; get; }
    }
}