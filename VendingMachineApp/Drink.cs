namespace VendingMachineApp;

public class Drink : Item
{
    public Drink(string Name, decimal Price, int Quantity) : base(Name, Price, Quantity)
    {
    }

    public override void Dispense()
    {
        Console.WriteLine("*Glug glug*... *Fizz*");
    }
}