namespace VendingMachineApp;

public abstract class Item
{
    public string Name { get; protected set; }
    public decimal Price { get; protected set; }
    public int Quantity { get; set; }

    public Item(string Name, decimal Price, int Quantity)
    {
        this.Name = Name;
        this.Price = Price;
        this.Quantity = Quantity;
    }

    public abstract void Dispense();
}
