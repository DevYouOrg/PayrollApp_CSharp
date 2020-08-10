using System;
using System.Collections.Generic;
using System.IO;

namespace PayrollApp
{
    public class FileReaderWriter
    {

        public static List<Employee> GetEmployeeList(string employeePath)
        {

            //read from text file
            string[] lines = File.ReadAllLines(employeePath);




            List<Employee> employeeList = new List<Employee>();


            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Employee employee = new Employee();

                    var staffArray = line.Split('|');
                    employee.Name = staffArray[0];
                    employee.HoursWorked = Convert.ToDouble(staffArray[1]);

                    employeeList.Add(employee);
                }
            }

            return employeeList;
        }







        public static List<Manager> GetManagerList(string managerPath)
        {
            string[] lines = File.ReadAllLines(managerPath);
            List<Manager> managerList = new List<Manager>();


            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Manager manager = new Manager();

                    var staffArray = line.Split('|');
                    manager.Name = staffArray[0];
                    manager.HoursWorked = Convert.ToDouble(staffArray[1]);

                    managerList.Add(manager);
                }
            }

            return managerList;
        }




        public static List<Contractor> GetContractorList(string contractorPath)
        {
            string[] lines = File.ReadAllLines(contractorPath);
            List<Contractor> contractEmployees = new List<Contractor>();


            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    Contractor contractor = new Contractor();

                    var staffArray = line.Split('|');
                    contractor.Name = staffArray[0];
                    contractor.HoursWorked = Convert.ToDouble(staffArray[1]);

                    contractEmployees.Add(contractor);
                }
            }

            return contractEmployees;
        }



        public static void WriteStaffHoursToTextFile(string staffChoice, string staffName, string staffHours, string managerPath, string employeePath, string contractorPath)
        {

            string path = "";
            if (staffChoice == "m")
            {
                path = managerPath;
            }

            if (staffChoice == "e")
            {
                path = employeePath;
            }

            if (staffChoice == "c")
            {
                path = contractorPath;
            }


            using (StreamWriter writer = File.AppendText(path))
            {
                writer.WriteLine($"{staffName}|{staffHours}");
            }


            Console.WriteLine($"Adding complete... {Environment.NewLine}");
        }


    }
}
