using System;
using Otus.NewFeatures.LoanCalculator;
using Otus.NewFeatures.LoanCalculator.Dtos;


//NEW FEATURE
LoanDto loan1 = new(300000, 18, 15);
//NEW FEATURE
var loan2 = loan1 with { NumberMonths = 24 };

var annuityPayment1 = LoanCalculatorService.GetAnnuityPayment(loan1);
var annuityPayment2 = LoanCalculatorService.GetAnnuityPayment(loan2);

Console.WriteLine($"Первый аннуитетный платеж: {annuityPayment1}");
Console.WriteLine($"Второй аннуитетный платеж: {annuityPayment2}");
