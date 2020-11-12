using System;
using System.Collections.Generic;
using RomanToArabic.Models;
namespace RomanToArabic
{
    
    class Program
    {
        public static Dictionary<char,int> RomanDictionary;
        private static Dictionary<char,int> initDictionary() {
            var  dictionary = new Dictionary<char, int>();
            RomanNumber romanOne = new RomanNumber('I',1);
            RomanNumber romanFive = new RomanNumber('V',5);
            RomanNumber romanTen = new RomanNumber('X',10);
            RomanNumber romanFifty = new RomanNumber('L',50);
            RomanNumber romanHundred = new RomanNumber('C',100);
            RomanNumber romanFHundreds = new RomanNumber('D',500);
            RomanNumber romanThousand = new RomanNumber('M',1000);
            dictionary.Add(romanOne.romanNumber,romanOne.value);
            dictionary.Add(romanFive.romanNumber,romanFive.value);
            dictionary.Add(romanTen.romanNumber,romanTen.value);
            dictionary.Add(romanFifty.romanNumber,romanFifty.value);
            dictionary.Add(romanHundred.romanNumber,romanHundred.value);
            dictionary.Add(romanFHundreds.romanNumber,romanFHundreds.value);
            dictionary.Add(romanThousand.romanNumber,romanThousand.value);
            Console.WriteLine("Done initiliazing number's dictionary !");
            return dictionary;

        }
        static void Main(string[] args)
        {
           RomanDictionary =  initDictionary();
            char quit = 'N';
            do {
                Console.WriteLine("Enter roman number : ");
            char[] romanNumber =  Console.ReadLine().ToCharArray();
            int arabicNumber=0;
            for(var i =0; i <romanNumber.Length ; i++){
                 int value = RomanDictionary.GetValueOrDefault(romanNumber[i]);
                if(i+1 < romanNumber.Length){
               
                int value_next = RomanDictionary.GetValueOrDefault(romanNumber[i+1]);
                    if(value > value_next || value == value_next){
                    arabicNumber+= value;
                    }
                    else if (value < value_next){
                    arabicNumber += value_next -value;
                        i++;
                    }
                    
                } else {
                    arabicNumber += value;
                }
                
            }
            Console.WriteLine("The roman number " + romanNumber.ToString() + " is : " + arabicNumber);
            Console.WriteLine("Type N to convert another number or Y to quit : ");
            quit = Console.ReadLine().ToCharArray()[0];
            }while(!quit.Equals('Y'));
            
        }

        
    }
}
