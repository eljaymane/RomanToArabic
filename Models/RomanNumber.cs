namespace RomanToArabic.Models
{

    public class RomanNumber {
        public char romanNumber{get;}
        public int value {get;}

        
        public RomanNumber(char roman, int val) {
            romanNumber = roman;
            value = val;
        }
    }
}