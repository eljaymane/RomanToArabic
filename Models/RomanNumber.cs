namespace RomanToArabic.Models
{

    public class RomanNumber : IRomanNumber {
        private char romanNumber{get;}
        private int value {get;}

        
        public RomanNumber(char roman, int val) {
            romanNumber = roman;
            value = val;
        }
    }
}