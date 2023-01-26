/* PROGRAM DESCRIPTION:
AUTHOR: Caitlyn Smith
DATE: 01/26/2023
EMAIL: c-smith54@hvcc.edu

PROGRAM OBJECTIVE:
Objectives from Program 02B, PLUS:
    1) Prompt for the Employee name and sales amount
    2) Write static methods to calculate each of the deductions (federal tax, state tax, retirement, social security, total deductions). 
    3) Format output as was done in 2B.
*/

using System;
using static System.Console;

namespace Ch2 {
    class Chapter2 {
        const decimal SALES_COMMISSION = 0.07M;
        const decimal FEDERAL_TAX_RATE = 0.18M;
        const decimal STATE_TAX_RATE = 0.031M;
        const decimal RETIREMENT_RATE = 0.10M;
        const decimal SOCIAL_SECURITY_RATE = 0.06M;

        public static void Main(string[] args) {
            //User input
            Write("Please enter your name: ");
            string empName = ReadLine();

            Write("Please enter your sales: ");
            string salesInput = ReadLine();
            decimal sales = decimal.Parse(salesInput);

            //Variables from calculations
            decimal grossPay = sales * SALES_COMMISSION;
            decimal takeHomePay = grossPay - TotalDeductions(sales);

            //Output
            WriteLine("---------------------------------------");
            WriteLine("{0,-26}{1,8:C}", "Employee Name:", empName);
            WriteLine("{0,-26}{1,8:C}", "Total Sales:", sales);
            WriteLine("{0,-26}{1,8:C}", "Gross Pay:", grossPay);
            WriteLine("{0,-26}{1,8:C}", "Federal Taxes:", FederalTax(sales));
            WriteLine("{0,-25}{1,8:C}", "State Taxes:", StateTax(sales));
            WriteLine("{0,-25}{1,8:C}", "Social Security Taxes:", SocialSecurity(sales));
            WriteLine("{0,-25}{1,8:C}", "Retirement Contribution:", Retirement(sales));
            WriteLine("---------------------------------------");
            WriteLine("{0,-26}{1,8:C}", "Total Deducations:", TotalDeductions(sales));
            WriteLine("{0,-26}{1,8:C}", "Take Home Pay:", takeHomePay);

            ReadKey();
        }

        public static decimal FederalTax(decimal sales) {
            decimal grossPay = sales * SALES_COMMISSION;
            return grossPay * FEDERAL_TAX_RATE;
        }

        public static decimal StateTax(decimal sales) {
            decimal grossPay = sales * SALES_COMMISSION;
            return grossPay * STATE_TAX_RATE;
        }

        public static decimal SocialSecurity(decimal sales) {
            decimal grossPay = sales * SALES_COMMISSION;
            return grossPay * SOCIAL_SECURITY_RATE;
        }

        public static decimal Retirement(decimal sales) {
            decimal grossPay = sales * SALES_COMMISSION;
            return grossPay * RETIREMENT_RATE;
        }

        public static decimal TotalDeductions(decimal sales) {
            decimal grossPay = sales * SALES_COMMISSION;
            return FederalTax(sales) + StateTax(sales) + SocialSecurity(sales) + Retirement(sales);
        }
    }
}