
namespace WinFormsApp1
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtPassWordConfirm = new System.Windows.Forms.TextBox();
            this.txtPassPortNBR = new System.Windows.Forms.TextBox();
            this.txtNationality = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(153, 113);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(183, 27);
            this.dtpBirthday.TabIndex = 2;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(153, 165);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(63, 24);
            this.rdMale.TabIndex = 3;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(258, 165);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(78, 24);
            this.rdFemale.TabIndex = 4;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(433, 43);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(320, 227);
            this.picAvatar.TabIndex = 8;
            this.picAvatar.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(463, 287);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(662, 287);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(153, 378);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(285, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(433, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(153, 195);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(183, 27);
            this.txtUserID.TabIndex = 14;
            this.txtUserID.Text = "UserID";

            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(170, 43);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(125, 27);
            this.txtCustomerID.TabIndex = 15;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(170, 76);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(125, 27);
            this.txtCustomerName.TabIndex = 16;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(153, 301);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(183, 27);
            this.txtPassWord.TabIndex = 17;
            // 
            // txtPassWordConfirm
            // 
            this.txtPassWordConfirm.Location = new System.Drawing.Point(153, 345);
            this.txtPassWordConfirm.Name = "txtPassWordConfirm";
            this.txtPassWordConfirm.Size = new System.Drawing.Size(183, 27);
            this.txtPassWordConfirm.TabIndex = 18;
            // 
            // txtPassPortNBR
            // 
            this.txtPassPortNBR.Location = new System.Drawing.Point(153, 228);
            this.txtPassPortNBR.Name = "txtPassPortNBR";
            this.txtPassPortNBR.PlaceholderText = "PassPortNBR";
            this.txtPassPortNBR.Size = new System.Drawing.Size(183, 27);
            this.txtPassPortNBR.TabIndex = 19;
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(153, 261);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(176, 27);
            this.txtNationality.TabIndex = 20;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtPassPortNBR);
            this.Controls.Add(this.txtPassWordConfirm);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.dtpBirthday);
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtPassWordConfirm;
        private System.Windows.Forms.TextBox txtPassPortNBR;
        private System.Windows.Forms.TextBox txtNationality;
    }
}