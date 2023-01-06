
namespace Coffee
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgwCoffee = new System.Windows.Forms.DataGridView();
            this.cofffeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outOfDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceCoffee = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCoffee
            // 
            this.dgwCoffee.AutoGenerateColumns = false;
            this.dgwCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCoffee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cofffeeIDDataGridViewTextBoxColumn,
            this.coffeeNameDataGridViewTextBoxColumn,
            this.productDateDataGridViewTextBoxColumn,
            this.outOfDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgwCoffee.DataSource = this.bindingSourceCoffee;
            this.dgwCoffee.Location = new System.Drawing.Point(12, 77);
            this.dgwCoffee.Name = "dgwCoffee";
            this.dgwCoffee.RowHeadersWidth = 51;
            this.dgwCoffee.RowTemplate.Height = 24;
            this.dgwCoffee.Size = new System.Drawing.Size(692, 280);
            this.dgwCoffee.TabIndex = 0;
            // 
            // cofffeeIDDataGridViewTextBoxColumn
            // 
            this.cofffeeIDDataGridViewTextBoxColumn.DataPropertyName = "CofffeeID";
            this.cofffeeIDDataGridViewTextBoxColumn.HeaderText = "CofffeeID";
            this.cofffeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cofffeeIDDataGridViewTextBoxColumn.Name = "cofffeeIDDataGridViewTextBoxColumn";
            this.cofffeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            this.coffeeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDateDataGridViewTextBoxColumn
            // 
            this.productDateDataGridViewTextBoxColumn.DataPropertyName = "ProductDate";
            this.productDateDataGridViewTextBoxColumn.HeaderText = "ProductDate";
            this.productDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDateDataGridViewTextBoxColumn.Name = "productDateDataGridViewTextBoxColumn";
            this.productDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // outOfDateDataGridViewTextBoxColumn
            // 
            this.outOfDateDataGridViewTextBoxColumn.DataPropertyName = "OutOfDate";
            this.outOfDateDataGridViewTextBoxColumn.HeaderText = "OutOfDate";
            this.outOfDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.outOfDateDataGridViewTextBoxColumn.Name = "outOfDateDataGridViewTextBoxColumn";
            this.outOfDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceCoffee
            // 
            this.bindingSourceCoffee.DataSource = typeof(Coffee.Coffee_);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(81, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(292, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(553, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgwCoffee);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoffee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCoffee;
        private System.Windows.Forms.BindingSource bindingSourceCoffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cofffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outOfDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}

