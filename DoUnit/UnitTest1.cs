using DoUnit;
using NewAppUnit;

namespace DoUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetName()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getName();
            String Expected = "Jeff";
            Assert.AreEqual(Actual, Expected);
        }
        [TestMethod]
        public void TestEmail()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getEamil();
            String Expected = "joe@gmail.com";
            Assert.AreEqual(Actual, Expected);
        }
        [TestMethod]

        public void TestAge()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getAge();
            String Expected = "19";
            Assert.AreEqual(Actual, Expected);
        }
    }
}