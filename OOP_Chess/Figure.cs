using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Chess
{
    public class Figure
    {
        private List<string> numbers = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string position;
        
        public FigureType Type { get; set; }
        public string Position
        {
            set
            {
                if (string.IsNullOrEmpty(value)) // hodnota v proměnné value je null nebo ""
                {

                }
                else if (value.Length == 2)
                {
                    if (numbers.Contains(value.Substring(1, 1))) // druhý znak v proměnné value je v listu numbers
                    { 

                    }
                }

                else 
                {

                }
            }
            get => position;
        }

        public Figure()
        {
            Position = "A2";
            Position = "a2";
            Position = "sdfsdf";
        }
    }

    // výčtový datový typ - seznam hodnot - interně sou to hodnoty integer (od 0)
    public enum FigureType
    {
        Pawn,       // pěšec
        Rook,       // věž 
        Knight,     // jezdec 
        Bishop,     // střelec 
        Queen,      // dáma 
        King,       // král
    }
}
