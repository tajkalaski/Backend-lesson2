using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer

    {

        // fields
        private string firstName;
        private string lastName;
        private string address;
        private string zip;
        private string city;
        private string phone;

        // properties
        public string FirstName
        {
            get { return firstName; } // read
            set { firstName = value; } // write
        }

        public string LastName
        {
            get { return lastName; } // read
            set { lastName = value; } // write
        }

        public string Address
        {
            get { return address; } // read
            set { address = value; } // write
        }

        public string Zip
        {
            get { return zip; } // read
            set { zip = value; } // write
        }

        public string City
        {
            get { return city; } // read
            set { city = value; } // write
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public List<string> PhoneNumbers { get; } = new List<string>();


        // constructors
        public Customer(string firstName, string lastName, string address, string zip, string city, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.zip = zip;
            this.city = city;
            this.phone = phone;
        }


    }

}
