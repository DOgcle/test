using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public static Login originalForm;
        public List<Customer> customers;
        public List<User> users;
        public List<Flight> flightList;
        public List<FlightBooking> flightBookings;
        public string StartupPath;
        public bool ResetLogin;
        public Login()
        {
            InitializeComponent();
            originalForm = this;
            StartupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            customers = new List<Customer>();

            customers.Add(new Customer("001", "Bob", Image.FromFile(StartupPath + "\\Nobita.jpg"), Sex.Male, "123", "24/12/2002", "123456789", " "));
            users = new List<User>();
            users.Add(new User("Admin", "123", "001", "Bob"));

            flightList = new List<Flight>();
            flightList.Add(new Flight("0001", "A", "25/12/2022", "26/12/2022", 5));
            flightList.Add(new Flight("0002", "B", "25/12/2022", "26/12/2022", 5));
            flightList.Add(new Flight("0003", "C", "25/12/2022", "26/12/2022", 5));

            flightBookings = new List<FlightBooking>();
            ResetLogin = true;
        }
        private void linkLbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration obj = new Registration();
            this.Hide();
            obj.Show();


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtAccount.Text.Length == 0)
            {
                MessageBox.Show("Please enter UserName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccount.Focus();
                return;
            }
            if (this.txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Please enter PassWord", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return;
            }
            User SpecificOne = users.Find(x => (x.userName == txtAccount.Text) && (x.password == txtPassword.Text));
            if(SpecificOne== null)
            {
                MessageBox.Show("Account and PassWord are not matched.\n Please input again or Register new Account", "Account is Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccount.Text = "";
                txtPassword.Text = "";
                txtAccount.Focus();
            }
            else
            {
                AirTicketBooking ari = new AirTicketBooking();
                this.Hide();
                ari.Show();
            }
        }
     

       
    }
}
