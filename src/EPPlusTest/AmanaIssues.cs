namespace EPPlusTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OfficeOpenXml;
    using System;
    using System.IO;


    [TestClass]
    public class AmanaIssues : TestBase
    {

        [TestMethod]
        public void ExcelPackage_SaveAs_doesnt_throw_exception()
        {
            // Arrange
            var input = GetTestStream("SN_T_1506944663_AufrissGewinnundVerlustrechnung.xlsx");
            var package = new ExcelPackage(input);
            var output = Path.GetTempFileName();

            // Act-Assert
            package.SaveAs(output);

            // Cleanup
            File.Delete(output);

        }

        [TestMethod]
        public void Test_issue_with_whitespace_in_chart_xml()
        { 
            //Arrange
#if Core
            var dir = AppContext.BaseDirectory;
            dir = Directory.GetParent(dir).Parent.Parent.Parent.FullName;
#else
            var dir = AppDomain.CurrentDomain.BaseDirectory;
#endif
            var excelPackage = new ExcelPackage(new FileInfo(Path.Combine(dir, "Workbooks", "TestDoc_CountBlankSingleCell_xlsx.xlsx")));

            //Act
            var savePath = Path.Combine(TestContext.TestDeploymentDir, $"{TestContext.TestName}.xlsx");
            excelPackage.SaveAs(new FileInfo(savePath));

            excelPackage.Workbook.Calculate();

            //Asserts
            Assert.AreEqual("b)", excelPackage.Workbook.Worksheets[0].Cells["B3"].Value);
        }

        [TestMethod,
         Description(
             "Issue: If a cell is rich text and gets referenced by another cell by formula the Cell gets the Xml-Node as Value")]
        public void IssueTableWithXmlTags()
        {
            //Arrange
#if Core
            var dir = AppContext.BaseDirectory;
            dir = Directory.GetParent(dir).Parent.Parent.Parent.FullName;
#else
            var dir = AppDomain.CurrentDomain.BaseDirectory;
#endif
            //Act & Asserts
            var excelPackage = new ExcelPackage(new FileInfo(Path.Combine(dir, "Workbooks", "TestDoc_XMLTagsTable_xlsx.xlsx")));

            var sheet = excelPackage.Workbook.Worksheets["Tabelle1"];
            Assert.AreEqual(sheet.Cells["A1"].Value, sheet.Cells["B1"].Value);

            sheet.Calculate();
            Assert.AreEqual(sheet.Cells["A1"].Value, sheet.Cells["B1"].Value);

        }

        [TestMethod,
         Description(
             "Issue: If a VLookUp-Function contains a Date-Funktion as searchedValue an InvalidCastException is Thrown resulting in an #Value-Result")]
        public void TestIssueWithVLookUpDateValue()
        {
            //Arrange
#if Core
                var dir = AppContext.BaseDirectory;
                dir = Directory.GetParent(dir).Parent.Parent.Parent.FullName;
#else
            var dir = AppDomain.CurrentDomain.BaseDirectory;
#endif
            var excelPackage =
                new ExcelPackage(new FileInfo(Path.Combine(dir, "Workbooks", "TestDoc_VLookUpDateValue_xlsx.xlsx")));

            //Act
            var worksheet = excelPackage.Workbook.Worksheets[0];

            worksheet.Calculate();

            //Assert
            Assert.AreEqual(worksheet.Cells["C2"].Value, worksheet.Cells["E3"].Value);
        }

        [TestMethod]
        public void Named_range_calculated()
        {
            // ARRANGE
            var xlsx = GetTestStream("Issue_WithRangeCalculation.xlsx");
            var package = new ExcelPackage(xlsx);
            var sheet = package.Workbook.Worksheets[0];
            
            // ACT
            sheet.Calculate();

            // ASSERT
            Assert.AreEqual(311d, sheet.Cells["C1"].Value);
            Assert.AreEqual(306d, sheet.Cells["C2"].Value);

            Assert.AreEqual(103d, sheet.Cells["C3"].Value);
            Assert.AreEqual(104d, sheet.Cells["C4"].Value);
            Assert.AreEqual(105d, sheet.Cells["C5"].Value);
            Assert.AreEqual(106d, sheet.Cells["C6"].Value);
            Assert.AreEqual(107d, sheet.Cells["C7"].Value);
            Assert.AreEqual(108d, sheet.Cells["C8"].Value);
            Assert.AreEqual(109d, sheet.Cells["C9"].Value);
            Assert.AreEqual(110d, sheet.Cells["C10"].Value);

            Assert.AreEqual(112d, sheet.Cells["C12"].Value);
            Assert.AreEqual(113d, sheet.Cells["C13"].Value);
            Assert.AreEqual(114d, sheet.Cells["C14"].Value);

            Assert.AreEqual(101d, sheet.Cells["F21"].Value);
            Assert.AreEqual(102d, sheet.Cells["G21"].Value);
            Assert.AreEqual(103d, sheet.Cells["H21"].Value);
            Assert.AreEqual(104d, sheet.Cells["I21"].Value);
            Assert.AreEqual(105d, sheet.Cells["J21"].Value);
            Assert.AreEqual(106d, sheet.Cells["K21"].Value);
            Assert.AreEqual(107d, sheet.Cells["L21"].Value);
            Assert.AreEqual(108d, sheet.Cells["M21"].Value);
            Assert.AreEqual(109d, sheet.Cells["N21"].Value);
            Assert.AreEqual(110d, sheet.Cells["O21"].Value);
            Assert.AreEqual(111d, sheet.Cells["P21"].Value);
            Assert.AreEqual(112d, sheet.Cells["Q21"].Value);
            Assert.AreEqual(113d, sheet.Cells["R21"].Value);

            Assert.AreEqual(306d, sheet.Cells["H2"].Value);
            Assert.AreEqual(103d, sheet.Cells["H3"].Value);
            Assert.AreEqual(104d, sheet.Cells["H4"].Value);
            Assert.AreEqual(105d, sheet.Cells["H5"].Value);

            Assert.AreEqual(100d, sheet.Cells["I2"].Value);
            Assert.AreEqual(100d, sheet.Cells["I3"].Value);
            Assert.AreEqual(100d, sheet.Cells["I4"].Value);
            Assert.AreEqual(100d, sheet.Cells["I5"].Value);

            Assert.AreEqual(100d, sheet.Cells["J2"].Value);
            Assert.AreEqual(100d, sheet.Cells["J3"].Value);
            Assert.AreEqual(100d, sheet.Cells["J4"].Value);
            Assert.AreEqual(100d, sheet.Cells["J5"].Value);

            Assert.AreEqual("Falsche Auswahl", sheet.Cells["K2"].Value);
            Assert.AreEqual("Falsche Auswahl", sheet.Cells["K3"].Value);
            Assert.AreEqual("Falsche Auswahl", sheet.Cells["K4"].Value);
            Assert.AreEqual("Falsche Auswahl", sheet.Cells["K5"].Value);

            Assert.AreEqual(198d, sheet.Cells["C18"].Value);

            Assert.AreEqual("#VALUE!", sheet.Cells["C19"].Value.ToString());
            Assert.AreEqual("#VALUE!", sheet.Cells["C15"].Value.ToString());

            Assert.AreEqual(100d, sheet.Cells["C11"].Value);
            Assert.AreEqual(20d, sheet.Cells["C20"].Value);

            Assert.AreEqual("#VALUE!", sheet.Cells["H1"].Value.ToString());
            Assert.AreEqual("#VALUE!", sheet.Cells["I1"].Value.ToString());
            Assert.AreEqual("#VALUE!", sheet.Cells["J1"].Value.ToString());
            Assert.AreEqual("Falsche Auswahl", sheet.Cells["K1"].Value);
            Assert.AreEqual("#VALUE!", sheet.Cells["H6"].Value.ToString());
            Assert.AreEqual("#VALUE!", sheet.Cells["I6"].Value.ToString());
            Assert.AreEqual("#VALUE!", sheet.Cells["J6"].Value.ToString());
            Assert.AreEqual("Falsche Auswahl", sheet.Cells["K6"].Value);

            Assert.AreEqual("#VALUE!", sheet.Cells["C16"].Value.ToString());
            Assert.AreEqual("#VALUE!", sheet.Cells["E21"].Value.ToString());
            Assert.AreEqual("#VALUE!", sheet.Cells["S21"].Value.ToString());

            Assert.AreEqual(206d, sheet.Cells["F2"].Value);
            Assert.AreEqual(3d, sheet.Cells["F3"].Value);
            Assert.AreEqual(4d, sheet.Cells["F4"].Value);
            Assert.AreEqual(5d, sheet.Cells["F5"].Value);

            Assert.AreEqual(306d, sheet.Cells["M2"].Value);
            Assert.AreEqual(103d, sheet.Cells["M3"].Value);
            Assert.AreEqual(104d, sheet.Cells["M4"].Value);
            Assert.AreEqual(105d, sheet.Cells["M5"].Value);
            Assert.AreEqual("#VALUE!", sheet.Cells["M6"].Value.ToString());

            Assert.AreEqual(2d, sheet.Cells["F11"].Value);
            Assert.AreEqual(1d, sheet.Cells["F12"].Value);
        }
    }
}