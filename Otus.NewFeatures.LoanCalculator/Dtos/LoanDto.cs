namespace Otus.NewFeatures.LoanCalculator.Dtos
{
    //NEW FEATURE
    public record LoanDto(double LoanAmount, ushort NumberMonths, double InterestRate);
}
