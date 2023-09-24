using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backup
{
    public class DVD : Storage
    {
        public double read_speed { get; set; }

        public double memory_type { get; set; }
        public double write_speed { get; set; }


        public DVD(double rspeed, double wspeed, double type, string name, string model) : base(name, model)
        {
            read_speed = rspeed;
            write_speed = wspeed;
            this.memory_type = type;
        }
        public override double capacity()
        {
            return memory_type;
        }
        public override void copy(double size)
        {
            double media = (size / memory_type);
            double time = (media / (write_speed * 780));

            Console.WriteLine($"Media: {media}");
            Console.WriteLine($"Time: {time} san");
        }
        public override double free_memory()
        {
            return memory_type;
        }
        public override void device_info()
        {
            Console.WriteLine("Name: " + base.media_type_name);
            Console.WriteLine("Model: " + base.media_model);
            Console.WriteLine("read Speed" + read_speed);
            Console.WriteLine("write Speed" + write_speed);
            Console.WriteLine("Memory(1 face 4.7Gb or 2 face 9.0GB) : " + memory_type);
        }

    }
}
