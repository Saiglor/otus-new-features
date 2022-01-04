using Otus.NewFeatures.LoanCalculator.Dtos;
using System;

namespace Otus.NewFeatures.LoanCalculator
{
    public class LoanCalculatorService
    {
        public static PaymentDto GetAnnuityPayment(LoanDto loan)
        {
            //NEW FEATURE
            if (loan is null) throw new ArgumentNullException();

            var monthlyInterestRate = loan.InterestRate / 1200;

            var annuityRatio = monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loan.NumberMonths) /
                               (Math.Pow(1 + monthlyInterestRate, loan.NumberMonths) - 1);

            var payment = Math.Round(annuityRatio * loan.LoanAmount, 2);

            var overpayment = Math.Round(payment * loan.NumberMonths - loan.LoanAmount, 2);

            return new(payment, overpayment);
        }
    }
}