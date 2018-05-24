using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace Master_Detail_Pattern_MVVM
{
    public class ViewModel : ViewModelBase
    {
        public List<Employee> Source {            get { return GetProperty<List<Employee>>(); }            set { SetProperty(value); }        }
        public Employee SelectedEmployee {            get { return GetProperty<Employee>(); }            set { SetProperty(value); }        }

        public ViewModel()
        {
            Source = EmployeeData.DataSource;
            SelectedEmployee = Source[0];
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public string Phone { get; set; }
    }
    public class EmployeeData : List<Employee>
    {
        public static List<Employee> DataSource {
            get {
                List<Employee> list = new List<Employee>();
                list.Add(new Employee()
                {
                    FirstName = "Nathan",
                    LastName = "White",
                    Country = "Spain",
                    City = "Madrid",
                    Address = "90 7th Street",
                    JobTitle = "Sales Manager",
                    Phone = "(417) 166-3268"
                });
                list.Add(new Employee()
                {
                    FirstName = "Sandra",
                    LastName = "Oldman",
                    Country = "United States",
                    City = "LA",
                    Address = "3687 Mohawk Street",
                    JobTitle = "Marketing Manager",
                    Phone = "(918) 161-3649"
                });
                list.Add(new Employee()
                {
                    FirstName = "Andrea",
                    LastName = "Deville",
                    Country = "United Kingdom",
                    City = "London",
                    Address = "14 Garrett Hill",
                    JobTitle = "Accountant",
                    Phone = "(303) 718-1654"
                });
                list.Add(new Employee()
                {
                    FirstName = "George",
                    LastName = "Holloway",
                    Country = "Canada",
                    City = "Ottawa",
                    Address = "23 Tsawassen Blvd.",
                    JobTitle = "Accounts Manager",
                    Phone = "(720) 971-3927"
                });
                list.Add(new Employee()
                {
                    FirstName = "Barbara",
                    LastName = "Chinavare",
                    Country = "Hungary",
                    City = "Budapest",
                    Address = "6688 Alhambra Ave",
                    JobTitle = "Tool Designer",
                    Phone = "(360) 186-4982"
                });
                return list;
            }
        }
    }
}
