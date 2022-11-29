
namespace WinFormsApp1
{
    partial class AirTicketBooking
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
            this.lsbAriTicket = new System.Windows.Forms.ListBox();
            this.rtxtRegistration = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbAriTicket
            // 
            this.lsbAriTicket.FormattingEnabled = true;
            this.lsbAriTicket.ItemHeight = 20;
            this.lsbAriTicket.Location = new System.Drawing.Point(33, 65);
            this.lsbAriTicket.Name = "lsbAriTicket";
            this.lsbAriTicket.Size = new System.Drawing.Size(150, 244);
            this.lsbAriTicket.TabIndex = 0;
            // 
            // rtxtRegistration
            // 
            this.rtxtRegistration.Location = new System.Drawing.Point(258, 65);
            this.rtxtRegistration.Name = "rtxtRegistration";
            this.rtxtRegistration.Size = new System.Drawing.Size(417, 244);
            this.rtxtRegistration.TabIndex = 1;
            this.rtxtRegistration.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(336, 333);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(529, 333);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 29);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // AirTicketBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtxtRegistration);
            this.Controls.Add(this.lsbAriTicket);
            this.Name = "AirTicketBooking";
            this.Text = "AirTicketBooking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbAriTicket;
        private System.Windows.Forms.RichTextBox rtxtRegistration;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnLogOut;
    }
}