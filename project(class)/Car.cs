using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_class_
{
    internal class Car
    {
        public long Id { get; set; } = new Random().NextInt64(1, 100000000);
        public string? Model { get; set; }
        public double Price { get; set; }
        public bool IsUsed { get; set; }


      
        public void ShowInformation()
        {
            Console.WriteLine($"ID: {Id}\n" + $"Model: {Model}\n" + $"Price:  {Price} \n" + $"IsUsed: {IsUsed} \n" + $"");
        }
    }
}
