using System;
using System.Collections.Generic;
using System.Text;

namespace Weather
{
    class weather
    {
        private string name;

        public weather(string name)
        {
            this.name = name;
        }

        public string City { get; set; }
        public double Temperature { get; set; }
        public string Weather { get; set; }
        
    }
}
