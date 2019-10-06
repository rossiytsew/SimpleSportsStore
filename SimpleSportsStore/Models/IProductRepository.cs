using System.Linq;

namespace SimpleSportsStore.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
