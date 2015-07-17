using System.Data.Entity.ModelConfiguration;

using Domain.Models;

namespace Domain.Configurations
{
    public class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseDomainModel
    {
    }
}
