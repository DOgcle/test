using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;
using System.IO;
using Milkado;
using AttributeData;
using System.Diagnostics;

 public delegate void FillandShow();

namespace AttributeData


{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]

    public class MilkMoreInfo : System.Attribute
    {
        public String Manufacturer { get; set; }
        public String CompanyName { get; set; }

        public MilkMoreInfo(string Manufacturer = " ", string CompanyName = " ")
        {
            this.Manufacturer = Manufacturer;
            this.CompanyName = CompanyName;
        }
    }
}

namespace Milkado
{
    

    interface MilkAction
    {

        void InputInfo();
        void DisplayInfo();
        
    }

    [MilkMoreInfo("THTrueMilk", "VinaMilk")]

    class Milk : MilkAction
    {
        private string MILKID = "MILK01032016";
        private string MilkName;
        private string Quantity;
        private DateTime ProductionDate;
        private DateTime ExpiredDate;
        private float Price;

        public Milk(string MilkName = "Not Assigned", string Quantity = "Not Assigned",
                    string ProductionDate = "01/03/2016", string ExpiredDate = "01/03/2016", float Price = 0)
        {
            this.MilkName = MilkName;
            this.Quantity = Quantity;
            this.ProductionDate = DateTime.ParseExact(ProductionDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.ExpiredDate = DateTime.ParseExact(ExpiredDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.Price = Price;
            this.MILKID = String.Format("MILK{0}", this.ProductionDate.ToString("ddMyyyy"));
        }
    
        public void InputInfo()
        {
            Console.Write("Name of Milk: "); ValMilkName = Console.ReadLine();
            Console.Write("How many bottles we have in this Product?: "); ValQuantity = Console.ReadLine();
            Console.Write("How does the cost of one Bottle?: "); ValPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("When is this Product Launched ?: "); ValProductionDate = Console.ReadLine();
            Console.Write("When will this product expire ?: "); ValExpiredDate = Console.ReadLine();
        }
        public void DisplayInfo()
        {
            Console.WriteLine("\t MILKID = {0}", ValMilkID);
            Console.WriteLine("\t Name = {0}, Quantity = {1}", ValMilkName, ValQuantity);
            Console.WriteLine("\t Production Date = {0}, Expired Date = {1}", ValProductionDate, ValExpiredDate);
            Console.WriteLine("\t Price = {0} VND/1 bottle", ValPrice);
        }


        public static void Info()
        {
            var m = new Milk();
            Console.Write("Name of Milk: "); m.ValMilkName = Console.ReadLine();
            Console.Write("How many bottles we have in this Product?: "); m.ValQuantity = Console.ReadLine();
            Console.Write("How does the cost of one Bottle?: "); m.ValPrice = float.Parse(Console.ReadLine());
            
            
            Console.Write("When is this Product Launched ?: "); m.ValProductionDate = Console.ReadLine();
            Console.Write("When will this product expire ?: "); m.ValExpiredDate = Console.ReadLine();

            Console.WriteLine("\t MILKID = {0}", m.ValMilkID);
            Console.WriteLine("\t Name = {0}, Quantity = {1}", m.ValMilkName, m.ValQuantity);
            Console.WriteLine("\t Production Date = {0}, Expired Date = {1}", m.ValProductionDate, m.ValExpiredDate);
            Console.WriteLine("\t Price = {0} VND/1 bottle", m.ValPrice);
        }
      

        public String ValMilkID
        {
            get { return MILKID; }
        }
        public String ValMilkName
        {
            get { return MilkName; }
            set { MilkName = value; }
        }
        public String ValQuantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public float ValPrice
        {
            get 
            {
             
                return Price;
            }
            set { Price = value; }
        }
        public String ValProductionDate
        {
            get { return ProductionDate.ToString("dd/M/yyyy"); }
            set
            {
                ProductionDate = DateTime.ParseExact(value, "dd/M/yyyy", CultureInfo.InvariantCulture);
                MILKID = String.Format("MILK{0}", this.ProductionDate.ToString("ddMyyyy"));
            }
        }
        public String ValExpiredDate
        {
            get { return ExpiredDate.ToString("dd/M/yyyy"); }
            set
            {
                ExpiredDate = DateTime.ParseExact(value, "dd/M/yyyy", CultureInfo.InvariantCulture);
            }
        }
    }
}

namespace LTNet_Lab02
{
    class Program
    {

        static void Main(string[] args)
        {
            Milk k = new Milk();
            k.InputInfo();
            k.DisplayInfo();
            
           

            Console.ReadKey();
        }
    }
    
       

       
    
}
