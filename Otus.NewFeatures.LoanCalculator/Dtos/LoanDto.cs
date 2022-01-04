using System;

namespace Otus.NewFeatures.LoanCalculator.Dtos
{
    //NEW FEATURE
    public record LoanDto
    {
        /// <summary>
        /// Сумма займа
        /// </summary>
        public double LoanAmount { get; init; }

        /// <summary>
        /// Количество месяцев
        /// </summary>
        public ushort NumberMonths { get; init; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double InterestRate { get; init; }

        public LoanDto(double loanAmount, ushort numberMonths, double interestRate)
        {
            //NEW FEATURE
            if (numberMonths is < 3 or > 1200)
                throw new ArgumentException("Срок займа должен быть в промежутке от 3 месяцев до 50 лет");
            //NEW FEATURE
            if (interestRate is < 0.01 or > 60)
                throw new ArgumentException("Ставка по займу должна быть в диапозоне от 0.01 до 60 % годовых");

            LoanAmount = loanAmount;
            NumberMonths = numberMonths;
            InterestRate = interestRate;
        }
    }
}