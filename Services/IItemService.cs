
using System.Collections.Generic;
using TestingMudBlazor.CRUD.Data;

namespace TestingMudBlazor.CRUD.Services
{
public interface IItemService
{
    List<Item> GetItems();
    Item GetItemById(int id);
    void SaveItem(Item item);
    void DeleteItem(int id);
}
}