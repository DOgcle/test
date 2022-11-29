using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace WinFormsApp1
{
    public partial class Registration : Form
    {
        string StartupPath;
         Login ParentForm;
        public Registration()
        {
            InitializeComponent();
            StartupPath = Login.originalForm.StartupPath;
            ParentForm = Login.originalForm;
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Find Avatar Image";
            dlg.Filter = "JPG filter|*.jpg";
            dlg.InitialDirectory = StartupPath;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string AvatarPath = dlg.FileName;
                picAvatar.Image = Image.FromFile(AvatarPath);
                StartupPath = Path.GetDirectoryName(AvatarPath);
                picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Registration));
            picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
            ParentForm.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            User u = new User();
            Customer c = new Customer();
            if (txtUserID.Text.Trim().Length == 0 || txtPassWord.Text.Trim().Length == 0|| txtCustomerID.Text.Trim().Length == 0)
            {
                MessageBox.Show("CustomerID, UserID, Password are not blank", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            if (txtPassWord.Text != txtPassWordConfirm.Text)
            {
                MessageBox.Show(" Password and Comfirm Password are not matched", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            User SpecificOne = ParentForm.users.Find(x => (x.userName == txtUserID.Text) && (x.password == txtPassWord.Text));
            if (SpecificOne != null)
            {
                MessageBox.Show("UserID is existed", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            u.userName = txtUserID.Text;
            u.password = txtPassWord.Text;
            u.CustomerID = txtCustomerID.Text;

            c.CustomerID = txtCustomerID.Text;
            c.CustomerName = txtCustomerName.Text;
            c.Nationality = txtNationality.Text;
            c.PastportNBR = txtPassPortNBR.Text;
            c.Birthday = dtpBirthday.Value;
            c.Gender = (rdMale.Checked = true) ? Sex.Male : Sex.Female;
            ParentForm.users.Add(u);
            ParentForm.customers.Add(c);
            MessageBox.Show("New User ID Number is Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            dtpBirthday.Value = DateTime.Now;
            rdMale.Checked = true;
            rdFemale.Checked = false;
            txtPassWord.Text = "";
            txtPassWordConfirm.Text = "";
            txtUserID.Text = "";
            txtNationality.Text = "";
            txtPassPortNBR.Text = "";

            ComponentResourceManager resources = new ComponentResourceManager(typeof(Registration));
            picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
