
class Item
{
    // Властивості товару
}

class Order
{
    private List<Item> itemList = new List<Item>();

    public IReadOnlyList<Item> ItemList => itemList.AsReadOnly();

    public void AddItem(Item item) => itemList.Add(item);

    public void DeleteItem(Item item) => itemList.Remove(item);

    public int GetItemCount() => itemList.Count;

    public decimal CalculateTotalSum()
    {
        // Реалізація обчислення суми
        return 0;
    }
}

class OrderPrinter
{
    public void PrintOrder(Order order)
    {
        // Реалізація виведення замовлення
    }

    public void ShowOrder(Order order)
    {
        // Реалізація відображення замовлення
    }
}

class OrderRepository
{
    public void Load(Order order)
    {
        // Реалізація завантаження
    }

    public void Save(Order order)
    {
        // Реалізація збереження
    }

    public void Update(Order order)
    {
        // Реалізація оновлення
    }

    public void Delete(Order order)
    {
        // Реалізація видалення
    }
}
