using Employees.Data;
using Microsoft.EntityFrameworkCore;

namespace Employees.Pages
{
    public partial class Index
    {
        public bool ShowCreate { get; set; }
        public bool ShowEdit { get; set; }
        public int EditingId { get; set; }

        private EmployeeDataContext? _context;
        public Employee? NewEmployee { get; set; }
        public Employee? EmployeeToUpdate { get; set; }
        public List<Employee>? OurEmployees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
            await ShowEmployees();
        }

        //------------------ Create! ----------------///
        public void ShowCreateForm()
        {
            ShowCreate = true;
            NewEmployee = new Employee();
        }

        public async Task CreateNewEmployee()
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (NewEmployee is not null)
            {
                _context?.Employees.Add(NewEmployee);
                _context?.SaveChangesAsync();
            }

            ShowCreate = false;
            await ShowEmployees();
        }

        //------------------ Read! ----------------///

        public async Task ShowEmployees()
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                OurEmployees = await _context.Employees.ToListAsync();
            }
        }

        //------------------ Update! ----------------///

        public async Task ShowEditForm(Employee ourEmployee)
        {

            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                EmployeeToUpdate = _context.Employees.FirstOrDefault(x => x.Id == ourEmployee.Id);
                ShowEdit = true;
                EditingId = ourEmployee.Id;
            }
        }

        public async Task UpdateEmployee()
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                if (EmployeeToUpdate is not null) _context.Employees.Update(EmployeeToUpdate);
                await _context.SaveChangesAsync();
            }
            ShowEdit = false;
        }

        //------------------ Delete! ----------------///

        public async Task DeleteEmployee(Employee ourEmployee)
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();
            if (_context is not null)
            {
                if (ourEmployee is not null) _context.Employees.Remove(ourEmployee);
                await _context.SaveChangesAsync();
            }
            await ShowEmployees();
        }
    }
}
