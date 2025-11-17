namespace VendingMachineApp;

public class Chip : Item
{
    public Chip(string Name, decimal Price, int Quantity) : base(Name, Price, Quantity)
    {
    }

    public override void Dispense()
    {
        Console.WriteLine("*Rattle*... *Crunch*...");
    }
}