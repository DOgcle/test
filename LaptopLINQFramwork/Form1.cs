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

namespace LaptopLINQFramwork
{
    public partial class Form1 : Form
    {
        static string ProjectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        DataClasses1DataContext db = new DataClasses1DataContext();
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picLaptop.Image = Image.FromFile(ProjectPath + "\\Data\\laptop_Asus.jpg");
            picLaptop.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void displayData()
        {
            dgwLaptop.DataSource = (from sp in db.Sheet1_s select sp);
            dgwLaptop.Columns["ImageName"].Visible = false;
            dgwLaptop.Columns["LaptopID"].ReadOnly = true;
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void dgwLaptop_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgwLaptop.Focused == false || dgwLaptop.CurrentCell == null)
                return;
            int RowIndex = dgwLaptop.CurrentRow.Index;
            
            string SelectedLaptopID = dgwLaptop.Rows[RowIndex].Cells[0].Value.ToString();
            string LaptopImage = (from sp in db.Sheet1_s
                                  where sp.LaptopID == SelectedLaptopID
                                  select sp.ImageName).FirstOrDefault();

            if (LaptopImage == null)
                return;

            picLaptop.Image = Image.FromFile(ProjectPath + "\\Data\\" + LaptopImage);
            picLaptop.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void picLaptop_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int RowIndex = dgwLaptop.CurrentRow.Index;
            string SelectedLaptopID = dgwLaptop.Rows[RowIndex].Cells[0].Value.ToString();

            Sheet1_ deleteSP = (from sp in db.Sheet1_s
                                           where sp.LaptopID == SelectedLaptopID
                                           select sp).SingleOrDefault();
            db.Sheet1_s.DeleteOnSubmit(deleteSP);
            db.SubmitChanges();
            displayData();
            MessageBox.Show("Laptop: " + deleteSP.LaptopID + " is deleted");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int RowIndex = dgwLaptop.CurrentRow.Index;
            string SelectedLaptopID = dgwLaptop.Rows[RowIndex].Cells[0].Value.ToString();

            Sheet1_ updateSP = (from sp in db.Sheet1_s
                                where sp.LaptopID == SelectedLaptopID
                                select sp).SingleOrDefault();
            updateSP.LaptopID = dgwLaptop.Rows[RowIndex].Cells[0].Value.ToString();
            updateSP.LaptopName = dgwLaptop.Rows[RowIndex].Cells[1].Value.ToString();
            updateSP.LaptopType = dgwLaptop.Rows[RowIndex].Cells[2].Value.ToString();
            updateSP.ProductDate = DateTime.Parse(dgwLaptop.Rows[RowIndex].Cells[3].Value.ToString());
            updateSP.Processor = dgwLaptop.Rows[RowIndex].Cells[4].Value.ToString(); 
            updateSP.HDD = dgwLaptop.Rows[RowIndex].Cells[5].Value.ToString(); ;
            updateSP.RAM = dgwLaptop.Rows[RowIndex].Cells[6].Value.ToString();
            updateSP.Price = Convert.ToInt32(dgwLaptop.Rows[RowIndex].Cells[7].Value.ToString());
            updateSP.ImageName = "laptop.jpg";

            db.SubmitChanges();
            displayData();
            MessageBox.Show("Laptop: " + updateSP.LaptopName + " is updated");

        }
        public string NextId(string currentID)
        {
            int i = 0;
            if(int.TryParse(currentID, out i))
            {
                i++;
                return (i.ToString().PadLeft(3, '0'));
            }
            throw new System.ArgumentException("Non-numeric string passed as argumnet");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Sheet1_ checkSP;
            List<Sheet1_> SPList = (from sp in db.Sheet1_s
                                    where sp.LaptopID.Contains("NEW")
                                    select sp).ToList();
            string NewID = "NEW";
            if (SPList.Count == 0)
                NewID = NewID + "001";
            else
            {
                checkSP = SPList.Last();
                NewID = NewID + NextId(checkSP.LaptopID.Substring(checkSP.LaptopID.Length - 3));
            }
            Sheet1_ insertedSP = new Sheet1_();
            insertedSP.LaptopID = NewID;
            insertedSP.LaptopName = "Not Assiged";
            insertedSP.LaptopType = "Not Assiged";
            insertedSP.ProductDate = DateTime.Now;
            insertedSP.Processor = "Not Assiged";
            insertedSP.HDD = "Not Assiged";
            insertedSP.RAM = "Not Assiged";
            insertedSP.Price = 0;
            insertedSP.ImageName = "laptop.jpg";

            db.Sheet1_s.InsertOnSubmit(insertedSP);
            db.SubmitChanges();
            displayData();
            MessageBox.Show("Laptop: " + insertedSP.LaptopID + " is inserted");
        }
    }
}
