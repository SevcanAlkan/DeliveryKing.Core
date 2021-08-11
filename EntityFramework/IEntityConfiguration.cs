using Microsoft.EntityFrameworkCore;

namespace DeliveryKing.Core.EntityFramework
{
    public interface IEntityConfiguration
    {
        void Configure(ref ModelBuilder builder);
    }
}