using EmployeeApp.Model;
using EmployeeApp.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.ViewModel
{
    public class EmployeeViewModel : BaseViewModel
    {
        public ObservableCollection<EmployeeDTO> Employees { get; set; }
        public EmployeeDTO CurrentEmployee { get; set; }
        public RelayCommand SaveCommand { get; }
        public RelayCommand SearchCommand { get; }
        public RelayCommand UpdateCommand { get; }
        public RelayCommand DeleteCommand { get; }
        public string Message { get; set; }
        private EmployeeService EmployeeService;

        public EmployeeViewModel()
        {
            EmployeeService = new EmployeeService();
            loadData();
            CurrentEmployee = new EmployeeDTO();
            SaveCommand = new RelayCommand(save);
            SearchCommand = new RelayCommand(search);
            UpdateCommand = new RelayCommand(update);
            DeleteCommand = new RelayCommand(delete);
        }

        public void loadData()
        {
            Employees = new ObservableCollection<EmployeeDTO>(EmployeeService.getAll());
        }

        public void save()
        {
            try
            {
                bool isSaved = EmployeeService.add(CurrentEmployee);
                loadData();
                if (isSaved)
                    Message = "Employee saved";
                else
                    Message = "Save operation failed";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        public void search()
        {
            try
            {
                EmployeeDTO employee = EmployeeService.search(CurrentEmployee.Id);
                if (employee != null)
                {
                    CurrentEmployee.Name = employee.Name;
                    CurrentEmployee.Age = employee.Age;
                    Message = CurrentEmployee.Name + " found";
                }
                else
                    Message = "Employee not found.";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        public void update()
        {
            try
            {
                var isUpdated = EmployeeService.update(CurrentEmployee);
                if (isUpdated)
                {
                    Message = CurrentEmployee.Name + " updated.";
                    loadData();
                }
                else
                    Message = "Update Operation Failed!";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

        public void delete()
        {
            try
            {
                var isDeleted = EmployeeService.delete(CurrentEmployee.Id);
                if (isDeleted)
                {
                    Message = "Employee deleted.";
                    loadData();
                }
                else
                {
                    Message = "Delete operation failed.";
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }

    }
}
