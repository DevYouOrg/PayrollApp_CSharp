﻿namespace PayrollApp
{
    public class Manager
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }
        public double TotalPay { get; set; }
        public double Bonus { get; set; }

        public Manager()
        {
            HourlyRate = 50.00;
            Bonus = 100.00;
        }

        public double CalculateTotalPay()
        {
            BasePay = HoursWorked * HourlyRate;

            TotalPay = BasePay + Bonus;

            return TotalPay;
        }

    }
}

