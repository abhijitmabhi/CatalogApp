using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemItemsRepository
    {
        public readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreateDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sowrd", Price = 20, CreateDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, CreateDate = DateTimeOffset.Now },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
