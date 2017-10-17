﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WordDocumentRequestSteps.cs">
//   Copyright (c) 2016 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Steps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for working with <see cref="IWordDocumentRequest"/>.
    /// </summary>
    [Binding]
    public class WordDocumentRequestSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WordDocumentRequestSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected WordDocumentRequestSteps(BaseContext context)
        {
            this.context = context;
        }

        private IWordDocumentRequest Request
        {
            get
            {             
                return ScenarioContext.Current["Request"] as IWordDocumentRequest;
            }
        }

        /// <summary>
        /// Sets document name we would like to use.
        /// </summary>
        /// <param name="fileName">document name</param>
        [Given(@"I have specified document name (.*) in URL")]
        public void GivenIHaveSpecifiedDocumentNameInUrl(string fileName)
        {
            this.Request.Name = fileName;
        }

        /// <summary>
        /// Sets encoding for conversion
        /// </summary>
        /// <param name="encoding">encoding</param>
        [Given(@"I have specified encoding (.*)")]
        public void GivenIHaveSpecifiedEncoding(string encoding)
        {
            this.Request.LoadEncoding = encoding;
        }
    }
}