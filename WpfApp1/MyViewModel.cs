using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls;

namespace WpfApp1
{
    class MyViewModel : ViewModelBase
    {
        private ObservableCollection<Employee> employees;

        public ObservableCollection<Employee> Employees
        {
            get
            {
                if (this.employees == null)
                {
                    this.employees = EmployeeService.GetEmployees();
                }

                return this.employees;
            }
        }
    }
}
