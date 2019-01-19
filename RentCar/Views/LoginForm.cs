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
            ChangeBTNStatus(BTNLogin, false);
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
                    ShowMessage("El usuario es incorrecto, verifique el correo o contraseña");
                    ChangeBTNStatus(BTNLogin, true);
                }
            }else{
                ShowMessage("Debe introudir valores al email y contraseña");
                ChangeBTNStatus(BTNLogin, true);
            }
        }

        private string EncriptPassWord(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            data = new SHA256Managed().ComputeHash(data);
            string hash = Convert.ToBase64String(data);

            return hash;
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void ChangeBTNStatus(Button btn,bool status)
        {
            btn.Enabled = status;
        }

        private void AddSessionVariables(User user)
        {
            Global.Variables.Add(Global.Id, user.Employee.EmployeeID.ToString());
            Global.Variables.Add(Global.Username, user.Employee.Name);
            Global.Variables.Add(Global.Roles, user.Roles.Select(r => r.Name).ToArray());
        }

        void MenuPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        void ResetForm()
        {
            TBXEmail.Text = null;
            TBXPassword.Text = null;
            ChangeBTNStatus(BTNLogin, true);
        }
    }
}
