
namespace LaptopManagement
{
    partial class LaptopManagemet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaptopManagemet));
            this.dgwLatoplist = new System.Windows.Forms.DataGridView();
            this.LaptopID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaptopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaptopType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLaptopImage = new System.Windows.Forms.PictureBox();
            this.btnLoadExcel = new System.Windows.Forms.Button();
            this.btnLoadSQL = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateSource = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLatoplist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaptopImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLatoplist
            // 
            this.dgwLatoplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLatoplist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaptopID,
            this.LaptopName,
            this.LaptopType,
            this.ProductDate,
            this.Processor,
            this.HDD,
            this.RAM,
            this.Price});
            this.dgwLatoplist.Location = new System.Drawing.Point(40, 87);
            this.dgwLatoplist.MultiSelect = false;
            this.dgwLatoplist.Name = "dgwLatoplist";
            this.dgwLatoplist.RowHeadersWidth = 51;
            this.dgwLatoplist.RowTemplate.Height = 29;
            this.dgwLatoplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwLatoplist.Size = new System.Drawing.Size(844, 283);
            this.dgwLatoplist.TabIndex = 0;
            this.dgwLatoplist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLatoplist_CellContentClick);
            // 
            // LaptopID
            // 
            this.LaptopID.DataPropertyName = "LaptopID";
            this.LaptopID.HeaderText = "LaptopID";
            this.LaptopID.MinimumWidth = 6;
            this.LaptopID.Name = "LaptopID";
            this.LaptopID.Width = 125;
            // 
            // LaptopName
            // 
            this.LaptopName.DataPropertyName = "LaptopName";
            this.LaptopName.HeaderText = "LaptopName";
            this.LaptopName.MinimumWidth = 6;
            this.LaptopName.Name = "LaptopName";
            this.LaptopName.Width = 125;
            // 
            // LaptopType
            // 
            this.LaptopType.DataPropertyName = "LaptopType";
            this.LaptopType.HeaderText = "LaptopType";
            this.LaptopType.MinimumWidth = 6;
            this.LaptopType.Name = "LaptopType";
            this.LaptopType.Width = 125;
            // 
            // ProductDate
            // 
            this.ProductDate.DataPropertyName = "ProductDate";
            this.ProductDate.HeaderText = "ProductDate";
            this.ProductDate.MinimumWidth = 6;
            this.ProductDate.Name = "ProductDate";
            this.ProductDate.Width = 125;
            // 
            // Processor
            // 
            this.Processor.DataPropertyName = "Processor";
            this.Processor.HeaderText = "Processor";
            this.Processor.MinimumWidth = 6;
            this.Processor.Name = "Processor";
            this.Processor.Width = 125;
            // 
            // HDD
            // 
            this.HDD.DataPropertyName = "HDD";
            this.HDD.HeaderText = "HDD";
            this.HDD.MinimumWidth = 6;
            this.HDD.Name = "HDD";
            this.HDD.Width = 125;
            // 
            // RAM
            // 
            this.RAM.DataPropertyName = "RAM";
            this.RAM.HeaderText = "RAM";
            this.RAM.MinimumWidth = 6;
            this.RAM.Name = "RAM";
            this.RAM.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // picLaptopImage
            // 
            this.picLaptopImage.Image = ((System.Drawing.Image)(resources.GetObject("picLaptopImage.Image")));
            this.picLaptopImage.Location = new System.Drawing.Point(935, 87);
            this.picLaptopImage.Name = "picLaptopImage";
            this.picLaptopImage.Size = new System.Drawing.Size(236, 236);
            this.picLaptopImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLaptopImage.TabIndex = 1;
            this.picLaptopImage.TabStop = false;
            this.picLaptopImage.Click += new System.EventHandler(this.picLaptopImage_Click);
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.AutoSize = true;
            this.btnLoadExcel.Location = new System.Drawing.Point(66, 51);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(164, 30);
            this.btnLoadExcel.TabIndex = 2;
            this.btnLoadExcel.Text = "Load Data From Excel";
            this.btnLoadExcel.UseVisualStyleBackColor = true;
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // btnLoadSQL
            // 
            this.btnLoadSQL.AutoSize = true;
            this.btnLoadSQL.Location = new System.Drawing.Point(333, 51);
            this.btnLoadSQL.Name = "btnLoadSQL";
            this.btnLoadSQL.Size = new System.Drawing.Size(156, 30);
            this.btnLoadSQL.TabIndex = 3;
            this.btnLoadSQL.Text = "Load Data From SQL";
            this.btnLoadSQL.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(40, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(230, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(421, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSource
            // 
            this.btnUpdateSource.AutoSize = true;
            this.btnUpdateSource.Location = new System.Drawing.Point(711, 404);
            this.btnUpdateSource.Name = "btnUpdateSource";
            this.btnUpdateSource.Size = new System.Drawing.Size(173, 30);
            this.btnUpdateSource.TabIndex = 7;
            this.btnUpdateSource.Text = "Update To Data Source";
            this.btnUpdateSource.UseVisualStyleBackColor = true;
            // 
            // LaptopManagemet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 480);
            this.Controls.Add(this.btnUpdateSource);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadSQL);
            this.Controls.Add(this.btnLoadExcel);
            this.Controls.Add(this.picLaptopImage);
            this.Controls.Add(this.dgwLatoplist);
            this.Name = "LaptopManagemet";
            this.Text = "Laptop Managemet";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLatoplist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLaptopImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLatoplist;
        private System.Windows.Forms.PictureBox picLaptopImage;
        private System.Windows.Forms.Button btnLoadExcel;
        private System.Windows.Forms.Button btnLoadSQL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaptopID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaptopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaptopType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}

