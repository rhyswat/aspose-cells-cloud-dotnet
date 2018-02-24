/* 
 * Web API Swagger specification
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Aspose.Cells.Cloud.SDK.Client;
using Aspose.Cells.Cloud.SDK.Api;
using Aspose.Cells.Cloud.SDK.Model;

namespace Aspose.Cells.Cloud.SDK.Test
{
    /// <summary>
    ///  Class for testing CellsConditionalFormattingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CellsConditionalFormattingsApiTests:CellsBaseTest
    {
        private CellsConditionalFormattingsApi instance;
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new CellsConditionalFormattingsApi(GetConfiguration());
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CellsConditionalFormattingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CellsConditionalFormattingsApi
            Assert.IsInstanceOf(typeof(CellsConditionalFormattingsApi), instance, "instance is a CellsConditionalFormattingsApi");
        }

        
        /// <summary>
        /// Test CellsConditionalFormattingsDeleteWorksheetConditionalFormatting
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsDeleteWorksheetConditionalFormattingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsDeleteWorksheetConditionalFormatting(name, sheetName, index, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsConditionalFormattingsDeleteWorksheetConditionalFormattingArea
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsDeleteWorksheetConditionalFormattingAreaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? startRow = 1;
            int? startColumn = 1;
            int? totalRows = 4;
            int? totalColumns = 6;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsDeleteWorksheetConditionalFormattingArea(name, sheetName, startRow, startColumn, totalRows, totalColumns, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsConditionalFormattingsDeleteWorksheetConditionalFormattings
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsDeleteWorksheetConditionalFormattingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsDeleteWorksheetConditionalFormattings(name, sheetName, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsConditionalFormattingsGetWorksheetConditionalFormatting
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsGetWorksheetConditionalFormattingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsGetWorksheetConditionalFormatting(name, sheetName, index, folder);
            Assert.IsInstanceOf<ConditionalFormattingResponse>(response, "response is ConditionalFormattingResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsConditionalFormattingsGetWorksheetConditionalFormattings
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsGetWorksheetConditionalFormattingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsGetWorksheetConditionalFormattings(name, sheetName, folder);
            Assert.IsInstanceOf<ConditionalFormattingsResponse>(response, "response is ConditionalFormattingsResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsConditionalFormattingsPutWorksheetConditionalFormatting
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsPutWorksheetConditionalFormattingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            string cellArea = CELLAREA;
            FormatCondition formatcondition = new FormatCondition();//null,null, "CellValue",null,null,null,null,"v1","v2",null, "Between"
            formatcondition.Type = "CellValue";
            formatcondition._Operator = "Between";
            formatcondition.Formula1 = "v1";
            formatcondition.Formula2 = "v2";
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsPutWorksheetConditionalFormatting(name, sheetName, cellArea, formatcondition, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsConditionalFormattingsPutWorksheetFormatCondition
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsPutWorksheetFormatConditionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string cellArea = CELLAREA;
            string type = "CellValue";
            string operatorType = "Between";
            string formula1 = "v1";
            string formula2 = "v2";
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsPutWorksheetFormatCondition(name, sheetName, index, cellArea, type, operatorType, formula1, formula2, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsConditionalFormattingsPutWorksheetFormatConditionArea
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsPutWorksheetFormatConditionAreaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string cellArea = CELLAREA;
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsPutWorksheetFormatConditionArea(name, sheetName, index, cellArea, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
        /// <summary>
        /// Test CellsConditionalFormattingsPutWorksheetFormatConditionCondition
        /// </summary>
        [Test]
        public void CellsConditionalFormattingsPutWorksheetFormatConditionConditionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string name = BOOK1;
            string sheetName = SHEET1;
            int? index = 0;
            string type = "CellValue";
            string operatorType = "Between";
            string formula1 = "v1";
            string formula2 = "v2";
            string folder = TEMPFOLDER;
            UpdateDataFile(folder, name);
            var response = instance.CellsConditionalFormattingsPutWorksheetFormatConditionCondition(name, sheetName, index, type, operatorType, formula1, formula2, folder);
            Assert.IsInstanceOf<SaaSposeResponse>(response, "response is SaaSposeResponse");
            Assert.AreEqual(response.Code, 200);
        }
        
    }

}