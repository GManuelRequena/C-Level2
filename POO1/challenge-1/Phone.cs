using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1
{
    internal class Phone
    {
        private string model;

        private string brand;

        private string phoneNumber;

        private int code;

        public string Model
        {
            get { return model; }
        }

        public string Brand
        {
            get { return brand; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public int Code
        {
            get { return code; }
            set
            {
                if (value != 1 && value != 2 && value != 3)
                {
                    this.code = 0;
                }
                else
                {
                    this.code = value;
                };
            }
        }

        public Phone(string model, string brand)
        {
            this.model = model;
            this.brand = brand;
        }

        public string Call()
        {
            return "Calling ...";
        }

        public string Call(string name)
        {
            return "Calling to " + name;
        }
    }
}
