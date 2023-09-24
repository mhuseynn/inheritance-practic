using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backup
{
    public abstract class Storage
    {
        public string media_type_name { get; set; }

        public string media_model { get; set; }

        public Storage(string name, string model)
        {
            media_type_name = name;
            media_model = model;
        }


        public abstract double capacity();
        public abstract void copy(double size);
        public abstract double free_memory();
        public abstract void device_info();
    }
}
