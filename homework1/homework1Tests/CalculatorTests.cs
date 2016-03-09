using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace homework1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        List<FinancialReport> _financialReport;
        public CalculatorTests()
        {
            this._financialReport = new List<FinancialReport>
            {
                new FinancialReport { Id=1, Cost=1, Revenue=11, SellPrice=21 },
                new FinancialReport { Id=2, Cost=2, Revenue=12, SellPrice=22 },
                new FinancialReport { Id=3, Cost=3, Revenue=13, SellPrice=23 },
                new FinancialReport { Id=4, Cost=4, Revenue=14, SellPrice=24 },
                new FinancialReport { Id=5, Cost=5, Revenue=15, SellPrice=25 },
                new FinancialReport { Id=6, Cost=6, Revenue=16, SellPrice=26 },
                new FinancialReport { Id=7, Cost=7, Revenue=17, SellPrice=27 },
                new FinancialReport { Id=8, Cost=8, Revenue=18, SellPrice=28 },
                new FinancialReport { Id=9, Cost=9, Revenue=19, SellPrice=29 },
                new FinancialReport { Id=10, Cost=10, Revenue=20, SellPrice=30 },
                new FinancialReport { Id=11, Cost=11, Revenue=21, SellPrice=31 },
            };
        }

        [TestMethod()]
        public void 每三筆Cost加總_總合分別為_6_15_24_21()
        {
            //arrange
            var target = new Calculator();
            var expected = new List<int> { 6, 15, 24, 21 };
            var columnName = "Cost";
            var itemAccount = 3;

            //act
            var actual = target.GetSumListByColumnAndItemAmount(_financialReport, columnName, itemAccount);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 每四筆Revenue加總_總合分別為_50_66_60()
        {
            //arrange
            var target = new Calculator();
            var expected = new List<int> { 50, 66, 60 };
            var columnName = "Revenue";
            var itemAccount = 4;

            //act
            var actual = target.GetSumListByColumnAndItemAmount(_financialReport, columnName, itemAccount);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
