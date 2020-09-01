using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolProject
{
    class Address
    {
       public String street;
       public String city;
       public String state;
       public int zipCode;

        public Address() { // empty constructor

            this.street = " ";
            this.city = " ";
            this.state = " ";
            this.zipCode = 0;
        }
        //constructor with parameters
        public Address(String street, String city, String state, int zipCode)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
        }
        //get and set methods for all variables 
        public String getStreet() {
            return street;
        }
        public String getCity()
        {
            return city;
        }
        public String getState()
        {
            return state;
        }
        public int getZipcode()
        {
            return zipCode;
        }
        public void setStreet(String street)
        {
            this.street = street;
        }
        public void setCity(String city)
        {
            this.city = city;
        }
        public void setStare(String state)
        {
            this.state = state;
        }
        public void setZipcode(int zipCode)
        {
            this.zipCode = zipCode;
        }

        //display method prints output on console
        public void displayAdd() {
            Console.WriteLine(getStreet());
            Console.WriteLine(getCity());
            Console.WriteLine(getState());
            Console.WriteLine(getZipcode());
        }
    }
    
}
