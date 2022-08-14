using System;
using System.Collections.Generic;
using System.Text;

namespace _14AugHomeWork.Models
{
    class Song
    {
        private string _name;
        private string _genre;
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
        public string  Genre 
        {
            get 
            {
                return _genre;
            }
            set
            {
                if (value == "Pop")
                {
                    _genre = value;
                }
                else if (value == "Jazz")
                {
                    _genre = value;
                }
                else if (value == "Rock")
                {
                    _genre = value;
                }
                else if (value == "Techno") 
                {
                    _genre = value;
                }
            }
        }
        public Singer Singer { get; set; }
        private decimal _oldRating;
        private decimal _currentRating;
        private decimal _avarageRating;
        private int _countRating = 0;
        private decimal _sumRatings = 0;

        public void AddRating(decimal Rating) 
        {
            _oldRating = _currentRating;
            
            _currentRating = Rating;
            _countRating++;
            _sumRatings = _sumRatings + _currentRating;
            
        }
        #region Just for get current Rating

        //public decimal GetAverageRating()
        //{
        //    return _currentRating;
        //}
        #endregion
        public void FindAvarageRating() 
        {
            _avarageRating = _sumRatings  / _countRating;
        }
      
        public decimal GetAverageRating() 
        {
           
            return _avarageRating;
            

        }
        public void ShowInfo() 
        {
            Console.WriteLine($"Music name:{Name} \n Music genre:{Genre} \n Singer name:{Singer.Name} \n Singer surname:{Singer.SurName} \n Singer age:{Singer.Age} \n Avarage Rating: {_avarageRating} ");
        }



    }

}
