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
        string ExcelFilePath = ProjectPath + "\\Data\\LaptopList.xlsx";
        string connetionString =
            "Data Source=LAPTOP-2N2MT0S0;Initial Catalog = LatopDB; Integrated Security=SSPI";
        int CurrentLaoptIndex = -1;
        DataTable datatable;
        BindingSource binding = new BindingSource();
        public LaptopManagemet()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dgwLatoplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picLaptopImage_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            
        }
        public int ReadDataFromFile(List<Laptop> DataList,string FilePath, int colCount)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(FilePath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

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
                for(int j=1;j<colCount; j++)
                {
                    switch (j)
                    {
                        case 1:
                            LaptopID = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 2:
                            LaptopName = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 3:
                            LaptopType =  xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 4:
                            ProductDate = DateTime.ParseExact(xlRange.Cells[i, j].Value2.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            break;
                        case 5:
                            Processor = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 6:
                            HDD = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 7:
                            RAM = xlRange.Cells[i, j].Value2.ToString();
                            break;
                        case 8:
                            Price = Convert.ToInt32(xlRange.Cells[i, j].Value2.ToString());
                            break;
                        case 9:
                            iamgeName = xlRange.Cells[i, j].Value2.ToString();
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

            }
            xlApp.Quit();
            MessageBox.Show("Load Data From Excel Finished! : " + (rowCount-1).ToString()+"Records") ;

            return (rowCount-1);
        }
    }
}
