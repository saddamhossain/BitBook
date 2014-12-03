using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BitBookLoginApp.Models
{
    public class BitBookDbContext : DbContext
    {
        public BitBookDbContext() : base("name=dbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BitBookDbContext>());
        }

        public DbSet<UserBasicInfo> UserBasicInfos { set; get; }
        public DbSet<UserLivedInfo> UserLivedInfos { set; get; }
        public DbSet<UserWorkAndStudyInfo> UserWorkAndStudyInfos { set; get; }
        public DbSet<ImageGallery> ImageGalleries { set; get; }
 


    }
}