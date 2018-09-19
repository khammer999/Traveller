using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellerTest
{
    [TestFixture]
    class TravellerTests
    {
        [Test]
        public void Enter_Eye_Color()
        {
            Beach beach = new Beach("blue");
            string response = beach.GetColor;
            Assert.That(response, Is.EqualTo("blue"));
         } 

        [Test]
        public void Enter_String_Return_Beach_Green()
        {
            Beach beach = new Beach();
            string response = beach.GetBeach("green");
            Assert.That(response, Is.EqualTo("Seal Beach"));

        }

        [Test]
        public void Enter_String_Return_Beach_Brown()
        {
            Beach beach = new Beach();
            string response = beach.GetBeach("brown");
            Assert.That(response, Is.EqualTo("Newport Beach"));

        }
        [Test]
        public void Enter_String_Return_Beach_Grey()
        {
            Beach beach = new Beach();
            string response = beach.GetBeach("grey");
            Assert.That(response, Is.EqualTo("Huntington Beach"));

        }

        [Test]
        public void Set_Shoe_Size()
        {
            Beach beach = new Beach();
            beach.GetShoeSize = 10.5;
            double response = beach.GetShoeSize;
            Assert.That(response, Is.EqualTo(10.5));

        }




    }
}
