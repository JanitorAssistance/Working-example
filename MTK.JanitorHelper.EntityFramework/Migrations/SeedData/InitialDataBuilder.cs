using MTK.JanitorHelper.EntityFramework;

namespace MTK.JanitorHelper.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly JanitorHelperDbContext _context;

        public InitialDataBuilder(JanitorHelperDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
            new DefaultLanguagesBuilder(_context).Build();
            new CustomerBuilder(_context).Create();
            new CityBuilder(_context).Create();
        }
    }
}
