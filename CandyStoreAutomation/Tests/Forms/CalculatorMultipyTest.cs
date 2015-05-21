using atf.toolbox;
using CandyStore.ScreenObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace CandyStoreAutomation.Tests.Forms
{
    [TestClass]
    public class CalculatorMultipyTest
    {
        public TestContext TestContext { get; set; }

        private static CalculatorScreen _calculatorScreen;

        [ClassInitialize]
        public static void ClassSetup(TestContext context)
        {
            _calculatorScreen = (CalculatorScreen)ScreenObjectFactory.Instance(ScreenObjectFactory.CALCULATOR);
        }

        [ClassCleanup]
        public static void ClassTeardown()
        {
            ATFHandler.Instance.TearDown();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "CalculatorData.csv", "CalculatorData#csv", DataAccessMethod.Sequential)]
        public void FrmShouldMultiply2NumbersCSVDriver()
        {
            _calculatorScreen.EnterNumberIntoCalculator(Convert.ToInt32(TestContext.DataRow["FirstNumber"]));
            _calculatorScreen.MultiplyClick();
            _calculatorScreen.EnterNumberIntoCalculator(Convert.ToInt32(TestContext.DataRow["SecondNumber"]));
            _calculatorScreen.EqualsClick();

            _calculatorScreen.TopDisplayWindowValue().Should().Contain(TestContext.DataRow["Product"].ToString(), "we expected the product of the two numbers.");
       }

        [TestMethod]
        [DataSource("MyMultiplicationDataSource")]
        public void FrmShouldMultiply2NumbersExcelDriver()
        {
            // Download and install : https://www.microsoft.com/en-us/download/confirmation.aspx?id=23734
            
            /**
            If you are an application developer using OLEDB, set the Provider argument of the ConnectionString property to “Microsoft.ACE.OLEDB.12.0”. 
            If you are connecting to Microsoft Office Excel data, add the appropriate Extended Properties of the OLEDB connection string based on the Excel file type: 

            File Type (extension)                                       Extended Properties
            ---------------------------------------------------------------------------------------------
            Excel 97-2003 Workbook (.xls)                              "Excel 8.0"
            Excel 2007 Workbook (.xlsx)                                 "Excel 12.0 Xml"
            Excel 2007 Macro-enabled workbook (.xlsm)          "Excel 12.0 Macro"
            Excel 2007 Non-XML binary workbook (.xlsb)          "Excel 12.0"
             **/

            _calculatorScreen.EnterNumberIntoCalculator(Convert.ToInt32(TestContext.DataRow["FirstNumber"]));
            _calculatorScreen.MultiplyClick();
            _calculatorScreen.EnterNumberIntoCalculator(Convert.ToInt32(TestContext.DataRow["SecondNumber"]));
            _calculatorScreen.EqualsClick();

            _calculatorScreen.TopDisplayWindowValue().Should().Contain(TestContext.DataRow["Product"].ToString(), "we expected the product of the two numbers.");
        }

        [TestMethod]
        [DataSource("MySubtractionDataSource")]
        public void FrmShouldSubtract2NumbersExcelDriver()
        {
            _calculatorScreen.EnterNumberIntoCalculator(Convert.ToInt32(TestContext.DataRow["FirstNumber"]));
            _calculatorScreen.SubtractClick();
            _calculatorScreen.EnterNumberIntoCalculator(Convert.ToInt32(TestContext.DataRow["SecondNumber"]));
            _calculatorScreen.EqualsClick();

            _calculatorScreen.TopDisplayWindowValue().Should().Contain(TestContext.DataRow["Sum"].ToString(), "we expected the product of the two numbers.");
        }

        [TestMethod]
        [DataSource("MyDivisionDataSource")]
        public void FrmShouldDivide2NumbersExcelDriver()
        {
            _calculatorScreen.EnterNumberIntoCalculator(Convert.ToInt32(TestContext.DataRow["FirstNumber"]));
            _calculatorScreen.DivideClick();
            _calculatorScreen.EnterNumberIntoCalculator(Convert.ToInt32(TestContext.DataRow["SecondNumber"]));
            _calculatorScreen.EqualsClick();

            _calculatorScreen.TopDisplayWindowValue().Should().Contain(TestContext.DataRow["Quotient"].ToString(), "we expected the Quotient of the two numbers.");
        }
    }
}
