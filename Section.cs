using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Michael Arrey
 * C#
 * Lab2. 25 August 2020.
 * I wrote this code myself.
 */

namespace schoolProject
{
    class Section
    {
        public String section;

        public Section() //empty constructor 
        {
            this.section = " ";
        }
        public Section(String section) // constructor with one parameter
        {
            this.section = section;
        }
        //get and set method
        public String getSection()
        {
            return section;
        }
        public void setSection(String section)
        {
            this.section = section;
        }

        public void displaySection()
        {
            Console.WriteLine("You are registered for this section:" +getSection());
        }
    }
}
