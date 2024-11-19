//У наданому прикладі порушено принцип Єдиного обов'язку (Single Responsibility Principle, SRP) з SOLID.

//Проблема:
//Клас Order відповідає за декілька різних обов’язків:

//Управління списком товарів (ItemList, AddItem, DeleteItem, тощо).
//Обчислення суми замовлення (CalculateTotalSum).
//Виведення інформації про замовлення (PrintOrder, ShowOrder).
//Робота з даними (завантаження, збереження, оновлення, видалення: Load, Save, Update, Delete).
//Це робить клас важким для тестування, підтримки та модифікації.

//Виправлення:
//Розділимо відповідальності класу на кілька спеціалізованих класів:

//Клас для роботи з бізнес-логікою замовлення (управління товарами та обчислення суми).
//Клас для роботи з представленням (виведення інформації).
//Клас для збереження і завантаження даних.


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
