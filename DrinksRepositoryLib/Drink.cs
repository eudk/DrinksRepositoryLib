using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksRepositoryLib
{
   public class Drink // this is the model class
    {
        // properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }



      

            public void ValidateName()
            {
                if (Name == null)
                {
                    throw new ArgumentNullException();
                }
                if (Name.Length < 3)
                {
                    throw new ArgumentException("Must be longer than 3");
                }
            }


        }
    }


