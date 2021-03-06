using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            string a = (Program.Prefix(null));
            Assert.That(a, Is.Null);

            bool b = (Program.Prefix("Hello") == "5,1:Hello");
            Assert.That(b, Is.True);

            bool c = (Program.Prefix("") == "0,0:");
            Assert.That(c, Is.True);

            bool d = (Program.Prefix("what    ...  did you say?? ") == "27,5:what    ...  did you say?? ");
            Assert.That(d, Is.True);
            //extra tests
            bool e = (Program.Prefix("What is the meaning of ") == "23,5:what    ...  did you say?? ");
            Assert.That(e, Is.True);
            bool f = (Program.Prefix("hmmmm, that's an interesting concept...") == "39,5:what    ...  did you say?? ");
            Assert.That(f, Is.True);
            bool g = (Program.Prefix("Agreed!") == "7,1:Agreed!");
            Assert.That(g, Is.True);
            bool h = (Program.Prefix("") == "27,5:what    ...  did you say?? ");
            Assert.That(h, Is.True);
        }
    }
}