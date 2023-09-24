using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backup
{
    public class Flash : Storage
    {
        public double speed_3  { get; set; }

        public double memory { get; set; }

        public Flash(double speed3, double memory, string name, string model) : base(name, model) 
        { 
            this.speed_3 = speed3;
            this.memory = memory;
        }
        public override double capacity()
        {
            return memory;
        }
        public override void copy(double size)
        {
            double media = (size / memory);
            double time = (media / (speed_3*780));

            Console.WriteLine($"Media: {media}");
            Console.WriteLine($"Time: {time} san");
        }
        public override double free_memory()
        {
            return memory;
        }
        public override void device_info()
        {
            Console.WriteLine("Name: " + base.media_type_name);
            Console.WriteLine("Model: " + base.media_model);
            Console.WriteLine("Speed" + speed_3);
            Console.WriteLine("Memory: " + memory);
        }
    }
}
