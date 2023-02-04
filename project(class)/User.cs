using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_class_
{
    internal class User
    {
        public long Id { get; set; } = new Random().NextInt64(1,100000000);
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public double Amount { get; set; }
        public List<Car> UserCars { get; set; } 


        public User()
        {
            UserCars = new List<Car>();
        }


        public void ChangeUserName(string newUserName)
        {
            UserName = newUserName;
        }

        public void ChangePassword(string newPassword)
        {
            Password = newPassword;
        }

        public bool PurchaseCar(Car newCar)
        {
            if (Amount >= newCar.Price)
            {
                Amount -= newCar.Price;
                UserCars.Add(newCar);
                return true;
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                return false;
            }
        }

        public void RemoveCar(Car carToRemove)
        {
            UserCars.Remove(carToRemove);
        }

        public void ShowOwnedCars()
        {
            if(UserCars.Count == 0)
            {
                Console.WriteLine(UserName + " has no cars");
            }
            else
            {
                for(int i = 0; i < UserCars.Count; i++)
                { 
                Console.Write((i + 1) + ")");
                UserCars[i].ShowInformation();
                }

            }
            
        }

        public void ShowUserInformation()
        {
            Console.WriteLine(UserName + " - " + Amount);
            
        }


    }

    

}
