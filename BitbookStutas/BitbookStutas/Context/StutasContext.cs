using System.Data.Entity;
using BitbookStutas.Models;

namespace BitbookStutas.Context
{
    public class StutasContext:DbContext

    {
        public DbSet<Stutas> Stutases { set; get; } 
    }
}