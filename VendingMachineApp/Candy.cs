namespace VendingMachineApp;

public class Candy : Item
{
    public Candy(string Name, decimal Price, int Quantity) : base(Name, Price, Quantity)
    {
    }

    public override void Dispense()
    {
        Console.WriteLine("*Thud*... (Sweet!)");
    }
}