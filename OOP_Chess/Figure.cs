using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Chess
{
    public class Figure
    {
        private List<string> numbers = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8" };
        private List<string> letters = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H" };
        private string position;

        public FigureType Type { get; }
        public string Position
        {
            set
            {
                if (string.IsNullOrEmpty(value)) // hodnota v proměnné value je null nebo ""
                {
                    position = value; // figura je mimo šachovnici
                }
                else if (value.Length == 2)
                {
                    // první zank v proměnné value je v listu letters a druhý znak v proměnné value je v listu numbers
                    if (letters.Contains(value.Substring(0, 1).ToUpper()) && numbers.Contains(value.Substring(1, 1)))
                    {
                        position = value;
                    }
                    else
                    {
                        throw new Exception("Figure positon value has to be valid chess position!");
                    }
                }
                else
                {
                    throw new Exception("Figure positon value has to be 2 letters valid chess position!");
                }
            }
            get => position;
        }
        public FigureColor Color { get; }

        public byte[] Resorce
        {
            get
            {
                if (Color == FigureColor.Black)
                {
                    if (Type == FigureType.Queen)
                    {
                        return Properties.Resources.BlackQueen;
                    }
                    else if (Type == FigureType.King)
                    {
                        return Properties.Resources.BlackKing;
                    }
                    else if (Type == FigureType.Bishop)
                    {
                        return Properties.Resources.BlackBishop;
                    }
                    else if (Type == FigureType.Knight)
                    {
                        return Properties.Resources.BlackKnight;
                    }
                    else if (Type == FigureType.Rook)
                    {
                        return Properties.Resources.BlackRook;
                    }
                    else
                    {
                        return Properties.Resources.BlackPawn;
                    }
                }
                else
                {
                    if (Type == FigureType.Queen)
                    {
                        return Properties.Resources.WhiteQueen;
                    }
                    else if (Type == FigureType.King)
                    {
                        return Properties.Resources.WhiteKing;
                    }
                    else if (Type == FigureType.Bishop)
                    {
                        return Properties.Resources.WhiteBishop;
                    }
                    else if (Type == FigureType.Knight)
                    {
                        return Properties.Resources.WhiteKnight;
                    }
                    else if (Type == FigureType.Rook)
                    {
                        return Properties.Resources.WhiteRook;
                    }
                    else
                    {
                        return Properties.Resources.WhitPawn;
                    }
                }
            } 
        }

        public Figure(FigureType type, FigureColor color)
        {
            Type = type;
            Color = color;
        }

        public Figure(FigureType type, string position, FigureColor color)
        {
            Type = type;
            Position = position;
            Color = color;
        }

        public override string ToString()
        {
            //return Type.ToString().Substring(0,1) + Position.ToLower(); 
            return Color.ToString() + " " + Type.ToString() + " on " + Position;
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

    public enum FigureColor
    {
        White,
        Black
    }
}
