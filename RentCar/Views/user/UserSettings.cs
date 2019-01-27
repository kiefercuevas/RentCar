using RentCar.Data;
using RentCar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Views.user
{
    public partial class UserSettings : Form
    {
        private Employee Employee { get; set; }
        private readonly RentCarUnitOfWork _context;
        public UserSettings(int id)
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
            Employee = _context.Employees.GetEmployeesWithAll(u => u.EmployeeID == id)
                .FirstOrDefault();
        }

        private void BTNchangePassword_Click(object sender, EventArgs e)
        {
            string currentPass = TBXcurrentPassword.Text;
            string newPass = TBXnewPassword.Text;
            string confirmNewPass = TBXconfirmNewPassword.Text;

            if (!IsNull(currentPass) && !IsNull(newPass) && !IsNull(confirmNewPass))
            {
                if (EncriptPassWord(TBXcurrentPassword.Text) == Employee.Users.FirstOrDefault().Password)
                {
                    if (newPass == confirmNewPass)
                    {
                        string hash = EncriptPassWord(newPass);
                        var user = Employee.Users.FirstOrDefault();
                        user.Password = hash;

                        if (_context.Complete() > 0)
                        {
                            var result = MessageBox.Show("La contraseña ha sido actualizada correctamente");
                            if (result == DialogResult.OK)
                            {
                                DialogResult = DialogResult.OK;
                                Close();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Las contraseñas no coinciden");
                }
                else
                    MessageBox.Show("La contraseña es incorrecta");
            }
            else
                MessageBox.Show("Debe de llenar todos los campos");


            
        }


        private string EncriptPassWord(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            data = new SHA256Managed().ComputeHash(data);
            string hash = Convert.ToBase64String(data);
            return hash;
        }

        private bool IsNull(string data)
        {
            return string.IsNullOrEmpty(data);
        }
    }
}
