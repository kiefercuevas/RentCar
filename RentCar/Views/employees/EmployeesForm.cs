using RentCar.Data;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Models.ViewModels;
using System.Text.RegularExpressions;

namespace RentCar.Views.employees
{
    public partial class EmployeesForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        private Employee Employee { get; set; }
        private string Action { get; set; }
        public EmployeesForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            Employee = new Employee
            {
                Users = new List<User>()
            };
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();

        }

        private void LoadEmployeeData()
        {
            int currentEmpId = (int)Global.Variables[Global.Id];

            var data = GetEmployeeViewModels(_context.Employees
                .GetEmployeesWithAll(emp => emp.State == true &&
                emp.EmployeeID != currentEmpId));

            DTGVemployees.AutoGenerateColumns = false;
            DTGVemployees.DataSource = data;
            LoadComboBoxes();
        }
        public IEnumerable<EmployeeViewModel> GetEmployeeViewModels(IEnumerable<Employee> employees)
        {
            List<EmployeeViewModel> EmployeeViewModels = new List<EmployeeViewModel>();
            foreach (var employee in employees)
            {
                EmployeeViewModels.Add(new EmployeeViewModel()
                {
                    EmpName = employee.Name,
                    EmployeeID = employee.EmployeeID,
                    AdmissionDate = employee.AdmissionDate.ToShortDateString(),
                    CommissionPercentage = employee.CommissionPercentage.ToString(),
                    IdentificationCard = employee.IdentificationCard,
                    State = employee.State,
                    UserRole =  employee.Users.FirstOrDefault().Role.Name,
                    WorkShift = employee.WorkShift.Description
                });
            }
            return EmployeeViewModels;
        }

        public void LoadComboBoxes()
        {
            LoadRoles(_context.Roles.GetAll());
            LoadWorkshift(_context.WorkShifts.GetAll());
        }

        public void LoadRoles(IEnumerable<Role> roles)
        {
            if (roles.Count() > 0)
            {
                Dictionary<int, string> rolesData = new Dictionary<int, string>();

                foreach (var role in roles)
                    rolesData.Add(role.RoleID, role.Name);

                CBXroles.DataSource = new BindingSource(rolesData, null);
                CBXroles.DisplayMember = "Value";
                CBXroles.ValueMember = "Key";
            }
            else
            {
                CBXroles.DataSource = null;
                CBXroles.Items.Clear();
                CBXroles.Items.Add("No hay roles");
            }
        }

        public void LoadWorkshift(IEnumerable<WorkShift> workShifts)
        {
            if (workShifts.Count() > 0)
            {
                Dictionary<int, string> workshitfData = new Dictionary<int, string>();

                foreach (var workShift in workShifts)
                    workshitfData.Add(workShift.WorkShiftID,workShift.Description);

                CBXworkShift.DataSource = new BindingSource(workshitfData, null);
                CBXworkShift.DisplayMember = "Value";
                CBXworkShift.ValueMember = "Key";
            }
            else
            {
                CBXworkShift.DataSource = null;
                CBXworkShift.Items.Clear();
                CBXworkShift.Items.Add("No hay tandas laborales");
            }
        }

        private void DTGVemployees_DoubleClick(object sender, EventArgs e)
        {
            if (DTGVemployees.Rows.Count > 0 && DTGVemployees.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVemployees.CurrentRow.Cells["EmployeeID"].Value);
                Employee = _context.Employees
                    .GetEmployeesWithAll(emp => emp.EmployeeID == id)
                    .FirstOrDefault();

                EditEmployee();
                BTNcancel.Visible = true;
                BTNcancel.Enabled = true;
                BTNaddEmployee.Text = "Editar";
            }
        }

        public void EditEmployee()
        {
            TBXemployeeName.Text = Employee.Name;
            TBXidentitficationCard.Text = Employee.IdentificationCard;

            DTPadmissionDate.Value = Employee.AdmissionDate;
            NUDcommissionPercentage.Value = Employee.CommissionPercentage;

            CBXroles.SelectedIndex = CBXroles
                .FindString(Employee.Users.FirstOrDefault().Role.Name);

            CBXworkShift.SelectedIndex = CBXworkShift.FindString(Employee.WorkShift.Description);
        }

        private void SaveEmployee()
        {
            try
            {
                if (_context.Complete() > 0)
                {
                    MessageBox.Show("Se ha " + Action + " el Empleado Correctamente");
                    LoadEmployeeData();
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }


        private void Reset()
        {
            TBXemployeeName.Text = null;
            TBXidentitficationCard.Text = null;
            DTPadmissionDate.Value = DateTime.Today;
            NUDcommissionPercentage.Value = 0;


            BTNaddEmployee.Text = "Agregar";
            BTNcancel.Visible = false;
            BTNcancel.Enabled = false;
            Employee = new Employee
            {
                Users = new List<User>()
            };
            LoadComboBoxes();
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            if (DTGVemployees.Rows.Count > 0 && DTGVemployees.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(DTGVemployees.CurrentRow.Cells["EmployeeID"].Value);
                var employee = _context.Employees.GetEmployeesWithAll(emp => emp.EmployeeID == id).FirstOrDefault();


                switch (MessageBox.Show("Esta seguro de que desea Eliminar el Empleado " + employee.Name, "Confirmar Eliminar", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        employee.State = false;
                        if (_context.Complete() > 0)
                        {
                            var result = MessageBox.Show("El Empleado ha sido eliminado correctamente");
                            if (result == DialogResult.OK)
                            {
                                LoadEmployeeData();
                                Reset();
                            }
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private string ValidateEmployeeName()
        {
            string empName = TBXemployeeName.Text;
            if (!string.IsNullOrEmpty(empName))
                return "";
            else
                return "El nombre del empleado no puede estar vacio";
        }

        private string ValidateEmployeeIdentificationCard()
        {
            string identiticationCard = TBXidentitficationCard.Text;
            string pattern = @"^\d{11}$|^\d{3}-\d{7}-\d{1}$";

            if (!string.IsNullOrEmpty(identiticationCard))
            {
                if (identiticationCard.Length == 11 || identiticationCard.Length == 13)
                {
                    if (Regex.IsMatch(identiticationCard, pattern))
                    {
                        if (IsValidIdentificationCard(identiticationCard))
                        {
                            if (_context.Employees.Count(emp => emp.IdentificationCard == identiticationCard && emp.State == true && emp.EmployeeID != Employee.EmployeeID) == 0){
                                return "";
                            }
                            else
                                return "ya existe un empleado con esa cedula";
                        }
                        else
                            return "La cedula no es valida";
                    }
                    else
                        return "La cedula no cumple con el formato valido";
                }
                else
                    return "La cedula debe tener 11 o 13 digitos si incluye - ";
            }
            else
                return "La cedula del Empleado no puede estar vacia";
        }

        private bool IsValidIdentificationCard(string identiticationCard)
        {
            var newIDC = identiticationCard.Replace("-", string.Empty).Trim();
            int verificatorDigit = Convert.ToInt32(newIDC.Substring(newIDC.Length - 1, 1));
            int IDClenght = newIDC.Length - 1;
            int[] weight = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int total = 0;
            int division = 0;
            int result = 0;

            for (int i = 0; i < IDClenght; i++)
            {
                int mult = Convert.ToInt32(newIDC.Substring(i, 1)) * weight[i];
                if (mult < 10)
                    total += mult;
                else
                    total += Convert.ToInt32(mult.ToString().Substring(0, 1)) + Convert.ToInt32(mult.ToString().Substring(1, 1));
            }

            division = total % 10;
            if (division != 0)
                result = 10 - division;
            else
                result = 0;

            if (result == verificatorDigit)
                return true;
            else
                return false;
        }

        private string ValidateCommissionPercentage()
        {
            var CommissionPercentage = NUDcommissionPercentage.Value;
            if (CommissionPercentage < 999999999)
            {
                return "";
            }
            else
                return "Ha excedido el limite de 999999999";
        }

        private string GetErrors()
        {
            string empName = ValidateEmployeeName();
            string IdentificationCard = ValidateEmployeeIdentificationCard();
            string comissionPorcentage = ValidateCommissionPercentage();


            if (string.IsNullOrWhiteSpace(empName))
            {
                if (string.IsNullOrWhiteSpace(IdentificationCard))
                {
                    if (string.IsNullOrWhiteSpace(comissionPorcentage))
                    {
                        return "";
                    }
                    else
                        return comissionPorcentage;
                }
                else
                    return IdentificationCard;
            }
            else
                return empName;
        }

        private void BTNaddEmployee_Click(object sender, EventArgs e)
        {
            string errors = GetErrors();

            if (string.IsNullOrEmpty(errors))
            {
                if (Employee.EmployeeID == 0)
                {
                    SetEmployee(Employee);
                    Employee.Users.Add(new User()
                    {
                        Password = Global.DefaultPassword,
                        RoleID = GetSourceId(CBXroles),
                        Username = Employee.IdentificationCard,
                    });
                    _context.Employees.Add(Employee);
                    Action = "Agregado";
                }
                else
                {
                    Employee empToEdit = _context.Employees
                        .GetEmployeesWithAll(emp => emp.EmployeeID == Employee.EmployeeID).FirstOrDefault();
                    User empUser = empToEdit.Users.FirstOrDefault();

                    SetEmployee(empToEdit);
                    empUser.RoleID = GetSourceId(CBXroles);
                    empUser.Username = empToEdit.IdentificationCard;
                    Action = "Editado";
                }
                SaveEmp();
            }
            else
                MessageBox.Show(errors);
        }


        private void SetEmployee(Employee employee)
        {
            employee.WorkShiftID = GetSourceId(CBXworkShift);

            employee.Name = TBXemployeeName.Text;
            employee.IdentificationCard = TBXidentitficationCard.Text;
            employee.CommissionPercentage = (int)NUDcommissionPercentage.Value;
            employee.State = true;
            employee.AdmissionDate = DateTime.Today.Date;
        }

        private int GetSourceId(ComboBox comboBox)
        {
            if (comboBox.DataSource != null)
                return ((KeyValuePair<int, string>)comboBox.SelectedItem).Key;
            else
                return 0;
        }

        private void BTNsearchEmployee_Click(object sender, EventArgs e)
        {
            string param = TBXsearchEmployee.Text.ToLower();
            int currentEmpId = (int)Global.Variables[Global.Id];

            if (!string.IsNullOrEmpty(param))
            {
                IEnumerable<Employee> Employees = _context.Employees
                    .GetEmployeesWithAll(emp => emp.State == true &&
                      emp.EmployeeID != currentEmpId &&
                     (emp.IdentificationCard.Contains(param) ||
                     emp.CommissionPercentage.ToString().Contains(param) ||
                     emp.WorkShift.Description.Contains(param) ||
                     emp.Name.Contains(param) ||
                     emp.Users.FirstOrDefault().Role.Name.Contains(param)));

                DTGVemployees.DataSource = GetEmployeeViewModels(Employees);
            }
        }
        private void SaveEmp()
        {
            try
            {
                if (_context.Complete() > 0)
                {
                    MessageBox.Show("Se ha " + Action + " el empleado Correctamente");
                    LoadEmployeeData();
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
        }
    }
}
