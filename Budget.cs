namespace BudgetV2;

internal class Budget
{
    public int Balance { get; private set; }
    
    private readonly List<Expense> _expenses = new List<Expense>();

    public Budget(int balance)
    {
        Balance = balance;
    }

    public void Calculate(int expenseAmount, string expenseName)
    {
        Balance -= expenseAmount;
        _expenses.Add(new Expense(expenseName, expenseAmount));
    }

    public void DisplayExpenses()
    {
        foreach (var expense in _expenses)
        {
            Console.WriteLine($"{expense.Name}: {expense.Amount} kroner");
        }

        Console.WriteLine("---------------------");
        Console.WriteLine($"Utgifter totalt: {CalculateTotalExpense()} kroner");
    }

    private int CalculateTotalExpense()
    {
        return _expenses.Sum(expense => expense.Amount);
    }
}