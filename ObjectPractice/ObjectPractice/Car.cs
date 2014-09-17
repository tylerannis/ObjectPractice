using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    public class Car
    {
        //Step1 we declare properties and variables
        //declare a property the long way
        private string _make; //prperty variable is called make and is only accessably in this class because it's private
        //declare the Make property
        public string Make
        {
            //the getter will get the variable when it is called
            get
            {
                return _make;
            }
            //value is a specail keyword in the setter, now you can set value to lambda expressions
            //the setter sets the value of the property
            set
            {
                _make = value.ToUpper();
            }
            //the easy way is propfull and hit tab twice:


            // private int myVar;

            //	public int MyProperty
            //{
            //get { return myVar;}
            //set { myVar = value;}
            //	}
        }
        //have to be outside of properties
	        //shorthand version of a property
            public string Model { get; set; }

        //Step2: Declare Constructor
        //we have seen constructors while creating lists and rngs
        //they set up our objects to be used
        //Now in order to call Car in another class you need both make and model
            public Car(string make, string model)
            {
                //set the property Make to var make
                this.Make = make;
                this.Model = model;
            }
        //you can have multiple constructors
            public Car()
            {
                this.Model = "undefined";
                this.Make = "undefined";
            }

        //step 3 is Methods and functions
        //What does the car do
            public void Honk()
            {
                Console.WriteLine("Beep Beep");
            }
            public string GetInfo()
            {
                //returns a string with information about the car
                return this.Make + " " + this.Model;
            }

    }
}
