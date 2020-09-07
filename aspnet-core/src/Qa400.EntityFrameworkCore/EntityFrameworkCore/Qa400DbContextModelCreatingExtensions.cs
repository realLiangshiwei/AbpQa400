using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Qa400.EntityFrameworkCore
{
    public static class Qa400DbContextModelCreatingExtensions
    {
        public static void ConfigureQa400(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(Qa400Consts.DbTablePrefix + "YourEntities", Qa400Consts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}