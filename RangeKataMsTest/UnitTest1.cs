using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RangeKataMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EndPointTest1()
        {
            int[] value = { 2, 6 };
            string Result = RangeKata.Program.endPoints(RangeKata.Program.SymbolOpen.CorcheteAbierto,RangeKata.Program.SymbolClose.ParentesisCerrado, value );
            Assert.AreEqual("[2,6) endPoints = {2,5}", Result);
        }
        [TestMethod]
        public void EndPointTest2()
        {
            int[] value = { 2, 6 };
            string Result = RangeKata.Program.endPoints(RangeKata.Program.SymbolOpen.CorcheteAbierto, RangeKata.Program.SymbolClose.CorcheteCerrado, value);
            Assert.AreEqual("[2,6) endPoints = {2,5}", Result);
        }
        [TestMethod]
        public void EndPointTest3()
        {
            int[] value = { 2, 6 };
            string Result = RangeKata.Program.endPoints(RangeKata.Program.SymbolOpen.ParentesisAbierto, RangeKata.Program.SymbolClose.ParentesisCerrado, value);
            Assert.AreEqual("[2,6) endPoints = {2,5}", Result);
        }
        [TestMethod]
        public void EndPointTest4()
        {
            int[] value = { 2, 6 };
            string Result = RangeKata.Program.endPoints(RangeKata.Program.SymbolOpen.ParentesisAbierto, RangeKata.Program.SymbolClose.CorcheteCerrado, value);
            Assert.AreEqual("[2,6) endPoints = {2,5}", Result);
        }
    }
}
