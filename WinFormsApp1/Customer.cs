using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace WinFormsApp1
{
    
    
        public class FlightBooking
        {
            public string CustomerID { get; set; }
            public List<Flight> flights;
            public FlightBooking()
            {
                CustomerID = "Not Assignment";
                flights = new List<Flight>();
            }
            public FlightBooking(string CustomerID)
            {
                this.CustomerID = CustomerID;
                this.flights = new List<Flight>();
            }
            public int CalCredit()
            {
                return flights.Sum(x => x.NumCredit);
            }
        }
        public class Flight
        {
          
            public string FlightID { get; set; }
            public string FlightType { get; set; }
            public DateTime TimeDepart { get; set; }
            public DateTime TimeArrival { get; set; }
            public int NumCredit { get; set; }
            public Flight()
            {
                FlightID = "Not Assigned";
            }
            public Flight( string FlightID, string FlightType, string TimeDepart, string TimeArrival, int NumCredit)
            {
                this.FlightID = FlightID;
                this.FlightType = FlightType;
                this.TimeDepart = DateTime.ParseExact(TimeDepart, "dd/M/yyyy", CultureInfo.InvariantCulture);
                this.TimeArrival = DateTime.ParseExact(TimeDepart, "dd/M/yyyy", CultureInfo.InvariantCulture);
            }
        }
        public class User
        {
            public string userName { get; set; }
            public string password { get; set; }
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
            public User()
            {
                userName = "Not Assignment";
            }
            public User(string username, string password, string CustomerID, string CustomerName)
            {
                this.userName = username;
                this.password = password;
                this.CustomerID = CustomerID;
                this.CustomerName = CustomerName;
            }
        }

        public enum Sex { Male, Female }

        public class Customer
        {
            public string CustomerID { get; set; }
            public string CustomerName { get; set; }
            public Sex Gender { get; set; }
            public DateTime Birthday { get; set; }
            public string PastportNBR { get; set; }
            public string Nationality { get; set; }
            public Image Avatar { get; set; }
            public string Password { get; set; }
            public Customer()
            {
                CustomerID = "Not Assignment";
                CustomerName = "Not Assignment";

            }
            public Customer(string CustomerID, string CustomerName, Image Avatar, Sex Gender, string Password,
                string Birthday = "01/01/2022", string PastportNBR = "", string Nationality = " ")
            {
                this.Avatar = Avatar;
                this.CustomerName = CustomerName;
                this.CustomerID = CustomerID;
                this.Gender = Gender;
                this.Birthday = DateTime.ParseExact(Birthday, "dd/M/yyyy", CultureInfo.InvariantCulture);
                this.PastportNBR = PastportNBR;
                this.Nationality = Nationality;
                this.Password = Password;
            }
        }
    }

