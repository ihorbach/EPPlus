using EPPlusTest.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml;
using System;
using System.IO;

namespace EPPlusTest
{
    [TestClass]
    public class AmanaIssues : TestBase
    {
        [TestMethod]
        public void Round_Issue()
        {
            //Arrange
#if Core
            var dir = AppContext.BaseDirectory;
            dir = Directory.GetParent(dir).Parent.Parent.Parent.FullName;
#else
            var dir = AppDomain.CurrentDomain.BaseDirectory;
#endif
            var excelPackage = new ExcelPackage(new FileInfo(Path.Combine(dir, "Workbooks", "TestDoc_round_issue_xlsx.xlsx")));

            //Act
            excelPackage.Workbook.Calculate();
            var table = excelPackage.Workbook.Worksheets[0];

            var value1 = table.Cells["A1"].Value.ToString();
            var value2 = table.Cells["A4"].Value.ToString();
            var value3 = table.Cells["B4"].Value.ToString();

            //Asserts
            Assert.IsTrue(value1.Equals("-18"));
            Assert.IsTrue(value2.Equals("-40,5"));
            Assert.IsTrue(value3.Equals("-23,4"));
        }
    }
}