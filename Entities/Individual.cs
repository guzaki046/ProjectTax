namespace ProjectTax.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnnualIncome < 20000)
            {
                tax = (AnnualIncome * 0.15);
            }
            else
            {
                tax = AnnualIncome * 0.25 - (HealthExpenditures * 0.5);
            }
            return tax;
        }
    }
}
