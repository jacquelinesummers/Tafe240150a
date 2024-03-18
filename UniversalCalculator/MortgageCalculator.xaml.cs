﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			// Calculate monthly interest rate

			monthlyInterestRate = annualInterestRate / MONTHS_IN_YEAR;



			monthlyInterestRate = monthlyInterestRate * 0.01;



			// Calculate number of months

			numberOfMonths = (years * 12) + months;



			// Calculate NUMERATOR of Monthly Repayment Calculation

			monthlyRepaymentCalculationNumerator = principal * (Math.Pow(1 + monthlyInterestRate, numberOfMonths)) * monthlyInterestRate;



			// Calculate Denominator of Monthly Repayment Calculation

			monthlyRepaymentCalculationDenominator = Math.Pow(1 + monthlyInterestRate, numberOfMonths) - 1;



			// Calculate Monthly Repayment

			monthlyRepayment = monthlyRepaymentCalculationNumerator / monthlyRepaymentCalculationDenominator;
		}
	}
}
