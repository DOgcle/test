using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baitaptuan3;


namespace baitaptuan3
{
    public static class MyExtensions
    {
        public static string ConvertToString(this Customer customer)
        {
            string customertype = Enum.GetName(typeof(CustomerType), customer.customer1);
            if (customer.CustomerID1 != "C000")
            {
                return String.Format("ID: {0} Name: {1} Address: {2}Phone: {3} Type: {4} ", customer.CustomerID1, customer.CustomerName1, customer.CustomerAddress1, customer.CustomerPhone1, customertype);

            }
            else
            {
                return " ";

            }
          
        }
    }
    public enum CustomerType {loyal, potential, needAtention,theOtherClient};
     public class Customer
    {
        private string CustomerID="C000";
        private string CustomerName="A";
        private string CustomerAddress="A";
        private string CustomerPhone="0";
        private CustomerType customer = CustomerType.loyal;
        public Customer() { }
        public Customer(string CustomerID, string CustomerName , string CustomerAddress, string CustomerPhone, CustomerType customertype)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.CustomerAddress = CustomerAddress;
            this.CustomerPhone = CustomerPhone;
            this.customer = customertype;
        }

        public string CustomerID1 { get => CustomerID; set => CustomerID = value; }
        public string CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public string CustomerAddress1 { get => CustomerAddress; set => CustomerAddress = value; }
        public string CustomerPhone1 { get => CustomerPhone; set => CustomerPhone = value; }
        public CustomerType customer1 { get => customer; set => customer = value; }
        
        public void CustomerInfo() 
        {
            if(CustomerID != "C000")
            {
                string customertypeName = Enum.GetName(typeof(CustomerType), customer);
                Console.WriteLine("ID: {0} Name: {1} Address: {2}Phone: {3} Type: {4} ", CustomerID, CustomerName, CustomerAddress, CustomerPhone, customertypeName);
            }

        }
        
    }
    class Company
    {
        public delegate void CompanyHandler(Company company);
        public event CompanyHandler CompanyAddorRemoveEvent;
        int NumberOfCustomer;
        private string CompanyName;
        public List<Customer> ListOfCustomers;
        Dictionary<CustomerType, string> customertypeinfo = new Dictionary<CustomerType, string>();

        public Company()
        {
            CompanyName = "Not Assigned";
            ListOfCustomers = new List<Customer>();
            customertypeinfo.Add(CustomerType.loyal, "Khach hang thuong xuyen mua");
            customertypeinfo.Add(CustomerType.needAtention, "Khach hang can quan tam nhieu hon");
            customertypeinfo.Add(CustomerType.potential, "Khach hang co the co nhu cau mua san pham cua cong ty");
            customertypeinfo.Add(CustomerType.theOtherClient, "nhung khach hang khong thuoc loai tren");

        }
        public string CompanyName1 { get => CompanyName; set => CompanyName = value; }
        public int NumberOfCustomer1 { get => NumberOfCustomer; set => NumberOfCustomer = value; }

        public void CompanyInfo()
        {
            Console.WriteLine("Name company {0} and number customers of company {1} ", CompanyName, ListOfCustomers.Count);
            foreach(Customer c in ListOfCustomers)
            {
                KeyValuePair<CustomerType, string> info = customertypeinfo.FirstOrDefault(o => o.Key == c.customer1);
                c.CustomerInfo();
                Console.WriteLine("---Thong tin tung loai khach hang: {0}\n", info.Value);
            }
           
        }
        public Customer SearchCustomer<T>(T search)
        {
            Customer c = new Customer();
            if(typeof(T) == typeof(string))
            {
                c = ListOfCustomers.FirstOrDefault(o => o.CustomerName1 == search.ToString());
                if (c != null)
                {
                    return c;
                }
                else if(typeof(T)== typeof(int))
                {
                    if (Convert.ToInt32(search) < ListOfCustomers.Count)
                        return ListOfCustomers[Convert.ToInt32(search)];
                }
            }
            Console.WriteLine("Customer is not found");

            return new Customer();
        }
        public void AddCustomer(Customer customer)
        {
            ListOfCustomers.Add(customer);

        }
        public void RemoveCustomer(Customer customer)
        {
            ListOfCustomers.Add(customer);
        }
        public void OnCustomerChanger(Company company)
        {
            if(CompanyAddorRemoveEvent!= null)
            {
                CompanyAddorRemoveEvent(this);
            }
        }

    }
  
}
namespace main
{
    class Program
    {
        static void UpdateListOfCustomer(Company company)
        {
            company.NumberOfCustomer1 = company.ListOfCustomers.Count;
        }

        static void Main(string[] args)
        {

            Company company = new Company();
            company.CompanyName1 = "ABC";
            company.CompanyAddorRemoveEvent += new Company.CompanyHandler(UpdateListOfCustomer);

            company.AddCustomer(new Customer("001", "Tai", "HCM", "0646545",CustomerType.loyal));
            company.AddCustomer(new Customer("002", "Tan", "HCM", "014545", CustomerType.needAtention));
            company.AddCustomer(new Customer("003", "Ta", "DaNang", "098741", CustomerType.potential));
            company.AddCustomer(new Customer("004", "Ti", "HN", "0466235", CustomerType.theOtherClient));

            Customer customer = company.SearchCustomer("001");
            company.RemoveCustomer(customer);

            company.CompanyInfo();
         


            Console.ReadKey();
        }
    }
}
