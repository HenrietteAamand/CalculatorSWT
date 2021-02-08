using NUnit.Framework;
using Calculator;

namespace CalculatorSWT.Test.Unit
{
    public class CalculatorClass_Test_Unit
    {
        private CalclatorClass uut;
        [SetUp]
        public void Setup()
        {
            uut = new CalclatorClass();
        }

        [Test]
        public void Add_2And4_result6()
        {
            double result = uut.Add(2, 4);
            Assert.That(result, Is.EqualTo(6));
        }
    }
}
