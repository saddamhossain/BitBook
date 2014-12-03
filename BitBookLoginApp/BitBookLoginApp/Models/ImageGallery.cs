using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BitBookLoginApp.Models
{
    public class ImageGallery
    {
        public ImageGallery()
        {
            ImageList = new List<string>();   
        }
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public List<string> ImageList { get; set; }
    }
}