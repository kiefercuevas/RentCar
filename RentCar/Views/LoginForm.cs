using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using RentCar.Data;
using RentCar.Models;
using System.Linq;
namespace RentCar.Views
{
    public partial class LoginForm : Form
    {
        private readonly RentCarUnitOfWork _context;
        public LoginForm()
        {
            InitializeComponent();
            _context = new RentCarUnitOfWork();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            BTNLogin.Enabled = false;
            string Email = TBXEmail.Text;
            string password = TBXPassword.Text;

            if(!string.IsNullOrWhiteSpace(TBXEmail.Text) &&
               !string.IsNullOrWhiteSpace(TBXPassword.Text)){

                string EncriptedPassword = EncriptPassWord(password);

                User user = _context.User
                    .GetUserWithEmployeeAndRoles(u => u.Password == EncriptedPassword && u.Email == Email);

                if(user != null){
                    AddSessionVariables(user);

                    Form menuPage = new MenuPage();
                    menuPage.FormClosed += new FormClosedEventHandler(MenuPage_FormClosed);
                    menuPage.Show();

                    ResetForm();
                    Hide();
                }
                else{
                   MessageBox.Show("El usuario es incorrecto, verifique el correo o contraseña");
                   TBXPassword.Text = null;
                   BTNLogin.Enabled = true;
                }
            }else{
                MessageBox.Show("Debe introudir valores al email y contraseña");
                ResetForm();
            }
        }

        private string EncriptPassWord(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            data = new SHA256Managed().ComputeHash(data);
            string hash = Convert.ToBase64String(data);
            return hash;
        }

        private void AddSessionVariables(User user)
        {
            Global.Variables.Add(Global.Id, user.Employee.EmployeeID);
            Global.Variables.Add(Global.Username, user.Employee.Name);
            Global.Variables.Add(Global.Roles, user.Roles.Select(r => r.Name).ToList());
        }

        void MenuPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        void ResetForm()
        {
            TBXEmail.Text = null;
            TBXPassword.Text = null;
            BTNLogin.Enabled = true;
        }

    }
}
