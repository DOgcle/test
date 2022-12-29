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
using Excell = Microsoft.Office.Interop.Excel;

namespace LaptopManagement
{
    public class Laptop
    {
        public string LaptopID { get; set; }
        public string LaptopName { get; set; }
        public string LaptopType { get; set; }
        public DateTime ProductDate { get; set; }
        public string Processor { get; set; }
        public string HDD { get; set; }
        public string RAM { get; set; }
        public int Price { get; set; }
        public string IamageName { get; set; }

        public Laptop()
        {
            LaptopID = "Not Asigned";
            LaptopName = "Not Asigned";
        }
    }
    
}
