using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    
    internal class  Book 
    {

        
        private string _title;
        private string _author;
        private int _year;
        private string _publisher;
        private int _wordsCount;

        
        public string Title
        {
            get { return _title; }
            set { 
                if (string.IsNullOrEmpty(value)) {
                    Console.WriteLine($"Not A valid {System.Reflection.MethodBase.GetCurrentMethod().Name}");
                }
                else
                {
                    _title = value;
                }
                
            }
        }
        //Not required
        public string Author
        {
            get { return _author; } 
            set { _author = value; }
        }
        
        public int Year
        {
            get { return _year; }
            set {
                if (ValidateNaturalNumber(value, System.Reflection.MethodBase.GetCurrentMethod().Name))
                {
                    _year = value;
                }
               
                
            }
        }
        //Not required
        public string Publisher
        {
            get { return _publisher; }
            set
            {
                _publisher = value;
            }
        }

        public int WordsCount
        {
            get { return _wordsCount; }
            set
            {
                if (ValidateNaturalNumber(value, System.Reflection.MethodBase.GetCurrentMethod().Name))
                {
                    _wordsCount = value;
                }
                else
                {
                    Console.WriteLine("Not valid Number of words");
                }
                
            }
        }

        private static bool ValidateNaturalNumber(int count,string name)
        {
            if (count <= 0) {
                Console.WriteLine($"Not a Valid {name}");
                return false;
            }
            return true;
        }

    }
}
