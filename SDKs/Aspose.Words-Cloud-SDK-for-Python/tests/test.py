import unittest
import os.path
import json
import inspect
import requests

import asposewordscloud
from asposewordscloud.ApiClient import ApiClient
from asposewordscloud.WordsApi import WordsApi
from asposewordscloud.ApiClient import ApiException
from asposewordscloud.models import BookmarksResponse
from asposewordscloud.models import BookmarkResponse
from asposewordscloud.models import BookmarkData
from asposewordscloud.models import DocumentEntryList
from asposewordscloud.models import DocumentEntry
from asposewordscloud.models import DocumentResponse
from asposewordscloud.models import PageNumber
from asposewordscloud.models import LoadWebDocumentData
from asposewordscloud.models import SaveOptionsData
from asposewordscloud.models import SaveResponse
from asposewordscloud.models import SplitDocumentResponse
from asposewordscloud.models import ResponseMessage
from asposewordscloud.models import WatermarkText
from asposewordscloud.models import ReplaceTextRequest
from asposewordscloud.models import ReplaceTextResponse
from asposewordscloud.models import TextItemsResponse
from asposewordscloud.models import SectionLinkCollectionResponse
from asposewordscloud.models import SectionPageSetupResponse
from asposewordscloud.models import SectionResponse
from asposewordscloud.models import PageSetup
from asposewordscloud.models import RevisionsModificationResponse
from asposewordscloud.models import Font
from asposewordscloud.models import FontResponse
from asposewordscloud.models import ParagraphLinkCollectionResponse
from asposewordscloud.models import RunResponse
from asposewordscloud.models import ParagraphResponse
from asposewordscloud.models import HyperlinksResponse
from asposewordscloud.models import HyperlinkResponse
from asposewordscloud.models import SaaSposeResponse
from asposewordscloud.models import DrawingObjectsResponse
from asposewordscloud.models import StatDataResponse
from asposewordscloud.models import TiffSaveOptionsData
from asposewordscloud.models import ProtectionDataResponse
from asposewordscloud.models import ProtectionRequest
from asposewordscloud.models import DocumentPropertiesResponse
from asposewordscloud.models import DocumentPropertyResponse
from asposewordscloud.models import DocumentProperty
from asposewordscloud.models import FieldNamesResponse
from asposewordscloud.models import FormField
from asposewordscloud.models import FormFieldResponse

from asposestoragecloud.ApiClient import ApiClient as StorageApiClient
from asposestoragecloud.StorageApi import StorageApi
from asposestoragecloud.models import ResponseMessage as StorageResponseMessage


class TestAsposeCloudWords(unittest.TestCase):

    def setUp(self):

        with open('setup.json') as json_file:
            data = json.load(json_file)

        self.storageApiClient = StorageApiClient(apiKey=str(data['app_key']),appSid=str(data['app_sid']),debug=True,apiServer=str(data['product_uri']))
        self.storageApi = StorageApi(self.storageApiClient)

        self.apiClient = ApiClient(apiKey=str(data['app_key']), appSid=str(data['app_sid']), debug=True,
                                   apiServer=str(data['product_uri']))
        self.wordsApi = WordsApi(self.apiClient)

        self.output_path = str(data['output_location'])

    def test_PostUpdateDocumentBookmark(self):

        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            bookmarkData = BookmarkData.BookmarkData()
            bookmarkData.Name = 'aspose'
            bookmarkData.Text = 'Bookmark is very good'

            response = self.wordsApi.PostUpdateDocumentBookmark('SampleWordDocument.docx', 'aspose', bookmarkData)

            self.assertIsInstance(response, BookmarkResponse.BookmarkResponse)
            self.assertEqual(response.Status, 'OK')

        except ApiException as ex:
            print
            "Exception"
            print
            "Code: " + str(ex.code)
            print
            "Mesage: " + ex.message
            raise ex

    def test_GetDocumentBookmarkByName(self):

        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentBookmarkByName('SampleWordDocument.docx', 'aspose')

            self.assertIsInstance(response, BookmarkResponse.BookmarkResponse)
            self.assertEqual(response.Status, 'OK')

        except ApiException as ex:
            print
            "Exception"
            print
            "Code: " + str(ex.code)
            print
            "Mesage: " + ex.message
            raise ex

    def test_GetDocumentBookmarks(self):

        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')
            response = self.wordsApi.GetDocumentBookmarks('SampleWordDocument.docx')

            self.assertIsInstance(response, BookmarksResponse.BookmarksResponse)
            self.assertEqual(response.Status, 'OK')
        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocument(self):

        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')
            response = self.wordsApi.GetDocument('SampleWordDocument.docx')

            self.assertIsInstance(response, DocumentResponse.DocumentResponse)
            self.assertEqual(response.Status, 'OK')

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentWithFormat(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')
            response = self.wordsApi.GetDocumentWithFormat('SampleWordDocument.docx', 'pdf')

            self.assertEqual(response.Status, 'OK')

            with open("./output/" + 'SampleWordDocument.pdf', 'wb') as f:
                for chunk in response.InputStream:
                    f.write(chunk)

            self.assertTrue(True, os.path.exists("./output/" + 'SampleWordDocument.pdf'))

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostAppendDocument(self):
        try:

            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')
            response = self.storageApi.PutCreate('SampleAppendDoc.docx', '../../../Data/SampleAppendDoc.docx')
            response = self.storageApi.PutCreate('SampleAppendDoc2.docx', '../../../Data/SampleAppendDoc2.docx')

            document1 = DocumentEntry.DocumentEntry()
            document1.Href = 'SampleAppendDoc.docx'
            document1.ImportFormatMode = 'KeepSourceFormatting'

            document2 = DocumentEntry.DocumentEntry()
            document2.Href = 'SampleAppendDoc2.docx'
            document2.ImportFormatMode = 'KeepSourceFormatting'

            documentList = DocumentEntryList.DocumentEntryList()
            documentList.DocumentEntries = [document1, document2]

            response = self.wordsApi.PostAppendDocument('SampleWordDocument.docx', documentList)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostInsertPageNumbers(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            pagenumber = PageNumber.PageNumber()
            pagenumber.Format = '{PAGE} of {NUMPAGES}'
            pagenumber.Alignment = 'center'

            response = self.wordsApi.PostInsertPageNumbers('SampleWordDocument.docx', pagenumber)
            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostLoadWebDocument(self):
        try:

            loadWebDocumentData = LoadWebDocumentData.LoadWebDocumentData()
            loadWebDocumentData.LoadingDocumentUrl = 'http://google.com'

            saveOptions = SaveOptionsData.SaveOptionsData()
            saveOptions.SaveFormat = 'doc'
            saveOptions.FileName = 'google.doc'

            loadWebDocumentData.SaveOptions = saveOptions

            response = self.wordsApi.PostLoadWebDocument(loadWebDocumentData)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaveResponse.SaveResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostSplitDocument(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')
            response = self.wordsApi.PostSplitDocument('SampleWordDocument.docx', format='text', ffrom=1, to=2,
                                                       zipOutput=False)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SplitDocumentResponse.SplitDocumentResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PutConvertDocument(self):
        try:
            response = self.wordsApi.PutConvertDocument('../../../Data/SampleWordDocument.docx', format='pdf')

            self.assertEqual(response.Status, 'OK')

            with open("./output/" + 'SampleWordDocument.pdf', 'wb') as f:
                f.write(response.InputStream)

            self.assertTrue(True, os.path.exists("./output/" + 'SampleWordDocument.pdf'))

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostInsertWatermarkText(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertWatermarkText('SampleWordDocument.docx', watermarkText)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostInsertDocumentWatermarkText(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertDocumentWatermarkText('SampleWordDocument.docx', watermarkText)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostInsertWatermarkImage(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertWatermarkImage('SampleWordDocument.docx',
                                                              '../../../Data/aspose-words.png')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostInsertDocumentWatermarkImage(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertDocumentWatermarkImage('SampleWordDocument.docx',
                                                                      '../../../Data/aspose-words.png')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print
            "Exception"
            print
            "Code: " + str(ex.code)
            print
            "Mesage: " + ex.message
            raise ex

    def test_PostReplaceText(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            replaceText = ReplaceTextRequest.ReplaceTextRequest()
            replaceText.OldValue = 'Times New Roman'
            replaceText.NewValue = 'Arial Black'

            response = self.wordsApi.PostReplaceText('SampleWordDocument.docx', replaceText)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, ReplaceTextResponse.ReplaceTextResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentTextItems(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentTextItems('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, TextItemsResponse.TextItemsResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetSections(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetSections('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SectionLinkCollectionResponse.SectionLinkCollectionResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetSectionPageSetup(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetSectionPageSetup('SampleWordDocument.docx', 0)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SectionPageSetupResponse.SectionPageSetupResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetSection(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetSection('SampleWordDocument.docx', 0)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SectionResponse.SectionResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_UpdateSectionPageSetup(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            pageSetup = PageSetup.PageSetup()
            pageSetup.RtlGutter = True
            pageSetup.LeftMargin = 10.0
            pageSetup.Orientation = 'Landscape'
            pageSetup.PaperSize = 'A5'

            response = self.wordsApi.UpdateSectionPageSetup('SampleWordDocument.docx', 0, pageSetup)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SectionPageSetupResponse.SectionPageSetupResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_RejectAllRevisions(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.RejectAllRevisions('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, RevisionsModificationResponse.RevisionsModificationResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_AcceptAllRevisions(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.AcceptAllRevisions('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, RevisionsModificationResponse.RevisionsModificationResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostDocumentParagraphRunFont(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            font = Font.Font()
            font.Name = "Arial"
            font.Bold = True

            response = self.wordsApi.PostDocumentParagraphRunFont('SampleWordDocument.docx', 0, 0, font)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, FontResponse.FontResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentParagraphs(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentParagraphs('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, ParagraphLinkCollectionResponse.ParagraphLinkCollectionResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentParagraphRunFont(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentParagraphRunFont('SampleWordDocument.docx', 0, 0)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, FontResponse.FontResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentParagraphRun(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentParagraphRun('SampleWordDocument.docx', 0, 0)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, RunResponse.RunResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentParagraph(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentParagraph('SampleWordDocument.docx', 1)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, ParagraphResponse.ParagraphResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentHyperlinks(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentHyperlinks('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, HyperlinksResponse.HyperlinksResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentHyperlinkByIndex(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentHyperlinkByIndex('SampleWordDocument.docx', 0)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, HyperlinkResponse.HyperlinkResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_DeleteHeadersFooters(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.DeleteHeadersFooters('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaaSposeResponse.SaaSposeResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentDrawingObjects(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentDrawingObjects('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DrawingObjectsResponse.DrawingObjectsResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentDrawingObjectOleData(self):
        try:
            response = self.storageApi.PutCreate('sample_EmbeddedOLE.docx', '../../../Data/sample_EmbeddedOLE.docx')

            response = self.wordsApi.GetDocumentDrawingObjectOleData('sample_EmbeddedOLE.docx', 0)

            print
            inspect.getmembers(response)

            self.assertEqual(response.Status, 'OK')

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentDrawingObjectImageData(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentDrawingObjectImageData('SampleWordDocument.docx', 1)

            self.assertEqual(response.Status, 'OK')

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentDrawingObjectByIndexWithFormat(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentDrawingObjectByIndexWithFormat('SampleWordDocument.docx', 1, 'jpg')

            self.assertEqual(response.Status, 'OK')

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentDrawingObjectByIndex(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentDrawingObjectByIndex('SampleWordDocument.docx', 1)

            self.assertEqual(response.Status, 'OK')

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_DeleteDocumentWatermark(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertWatermarkText('SampleWordDocument.docx', watermarkText)

            response = self.wordsApi.DeleteDocumentWatermark('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentStatistics(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentStatistics('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, StatDataResponse.StatDataResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PutDocumentSaveAsTiff(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            tiffSaveOptions = TiffSaveOptionsData.TiffSaveOptionsData()
            tiffSaveOptions.FileName = 'SampleWordDocument.tiff'
            tiffSaveOptions.SaveFormat = 'tiff'

            response = self.wordsApi.PutDocumentSaveAsTiff('SampleWordDocument.docx', tiffSaveOptions)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaveResponse.SaveResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostDocumentSaveAs(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            saveOptions = SaveOptionsData.SaveOptionsData()
            saveOptions.FileName = 'SampleWordDocument.pdf'
            saveOptions.SaveFormat = 'pdf'

            response = self.wordsApi.PostDocumentSaveAs('SampleWordDocument.docx', saveOptions)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaveResponse.SaveResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PutProtectDocument(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            protectionData = ProtectionRequest.ProtectionRequest()
            protectionData.Password = 'hello123'

            response = self.wordsApi.PutProtectDocument('SampleWordDocument.docx', protectionData)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, ProtectionDataResponse.ProtectionDataResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostChangeDocumentProtection(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            protectionData = ProtectionRequest.ProtectionRequest()
            protectionData.Password = 'hello123'

            response = self.wordsApi.PutProtectDocument('SampleWordDocument.docx', protectionData)

            protectionData_new = ProtectionRequest.ProtectionRequest()
            protectionData_new.NewPassword = "Hello223"

            response = self.wordsApi.PostChangeDocumentProtection('SampleWordDocument.docx', protectionData_new)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, ProtectionDataResponse.ProtectionDataResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentProtection(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentProtection('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, ProtectionDataResponse.ProtectionDataResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_DeleteUnprotectDocument(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            protectionData = ProtectionRequest.ProtectionRequest()
            protectionData.Password = 'hello123'

            response = self.wordsApi.PutProtectDocument('SampleWordDocument.docx', protectionData)

            protectionData.Password = None

            response = self.wordsApi.DeleteUnprotectDocument('SampleWordDocument.docx', protectionData)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, ProtectionDataResponse.ProtectionDataResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentProperties(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentProperties('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentPropertiesResponse.DocumentPropertiesResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentProperty(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentProperty('SampleWordDocument.docx', 'Author')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentPropertyResponse.DocumentPropertyResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_GetDocumentFieldNames(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentFieldNames('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, FieldNamesResponse.FieldNamesResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PutUpdateDocumentProperty(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            property = DocumentProperty.DocumentProperty()
            property.Name = 'Author'
            property.Value = 'Assad'

            response = self.wordsApi.PutUpdateDocumentProperty('SampleWordDocument.docx', 'Author', property)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentPropertyResponse.DocumentPropertyResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_DeleteDocumentProperty(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            property = DocumentProperty.DocumentProperty()
            property.Name = 'Provider'
            property.Value = 'Assad'

            response = self.wordsApi.PutUpdateDocumentProperty('SampleWordDocument.docx', 'Provider', property)

            response = self.wordsApi.DeleteDocumentProperty('SampleWordDocument.docx', 'Provider')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaaSposeResponse.SaaSposeResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_DeleteSectionParagraphFields(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.DeleteSectionParagraphFields('SampleWordDocument.docx', 0, 0)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaaSposeResponse.SaaSposeResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_DeleteSectionFields(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.DeleteSectionFields('SampleWordDocument.docx', 0)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaaSposeResponse.SaaSposeResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_DeleteParagraphFields(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.DeleteParagraphFields('SampleWordDocument.docx', 0)

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaaSposeResponse.SaaSposeResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_DeleteDocumentMacros(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx', '../../../Data/SampleWordDocument.docx')

            response = self.wordsApi.DeleteDocumentMacros('SampleWordDocument.docx')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, SaaSposeResponse.SaaSposeResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PutExecuteMailMergeOnline(self):
        try:
            response = self.wordsApi.PutExecuteMailMergeOnline(False, '../../../Data/SampleExecuteTemplate.doc',
                                                               '../../../Data/SampleExecuteTemplateData.txt')

            self.assertEqual(response.Status, 'OK')

            with open("./output/" + 'SampleExecuteTemplateMerged.doc', 'wb') as f:
                for chunk in response.InputStream:
                    f.write(chunk)

            self.assertTrue(True, os.path.exists("./output/" + 'SampleExecuteTemplateMerged.doc'))

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex

    def test_PostDocumentExecuteMailMerge(self):
        try:
            response = self.storageApi.PutCreate('aspose-words.png', '../../../Data/aspose-words.png')
            response = self.storageApi.PutCreate('SampleMailMergeTemplateImage.doc',
                                                 '../../../Data/SampleMailMergeTemplateImage.doc')
            response = self.wordsApi.PostDocumentExecuteMailMerge('SampleMailMergeTemplateImage.doc', False,
                                                                  '../../../Data/SampleMailMergeTemplateImageData.txt')

            self.assertEqual(response.Status, 'OK')
            self.assertIsInstance(response, DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print("Exception")
            print("Code: " + str(ex.code))
            print("Mesage: " + ex.message)
            raise ex