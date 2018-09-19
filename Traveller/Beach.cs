namespace TravellerTest
{
    public class Beach
    {
        //fields
        private string eyeColor;
        private double shoeSize;

        // properties
        public string GetColor
        { 
            get {return this.eyeColor;}
            set {this.eyeColor = value;}
        }

        public string GetShoeSize
        {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
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
            }else
            return " ";
        }


    }
}