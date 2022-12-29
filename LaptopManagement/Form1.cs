using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace LaptopManagement
{
    public partial class LaptopManagemet : Form
    {
        public List<Laptop> laptops = new List<Laptop>();
        public int loadData = 0;
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        string ExcelFilePath = ProjectPath + "\\LaptopDB.xlsx";
        string connetionString =
           @"Data Source=LAPTOP-2N2MT0S0\SQLEXPRESS;Initial Catalog=LatopDB; Integrated Security=SSPI";
        int CurrentLaoptIndex = -1;
        DataTable datatable;
        BindingSource binding = new BindingSource();
        public LaptopManagemet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Laptop bi = new Laptop();
            bi.LaptopID = "Not Assigned";
            bi.LaptopName = "Not Assigned";
            bi.LaptopType = "Not Assigned"; 
            bi.ProductDate = DateTime.ParseExact("01/01/1900", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            bi.Processor = "Not Assigned"; 
            bi.HDD = "Not Assigned"; 
            bi.RAM = "Not Assigned";
            bi.Price = 0;
            bi.IamageName = "laptop.jpg";
            DataRow newrow;
    
                newrow = datatable.NewRow();
                newrow["LaptopID"] = bi.LaptopID;
                newrow["LaptopName"] = bi.LaptopName;
                newrow["LaptopType"] = bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate;
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            MessageBox.Show("Finish Adding");
            
        }

        private void dgwLatoplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgwLatoplist_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (laptops.Count == 0 || datatable.Rows.Count == 0)
            {
                return;
            }
            CurrentLaoptIndex = dgwLatoplist.CurrentRow.Index;
            if (CurrentLaoptIndex >= 0 && CurrentLaoptIndex < laptops.Count)
            {
                picLaptopImage.Image = Image.FromFile(ProjectPath + "\\Data\\" + laptops[CurrentLaoptIndex].IamageName);
            }
        }

        private void picLaptopImage_Click(object sender, EventArgs e)
        {

        }
        private void btnLoadSQL_Click(object sender, EventArgs e)
        {
            loadData = 2;
            datatable = new DataTable();
            laptops.Clear();


            int NumDataRow = ReadDataFromSQLServer(laptops, connetionString);

            var sublist = laptops.Select(x => new
            {
                LaptopID = x.LaptopID,
                LaptopName = x.LaptopName,
                LaptopType = x.LaptopType,
                ProductDate = x.ProductDate.ToString("dd/MM/yyyy"),
                Processor = x.Processor,
                HDD = x.HDD,
                RAM = x.RAM,
                Price = x.Price.ToString() + "USD",

            }).ToList();

            datatable.Columns.Add("LaptopID");
            datatable.Columns.Add("LaptopName");
            datatable.Columns.Add("LaptopType");
            datatable.Columns.Add("ProductDate");
            datatable.Columns.Add("Processor");
            datatable.Columns.Add("HDD");
            datatable.Columns.Add("RAM");
            datatable.Columns.Add("Price");

            DataRow newrow;
            foreach (var bi in sublist)
            {
                newrow = datatable.NewRow();
                newrow["LaptopID"] = bi.LaptopID;
                newrow["LaptopName"] = bi.LaptopName;
                newrow["LaptopType"] = bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate;
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            }

            binding.AllowNew = true;
            binding.DataSource = datatable;
            dgwLatoplist.AutoGenerateColumns = false;
            dgwLatoplist.DataSource = binding;

        }
        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            loadData = 1;
            datatable = new DataTable();
            laptops.Clear();

            int colCount = 9;
            int NumDataRow = ReadDataFromFile(laptops, ExcelFilePath, colCount);

            var sublist = laptops.Select(x => new
            {
                LaptopID = x.LaptopID,
                LaptopName = x.LaptopName,
                LaptopType = x.LaptopType,
                ProductDate = x.ProductDate.ToString("dd/MM/yyyy"),
                Processor = x.Processor,
                HDD = x.HDD,
                RAM = x.RAM,
                Price = x.Price.ToString() + "USD",

            }).ToList();

            datatable.Columns.Add("LaptopID");
            datatable.Columns.Add("LaptopName");
            datatable.Columns.Add("LaptopType");
            datatable.Columns.Add("ProductDate");
            datatable.Columns.Add("Processor");
            datatable.Columns.Add("HDD");
            datatable.Columns.Add("RAM");
            datatable.Columns.Add("Price");

            DataRow newrow;
            foreach(var bi in sublist)
            {
                newrow = datatable.NewRow();
                newrow["LaptopID"] = bi.LaptopID;
                newrow["LaptopName"] = bi.LaptopName;
                newrow["LaptopType"] = bi.LaptopType;
                newrow["ProductDate"] = bi.ProductDate;
                newrow["Processor"] = bi.Processor;
                newrow["HDD"] = bi.HDD;
                newrow["RAM"] = bi.RAM;
                newrow["Price"] = bi.Price;
                datatable.Rows.Add(newrow);
                datatable.AcceptChanges();
            }

            binding.AllowNew = true;
            binding.DataSource = datatable;
            dgwLatoplist.AutoGenerateColumns = false;
            dgwLatoplist.DataSource = binding;

        }
        public int ReadDataFromFile(List<Laptop> DataList,string FilePath, int colCount)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(FilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;
            Excel.Range cell= xlWorksheet.UsedRange;

            xlWorksheet.Columns.ClearFormats();
            xlWorksheet.Rows.ClearFormats();

            int rowCount = xlWorksheet.UsedRange.Rows.Count;
            

            int numPhone = 0;
            string LaptopID = "";
            string LaptopName = "";
            string LaptopType = "";
            DateTime ProductDate = DateTime.Now;
            string Processor = "";
            string HDD = "";
            string RAM = "";
            int Price = 0;
            string iamgeName = "";


            for( int i=2; i<= rowCount; i++)
            {
                for(int j = 1;j <= colCount; j++)
                {
                    
                    switch (j)
                    {

                        case 1:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            LaptopID = cell.Value2.ToString();
                            break;
                        case 2:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            LaptopName = cell.Value2.ToString();
                            break;
                        case 3:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            LaptopType = cell.Value2.ToString();
                            break;
                        case 4:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            ProductDate = DateTime.ParseExact(cell.Value2.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            break;
                        case 5:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            Processor = cell.Value2.ToString();
                            break;
                        case 6:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            HDD = cell.Value2.ToString();
                            break;
                        case 7:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            RAM = cell.Value2.ToString();
                            break;
                        case 8:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            Price = Convert.ToInt32(cell.Value2.ToString());
                            break;
                        case 9:
                            cell = xlWorksheet.UsedRange.Cells[i, j];
                            iamgeName = cell.Value2.ToString();
                            break;
                    }
                }
                DataList.Add(new Laptop());
                DataList[numPhone].LaptopID = LaptopID;
                DataList[numPhone].LaptopName = LaptopName;
                DataList[numPhone].LaptopType = LaptopType;
                DataList[numPhone].ProductDate = ProductDate;
                DataList[numPhone].Processor = Processor;
                DataList[numPhone].HDD = HDD;
                DataList[numPhone].RAM = RAM;
                DataList[numPhone].Price = Price;
                DataList[numPhone].IamageName = iamgeName;
                numPhone = numPhone + 1;


            }
            xlApp.Quit();
            MessageBox.Show("Load Data From Excel Finished! : " + (rowCount-1).ToString()+"Records") ;

            return (rowCount-1);
        }

        public int ReadDataFromSQLServer(List<Laptop>DataList,string connetionString)
        {
            SqlConnection cnn = new SqlConnection(connetionString);
            int iRow = 0;
            int NumRecords = 0;
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open!");
                string SqlString = @"SELECT
                                    LaptopID,
                                    LaptopName,
                                    LaptopType,
                                    ProductDate=Convert(varchar(10),CONVERT(date,ProductDate,105),103),
                                    Processor,
                                    HDD,
                                    RAM,
                                    Price,
                                    ImageName 
                                    FROM dbo.Laptop";
                using (var command = new SqlCommand(SqlString, cnn))
                {
                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read())
                        {
                            laptops.Add(new Laptop());
                            laptops[iRow].LaptopID = reader.GetString(0);
                            laptops[iRow].LaptopName = reader.GetString(1);
                            laptops[iRow].LaptopType = reader.GetString(2);
                            laptops[iRow].ProductDate = DateTime.ParseExact(reader.GetString(3), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            laptops[iRow].Processor = reader.GetString(4);
                            laptops[iRow].HDD = reader.GetString(5);
                            laptops[iRow].RAM = reader.GetString(6);
                            laptops[iRow].Price = reader.GetInt32(7);
                            laptops[iRow].IamageName = reader.GetString(8);
                            iRow = iRow + 1;
                        }
                    }
                }
                SqlCommand cmd = new SqlCommand("select * from Laptop", cnn);
                object result = cmd.ExecuteScalar();
                NumRecords = int.Parse(result.ToString());
                MessageBox.Show("Finish Load Data From SQL:" + NumRecords.ToString() + "Records");
                cnn.Close();

            }
            catch
                {
                MessageBox.Show("Can not open connection!:");

            }

            return NumRecords;
        }

        private void dgwLatoplist_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(ColumnPrice_KeyPress);
            if (dgwLatoplist.CurrentCell.ColumnIndex == 8)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnPrice_KeyPress);
                }
            }
        }
        private void ColumnPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Laptop lp;
            if (CurrentLaoptIndex >= 0)
            {
                lp = laptops[CurrentLaoptIndex];
            }
            else
                return;
            string question = "Do You Wan to delete Laptop:" + lp.LaptopID;
            DialogResult result = MessageBox.Show(question, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                laptops.RemoveAt(CurrentLaoptIndex);
                binding.RemoveAt(CurrentLaoptIndex);
            }
            MessageBox.Show("Finish Delete");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow row;
            for(int i =0; i < datatable.Rows.Count; i++)
            {
                row = datatable.Rows[1];
                laptops[i].LaptopID = row["LaptopID"].ToString();
                laptops[i].LaptopName = row["LaptopName"].ToString();
                laptops[i].ProductDate = DateTime.ParseExact(row["ProductDate"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                laptops[i].Processor = row["Processor"].ToString();
                laptops[i].HDD = row["HDD"].ToString();
                laptops[i].RAM = row["RAM"].ToString();
                string lPrice = row["Price"].ToString();
                laptops[i].Price = Convert.ToInt32(lPrice.Substring(0, lPrice.IndexOf(" ")));

            }
            MessageBox.Show("Finish Update");
        }

        private void btnUpdateSource_Click(object sender, EventArgs e)
        {
            if (loadData == 1)
            {
                WriteDataToExcelFile(laptops, ExcelFilePath);
            }
            else
            {
                WriteDataToSQLServer(laptops, connetionString);
            }
        }
        public void WriteDataToExcelFile(List<Laptop> laptops,string ExcelFilePath)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath);
            Excel._Worksheet worksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange;

            string[,] Data = new string[1, 10];

            int idxRow = 2;
            foreach(Laptop lp in laptops)
            {
                Data[0, 0] = lp.LaptopID;
                Data[0, 1] = lp.LaptopName;
                Data[0, 2] = lp.LaptopType;
                Data[0, 3] = lp.ProductDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                Data[0, 4] = lp.Processor;
                Data[0, 5] = lp.HDD;
                Data[0, 6] = lp.RAM;
                Data[0, 7] = lp.Price.ToString();
                Data[0, 8] = lp.IamageName;
                xlRange = worksheet.get_Range("A" + idxRow.ToString(), "j" + idxRow.ToString());
                xlRange.Value2 = Data;

                idxRow = idxRow + 1;

            }
            xlWorkbook.Save();
            xlWorkbook.Close();
            xlApp.Quit();
            MessageBox.Show("Finish Update to DataSource Excel");
        }

        public void WriteDataToSQLServer(List<Laptop>laptops,string connetionString)
        {
            SqlConnection cnn;
            SqlCommand myCommand = new SqlCommand();
            string query;
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open!");
                query = "TRUNCATE TABLE Laptop";
                myCommand.CommandText = query;
                myCommand.Connection = cnn;
                myCommand.ExecuteNonQuery();
                query = @"INSERT INTO Laptop(LaptopID,LaptopName,LaptopType ,ProductDate,Processor,HDD,RAM,Price,ImageName)";
                query += @"VALUES(@Laptop, @LaptopID, @LaptopName,@LaptopType , @ProductDate, @Processor, @HDD, @RAM, @Price, @ImageName)";
                myCommand.CommandText = query;
                myCommand.Connection = cnn;

                myCommand.Parameters.Add(new SqlParameter("@LaptopID", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@LaptopName", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@LaptopType", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@ProductDate", SqlDbType.DateTime));
                myCommand.Parameters.Add(new SqlParameter("@Processor", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@HDD", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@RAM", SqlDbType.NVarChar));
                myCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int));
                myCommand.Parameters.Add(new SqlParameter("@ImageName", SqlDbType.NVarChar));


                foreach(Laptop lp in laptops)
                {
                    myCommand.Parameters[0].Value = lp.LaptopID;
                    myCommand.Parameters[1].Value = lp.LaptopName;
                    myCommand.Parameters[2].Value =lp.LaptopType;
                    myCommand.Parameters[3].Value = lp.ProductDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture); ;
                    myCommand.Parameters[4].Value =lp.Processor;
                    myCommand.Parameters[5].Value =lp.HDD;
                    myCommand.Parameters[6].Value =lp.RAM;
                    myCommand.Parameters[7].Value =lp.Price;
                    myCommand.Parameters[8].Value =lp.IamageName;

                    myCommand.ExecuteNonQuery();
                }
                cnn.Close();
            }
            catch
            {
                MessageBox.Show("Can not open connection!");
            }
            MessageBox.Show("Finish Upate to DataSource SQL Server");
        }
    }

}
