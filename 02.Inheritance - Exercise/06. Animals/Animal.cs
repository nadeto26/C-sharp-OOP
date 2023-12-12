using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{


    public abstract class Animal
    {
        public Animal (string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
            
        }
           

		private string name;

		public string Name
		{
			get { return name; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Inavalid input");
				}
                name = value;
			}
            
			
			
			 
		}

        private string gender;

        public string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inavalid input");
                }

                gender = value;
            }



        }

        private int  age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Inavalid input");
                }

                age = value;
            }



        }

        public abstract string ProduceSound();

        // всички наследници ще са задължени да го имплементират 

        public override string ToString()
        => $"{Name} {Age} {Gender} {Environment.NewLine}{ProduceSound()}";
    }
}
