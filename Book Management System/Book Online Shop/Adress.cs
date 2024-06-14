using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Online_Shop
{
    public class Adress
    {


        private string state;
        private string city;
        private string street;
        private string building;

        public string State
        {
            get { return state; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("State cannot be empty or whitespace.");
                }
                state = value;
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("City cannot be empty or whitespace.");
                }
                city = value;
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Street cannot be empty or whitespace.");
                }
                street = value;
            }
        }

        public string Building
        {
            get { return building; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Building cannot be empty or whitespace.");
                }
                building = value;
            }
        }

    }

    
}
