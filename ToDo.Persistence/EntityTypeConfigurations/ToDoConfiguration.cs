using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using T


namespace ToDo.Persistence.EntityTypeConfigurations
{
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
    {
        public void Configuration( EntityTypeBuilder<ToDo> builder ) 
        {
            builder.HasKey( x => x.Id );
            builder.HasIndex( x => x.Id ).IsUnique();
            builder.Property(x => x.Title).HasMaxLength( 50 );
        }
    }
}
