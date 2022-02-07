using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        private readonly IInMemItemsRepository inMemItemsRepository;

        public ItemController(IInMemItemsRepository inMemItemsRepository)
        {
            this.inMemItemsRepository = inMemItemsRepository;
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return inMemItemsRepository.GetItems();
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = inMemItemsRepository.GetItem(id);

            if(item is null)
            {
                return NotFound();
            }

            return item;
        }
    }
}
