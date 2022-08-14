using System;
using System.Collections.Generic;
using System.Text;

namespace _14AugHomeWork.Models
{
    class Singer
    {
        private string _name;
        private string _surName;
        private int _age;
        public string Name 
        {
            get
            {
                return _name;
            }
            set 
            {
                if (value.Length<=100)
                {
                    _name = value;
                }
            }
        }
        public string SurName 
        {
            get
            {
                return _surName;
            }
            set 
            {
                if (value.Length<=100)
                {
                    _surName = value;
                }
            }
        }
        public int Age 
        { get 
            {
                return _age;
            }
            set 
            {
                if (value<=170)
                {
                    _age = value;
                }
            }
        }
        public void ShowInfo() 
        {
            Console.WriteLine($"Name:{Name} \n Surname:{SurName} \n Age:{Age}");
        }
    }
}
