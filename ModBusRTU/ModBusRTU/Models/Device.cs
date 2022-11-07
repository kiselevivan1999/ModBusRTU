using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModBusRTU.Models
{
    public class Device
    {
        private string _name;

        private List<int> _values;

        private List<int> _addresses;

        public string Name 
        {
            get => _name; 
            
            set => _name = value;

        }
        
        public List<int> Values 
        { 
            get => _values;

            set => _values = value;
        }
        
        public List<int> Addresses { get; set; }
    }
}
