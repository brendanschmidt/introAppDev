using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //by default all class are private
    //for this class tobe used by an outside user
    //   you must alter the permission for this class
    //   you will use public

    public class FencePanel
    {
        //Properties
        //a property is associated with a single piece of data
        //a property has two sub components:
        //  get: returns a value to the calling client (outside user)
        //  set: receives a value from the calling client
        //      a keyword 'value' is used to hold the incoming data to the property
        //  the property has a return datatype (rdt) which specifies
        //      the type of data allowed
        //the property syntax does NOT allow for a parameter.

        //Auto Implemented Property:
        //this style does NOT create a private data member
        //this system will create an internal data member of the
        //  rdt specified in the property definition

        // public double Height { get; set; } what about negative numbers???

        //Assuming you wish to validate your data, then you should be using 
        //  a fully implemented property
        //example: Height must have a positive non-zero value
        //         Height must not be greater than 8 feet
        private double _Height;
        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                //validation of data
                //throw exception if invalid
                if(value > 0.0 && value <= 8.0)
                {
                    _Height = value;
                }
                else
                {
                    throw new Exception("Invalid height.");
                }
            }
        }
        public double Width { get; set; }

        //Fully Implemented Property;
        //this style NEEDS a private data member
        //the private data member will store the incoming data value
        //Usually, this form of property is used when
        //  additional coding is required for the incoming data
        //  such as: Validation of the data


        //example: the string data CANNOT be an empty string
        private string _Style;

        public string Style
        {
            //the keyword value holds the incoming data to
            //  the property
            get
            {
                //returns the stored data value
                return _Style;
            }
            set
            {
                //stores the incoming value in 'value' to the
                // private data member for storage
                if (string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
            }
        }

        //nullable numeric property for a double.
        //there are ONLY two possibilites:
        //  a) data is missing: null
        //  b) data is present and is of the right datatype

        public double? Price { get; set; }

    }
}
