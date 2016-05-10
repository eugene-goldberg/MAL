using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using MAL.Module.MAL;
using MAL.Module.UDMRelational;
using MAL.Module.UDM;

namespace  MAL.Module.BusinessObjects {
	public class MALDbContext : DbContext {
		public MALDbContext(String connectionString)
			: base(connectionString) {
		}
		public MALDbContext(DbConnection connection)
			: base(connection, false) {
		}
        public DbSet<Account> Account { get; set; }
        public DbSet<AccountAlias> AccountAliases { get; set; }
        public DbSet<AccountRolePerson> AccountRolePerson { get; set; }
        public DbSet<AccountProgram> AccountProgram { get; set; }
        public DbSet<Industry> Industry { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionAlias> RegionAlias { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Program> Program { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Tool> Tool { get; set; }
        public virtual DbSet<Offering> Offering { get; set; }
        public virtual DbSet<ChangeMeasure> ChangeMeasures { get; set; }
        public virtual DbSet<AccountTool> AccountTools { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
    }
}