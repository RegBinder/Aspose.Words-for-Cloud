﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.PutConvert
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class OnFlyDocumentConversionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PutConvert.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "On fly document conversion", "In order to reuse document content for various purposes (such as read-only PDF di" +
                    "stribution)\r\nA user should be able to convert Word document to different formats" +
                    "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "On fly document conversion")))
            {
                Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.PutConvert.OnFlyDocumentConversionFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void ConversionOnFly(string docName, string destFormat, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PutConvert"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conversion on fly", @__tags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("I have specified document {0} to send it in request body", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("I have specified format {0} document to be converted", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I execute conversion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("document is returned as an attachment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And(string.Format("attachment\'s format is {0}", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion on fly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        public virtual void ConversionOnFly_Variant0()
        {
            this.ConversionOnFly("TableDocument.doc", "pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion on fly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        public virtual void ConversionOnFly_Variant1()
        {
            this.ConversionOnFly("test_doc.docx", "pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion on fly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "png")]
        public virtual void ConversionOnFly_Variant2()
        {
            this.ConversionOnFly("test_doc.docx", "png", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion on fly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        public virtual void ConversionOnFly_Variant3()
        {
            this.ConversionOnFly("test_doc.docx", "html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion on fly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        public virtual void ConversionOnFly_Variant4()
        {
            this.ConversionOnFly("TableDocument.doc", "html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion on fly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "txt")]
        public virtual void ConversionOnFly_Variant5()
        {
            this.ConversionOnFly("TableDocument.doc", "txt", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion on fly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "htmlfixed")]
        public virtual void ConversionOnFly_Variant6()
        {
            this.ConversionOnFly("TableDocument.doc", "htmlfixed", ((string[])(null)));
        }
        
        public virtual void ConversionWithStorage(string docName, string destFormat, string outPath, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PutConvert"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Conversion with storage", @__tags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given(string.Format("I have specified document {0} to send it in request body", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And(string.Format("I have specified format {0} document to be converted", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.And(string.Format("I have specified output path {0}", outPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And(string.Format("There is no file {0} on storage", outPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("I execute conversion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then(string.Format("document {0} is existed on storage", outPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion with storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/putconvert/TableDocumentPdf.pdf")]
        public virtual void ConversionWithStorage_Variant0()
        {
            this.ConversionWithStorage("TableDocument.doc", "pdf", "out/putconvert/TableDocumentPdf.pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion with storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/putconvert/test_docPdf.pdf")]
        public virtual void ConversionWithStorage_Variant1()
        {
            this.ConversionWithStorage("test_doc.docx", "pdf", "out/putconvert/test_docPdf.pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion with storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "png")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/putconvert/test_docPng.png")]
        public virtual void ConversionWithStorage_Variant2()
        {
            this.ConversionWithStorage("test_doc.docx", "png", "out/putconvert/test_docPng.png", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion with storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/putconvert/test_docHtml.html")]
        public virtual void ConversionWithStorage_Variant3()
        {
            this.ConversionWithStorage("test_doc.docx", "html", "out/putconvert/test_docHtml.html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion with storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/putconvert/TableDocumentHtml.html")]
        public virtual void ConversionWithStorage_Variant4()
        {
            this.ConversionWithStorage("TableDocument.doc", "html", "out/putconvert/TableDocumentHtml.html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion with storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "txt")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/putconvert/TableDocumentTxt.txt")]
        public virtual void ConversionWithStorage_Variant5()
        {
            this.ConversionWithStorage("TableDocument.doc", "txt", "out/putconvert/TableDocumentTxt.txt", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Conversion with storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "htmlfixed")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:OutPath", "out/putconvert/TableDocumentHtmlfixed.htmlfixed")]
        public virtual void ConversionWithStorage_Variant6()
        {
            this.ConversionWithStorage("TableDocument.doc", "htmlfixed", "out/putconvert/TableDocumentHtmlfixed.htmlfixed", ((string[])(null)));
        }
        
        public virtual void ConvertDocumentUsingSpecifiedEncoding(string docName, string destFormat, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PutConvert"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Convert document using specified encoding", @__tags);
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
 testRunner.Given(string.Format("I have specified document {0} to send it in request body", docName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.And(string.Format("I have specified format {0} document to be converted", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.When("I execute conversion", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("document is returned as an attachment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.And(string.Format("attachment\'s format is {0}", destFormat), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document using specified encoding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 0")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        public virtual void ConvertDocumentUsingSpecifiedEncoding_Variant0()
        {
            this.ConvertDocumentUsingSpecifiedEncoding("TableDocument.doc", "pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document using specified encoding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "pdf")]
        public virtual void ConvertDocumentUsingSpecifiedEncoding_Variant1()
        {
            this.ConvertDocumentUsingSpecifiedEncoding("test_doc.docx", "pdf", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document using specified encoding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "png")]
        public virtual void ConvertDocumentUsingSpecifiedEncoding_Variant2()
        {
            this.ConvertDocumentUsingSpecifiedEncoding("test_doc.docx", "png", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document using specified encoding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "test_doc.docx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        public virtual void ConvertDocumentUsingSpecifiedEncoding_Variant3()
        {
            this.ConvertDocumentUsingSpecifiedEncoding("test_doc.docx", "html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document using specified encoding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "html")]
        public virtual void ConvertDocumentUsingSpecifiedEncoding_Variant4()
        {
            this.ConvertDocumentUsingSpecifiedEncoding("TableDocument.doc", "html", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document using specified encoding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "txt")]
        public virtual void ConvertDocumentUsingSpecifiedEncoding_Variant5()
        {
            this.ConvertDocumentUsingSpecifiedEncoding("TableDocument.doc", "txt", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Convert document using specified encoding")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "On fly document conversion")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("PutConvert")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Variant 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DocName", "TableDocument.doc")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DestFormat", "htmlfixed")]
        public virtual void ConvertDocumentUsingSpecifiedEncoding_Variant6()
        {
            this.ConvertDocumentUsingSpecifiedEncoding("TableDocument.doc", "htmlfixed", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
