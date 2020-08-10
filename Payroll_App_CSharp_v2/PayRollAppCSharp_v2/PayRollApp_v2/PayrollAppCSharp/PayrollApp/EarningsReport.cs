using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PayrollApp
{
    public class EarningsReport
    {
        public static void PrintEmployeeReport(string employeePath)
        {
            List<Employee> employeeList = FileReaderWriter.GetEmployeeList(employeePath);


            foreach (var item in employeeList)
            {
                Console.WriteLine($"{item.Name} will earn {item.CalculateTotalPay():C} this pay period.");
            }

            double employeeTotalHoursWorked = CalculateEmployeeTotalHoursWorked(employeePath);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"The total hours worked by the employees is {employeeTotalHoursWorked}.");

        }

        public static void PrintManagerReport(string managerPath)
        {
            List<Manager> managerList = FileReaderWriter.GetManagerList(managerPath);


            foreach (var item in managerList)
            {
                Console.WriteLine($"{item.Name} will earn {item.CalculateTotalPay():C} this pay period.");
            }

            double managerTotalHoursWorked = CalculateManagerTotalHoursWorked(managerPath);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"The total hours worked by the managers is {managerTotalHoursWorked}.");

        }

        public static void PrintContractorReport(string contractorPath)
        {
            List<Contractor> contractorList = FileReaderWriter.GetContractorList(contractorPath);

            foreach (var item in contractorList)
            {
                Console.WriteLine($"{item.Name} will earn {item.CalculateTotalPay():C} this pay period.");
            }

            double contractorTotalHoursWorked = CalculateContractorTotalTotalHoursWorked(contractorPath);

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"The total hours worked by the contractors is {contractorTotalHoursWorked}.");
        }

        public static double CalculateEmployeeTotalHoursWorked(string employeePath)
        {
            List<Employee> employeeList = FileReaderWriter.GetEmployeeList(employeePath);

            double employeeSum = 0;
            foreach (var entry in employeeList)
            {
                employeeSum += entry.HoursWorked;
            }

            return employeeSum;

        }

        public static double CalculateManagerTotalHoursWorked(string managerPath)
        {
            List<Manager> managerList = FileReaderWriter.GetManagerList(managerPath);


            double managerSum = 0;
            foreach (var entry in managerList)
            {
                managerSum += entry.HoursWorked;
            }

            return managerSum;

        }

        public static double CalculateContractorTotalTotalHoursWorked(string contractorPath)
        {
            List<Contractor> contractorList = FileReaderWriter.GetContractorList(contractorPath);


            double contractorSum = 0;

            foreach (var entry in contractorList)
            {
                contractorSum += entry.HoursWorked;
            }

            return contractorSum;

        }

    }
}
