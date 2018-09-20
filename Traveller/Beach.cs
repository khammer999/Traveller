﻿namespace TravellerTest
{
    public class Beach
    {
        //fields
        private string eyeColor;
        private double shoeSize;
        private List<string> name = List<string>();

        // properties
        public string GetColor
        { 
            get {return this.eyeColor;}
            set {this.eyeColor = value;}
        }

        public double GetShoeSize
        {
            get { return this.shoeSize; }
            set { this.shoeSize = value; }
        }

        public List<string> Names
        {
            get { return this.name; }
            set { this.name = value; }
        }




        //Constructors

        public Beach()
        {

        }


        public Beach(string eyeColor) 
        {
            this.GetColor = eyeColor;
        }

        //methods
        public string GetBeach(string eyeColor)
        {

            if (eyeColor == "green")
            {
                return "Seal Beach";

            }else if(eyeColor== "brown")
            {
                return "Newport Beach";
            }else if (eyeColor == "grey")
            {
                return "Huntington Beach";
            }
            return " ";
        }

        public string GetHotel(double num, string value)
        {
            if (((num >= 6) && (num <= 10)) && (value == "Seal Beach"))
            {
                return "Hilton";
            }
            else if (((num > 10) && (num <= 12)) && (value == "Huntington Beach"))
            {
                return "Best Western";
            }
            else if ((num > 12) && (value == "Newport Beach"))
            {
                return "Marriot";
            }
            else
            {
                return null;
            }
        }

        public string GetNames()
        {
            if (Names.Count > 0 && Names.Count <= 4)
            {
                return "Toyota";
            }
            else
            {
                return null;
            }

        }

    }
}