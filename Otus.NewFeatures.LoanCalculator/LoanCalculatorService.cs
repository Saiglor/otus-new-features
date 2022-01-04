using Otus.NewFeatures.LoanCalculator.Dtos;
using System;

namespace Otus.NewFeatures.LoanCalculator
{
    public class LoanCalculatorService
    {
        public static double GetAnnuityPayment(LoanDto loan)
        {
            //NEW FEATURE
            if (loan is null) throw new ArgumentNullException();

            var monthlyInterestRate = loan.InterestRate / 1200;

            var annuityRatio = monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loan.NumberMonths) /
                               (Math.Pow(1 + monthlyInterestRate, loan.NumberMonths) - 1);

            return Math.Round(annuityRatio * loan.LoanAmount, 2);
        }
    }
}