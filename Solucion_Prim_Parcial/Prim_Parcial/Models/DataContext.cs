using System.Data.Entity;

namespace Prim_Parcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Prim_Parcial.Models.Aldana> Aldanas { get; set; }
    }
}