namespace BudgetV2;

internal class Expense
{
    public string Name { get; private set; }
    public int Amount { get; private set; }   
    
    public Expense(string name, int amount)
    {
        Name = name;
        Amount = amount;
    }
}