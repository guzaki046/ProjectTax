using ProjectTax.Entities;
using System.Globalization;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Annual income: ");
    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (ch == 'c')
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        list.Add(new Company(name, annualIncome, numberOfEmployees));
    }
    else
    {
        Console.Write("Health expeditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(name, annualIncome, healthExpenditures));
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
foreach (TaxPayer payer in list)
{
    Console.WriteLine(payer.Name + ": $" + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
}
