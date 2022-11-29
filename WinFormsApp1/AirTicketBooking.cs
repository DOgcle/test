using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AirTicketBooking : Form
    {
        Login ParentForm;
        public string strRegistration;
        public Customer currentCus;
        public User currentUser;
        public int idxRegistration;
        public AirTicketBooking()
        {
            InitializeComponent();
            ParentForm = Login.originalForm;
        }
        public void setCurrentUser(User user)
        {
            currentUser = user;
            currentCus = ParentForm.customers.Find(x => (x.CustomerID == currentUser.CustomerID));
            idxRegistration = ParentForm.flightBookings.FindIndex(x => (x.CustomerID == currentCus.CustomerID));
            if (idxRegistration >= 0)
            {
                foreach (Flight f in ParentForm.flightBookings[idxRegistration].flights)
                {
                    int idx = lsbAriTicket.FindString(f.FlightID.Trim());
                    lsbAriTicket.SetSelected(idx, true);
                }
            }
            ShowRegistrationInfo();
        }
        public string ShowRegistrationInfo()
        {
            strRegistration = "\t\t\t Infomation of Customer\n";
            strRegistration += "_______________________________________________________________________\n";
            strRegistration += String.Format("Customer ID:{0} \n \t Customer Name:{1}\n", currentCus.CustomerID, currentCus.CustomerName);

            int sumcredit;
            if (idxRegistration >= 0)
            {
                sumcredit = ParentForm.flightBookings[idxRegistration].CalCredit();
            }
            else
            {
                sumcredit = 0;
                strRegistration += String.Format("\t Sum Of Registered Credit:{0}\n", sumcredit);
                strRegistration += "_______________________________________________________________________\n";
                strRegistration += "\n" + "Customer ID" + "\t\t" + "Number of Credit" + "\t\t" + "Course Name";
                Flight f;
                foreach (Object selectedItem in lsbAriTicket.SelectedItems)
                {
                    f = ParentForm.flightList.Find(x => (x.FlightID == selectedItem.ToString()));
                    if (f != null)
                    {
                        strRegistration += "\n" + f.FlightID + "\t\t" + f.NumCredit + "\t\t" + f.FlightType;
                    }
                }

            }
            rtxtRegistration.Text = strRegistration;
            return strRegistration;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.ResetLogin = true;
            ParentForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (idxRegistration < 0)
            {
                ParentForm.flightBookings.Add(new FlightBooking(currentCus.CustomerID));
                idxRegistration = ParentForm.flightBookings.FindIndex(x => (x.CustomerID == currentCus.CustomerID));
                Flight f;
                foreach(Object selectedItem in lsbAriTicket.SelectedItems)
                {
                    f = ParentForm.flightList.Find(x => (x.FlightID == selectedItem.ToString()));
                    ParentForm.flightBookings[idxRegistration].flights.Add(f);
                }
            }
            ShowRegistrationInfo();
        }
    }
}
