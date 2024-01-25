namespace BudgetV2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hva er ditt budsjett?>> ");
        if (int.TryParse(Console.ReadLine(), out int balance))
        {
            var budget = new Budget(balance);
            var messagePrinted = false;
            
            while (true)
            {
                if (!messagePrinted)
                {
                    Console.Write("Skriv navn på utgift eller 'avslutt' for å regne ut gjenstående saldo\n");
                    messagePrinted = true;
                }
                else
                {
                    Console.Write("Utgift: ");
                    var name = Console.ReadLine();
                    if (name?.ToLower() == "avslutt")
                        break;

                    Console.Write("Beløp: ");
                    if (int.TryParse(Console.ReadLine(), out int amount))
                    {
                        if (name != null) budget.Calculate(amount, name);
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig beløp");
                    }
                }
            }
            
            Console.WriteLine("---------------------");
            budget.DisplayExpenses();
            Console.WriteLine($"Saldo etter utgifter: {budget.Balance} kroner");
        }
        else
        {
            Console.WriteLine("Ugyldig beløp");
        }
    }
}