using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibility.DAL
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=EZELHAN\\SQLEXPRESS;initial Catalog=ChainOfDb2; integrated security=true");
		}
		public DbSet<CustomerProcess>CustomerProcesses { get; set; }

		public static implicit operator ContextBoundObject(Context v)
		{
			throw new NotImplementedException();
		}
	}
}
