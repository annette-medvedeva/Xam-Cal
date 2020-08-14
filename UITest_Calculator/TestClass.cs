using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UITest_Calculator
{
    public class TestClass
    {
        MainScreenModel _msModel = new MainScreenModel();
        [SetUp]
        public void StartAppBeforeEachTest()
        {
            AppInitializer.StartApp();
        }

        [Test]
        public void MyFirstMobileTest()
        {
            //AppInitializer.App.Repl();
            _msModel.TapOnOne()
                .TapOnMinus()
                .TapOnFive()
                .TapOnEquel();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest2()
        {

            _msModel.TapOnThree()
                .TapOnFour()
                .TapOnMinus()
                .TapOnFive()
                .TapOnEquel();
            Assert.AreEqual("29", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest3()
        {
            _msModel.TapOnEight()
                .TapOnMultiply()
                .TapOnNine()
                .TapOnEquel()
                .TapOnDel();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest3_()
        {
            _msModel.TapOnEight()
                .TapOnMultiply()
                .TapOnNine()
                .TapOnEquel();
            Assert.AreEqual("72", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest4()
        {
            _msModel.TapOnTwo().TapOnEight().TapOnDivide().TapOnSeven().TapOnEquel();
            Assert.AreEqual("4", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest5()
        {
            _msModel.TapOnSix()
                .TapOnZero()
                .TapOnMinus()
                .TapOnTwo()
                .TapOnPlus()
                .TapOnNine()
                .TapOnMultiply()
                .TapOnOne()
                .TapOnTwo()
                .TapOnDivide()
                .TapOnOne()
                .TapOnSix()
                .TapOnEquel();
            Assert.AreEqual("50,25", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest6()
        {
            _msModel.TapOnTwo()
                .TapOnEight()
                .TapOnDivide()
                .TapOnSeven()
                .TapOnEquel()
                .TapOnMultiply()
                .TapOnOne()
                .TapOnTwo()
                .TapOnMinus()
                .TapOnNine()
                .TapOnEquel();
            Assert.AreEqual("39", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest7()
        {
            _msModel.TapOnTwo()
                .TapOnEight()
                .TapOnDivide()
                .TapOnSeven()
                .TapOnEquel()
                .TapOnMultiply()
                .TapOnOne()
                .TapOnTwo()
                .TapOnMinus()
                .TapOnNine()
                .TapOnEquel();
            Assert.AreEqual("39", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest8()
        {
            _msModel
                .TapOnZero()
                .TapOnComma()
                .TapOnFour()
                .TapOnDivide()
                .TapOnZero()
                .TapOnComma()
                .TapOnTwo()
                .TapOnEquel();

            Assert.AreEqual("2", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest9()
        {
            _msModel.TapOnMinus()
                    .TapOnNine()
                    .TapOnNine()
                    .TapOnMinus()
                    .TapOnOne()
                    .TapOnZero()
                    .TapOnZero()
                    .TapOnEquel();
                Assert.AreEqual("-199", _msModel.GetTextFromTextField());
        }
        [Test]
        public void MobileTest10()
        {
            _msModel.TapOnZero()
                .TapOnComma()
                .TapOnThree()
                .TapOnDivide()
                .TapOnZero()
                .TapOnEquel();
            Assert.AreEqual("Error", _msModel.GetTextFromTextField());
        }
    }
}
