using System.Collections.Generic;
using System.Linq;
using TestingMudBlazor.CRUD.Data;
using TestingMudBlazor.CRUD.Models;

namespace TestingMudBlazor.CRUD.Services
{
    public class ItemService : IItemService
    {
        private readonly ApplicationDbContext _dbContext;
        public ItemService(ApplicationDbContext dbContext) //Dependency Injection of the ApplicationDb context into the constructor of the Item Service.
        {
            _dbContext = dbContext;
        }

        public void DeleteItem(int id)
        {
            var item = _dbContext.Items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _dbContext.Items.Remove(item);
                _dbContext.SaveChanges();
            }
        }
        public Item GetItemById(int id)
        {
            var item = _dbContext.Items.SingleOrDefault(x => x.Id == id);
            return item;
        }

        public List<Item> GetItems()
        {
            var items = _dbContext.Items.ToList();
            return items;
        }

        public void SaveItem(Item item)
        {
            if (item.Id == 0) _dbContext.Items.Add(item); //Id of 0, it means that it is probably a new record, and hence save this as a new customer
            else _dbContext.Items.Update(item);
            _dbContext.SaveChanges();
        }
    }
}
