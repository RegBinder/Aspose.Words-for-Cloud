// ExStart:1
var fs = require('fs');
var assert = require('assert');
var StorageApi = require('asposestoragecloud');
var WordsApi = require('asposewordscloud');
var configProps = require('../Config/config.json');
var data_path = '../../../Data/';

var AppSID = configProps.app_sid;
var AppKey = configProps.api_key;
var config = {'appSid':AppSID,'apiKey':AppKey , 'debug' : true};

// Instantiate Aspose Storage API SDK
var storageApi = new StorageApi(config);
// Instantiate Aspose Words API SDK
var wordsApi = new WordsApi(config);

// Set input file name
var name = "SampleWordDocument.docx";
var index = 1;
var runIndex = 0;
var fontBody = {
		'Bold' : true,
		'Size' : 31.0,
		'Name' : 'Calibri'
		};

try {
// Upload source file to aspose cloud storage
storageApi.PutCreate(name, versionId=null, storage=null, file= data_path + name , function(responseMessage) {

	assert.equal(responseMessage.status, 'OK');

	// Invoke Aspose.Words Cloud SDK API to update font of a specific run of a paragraph present in a word document
	wordsApi.PostDocumentParagraphRunFont(name, index, runIndex, null, null, null, fontBody, function(responseMessage) {
			assert.equal(responseMessage.status, 'OK');
			console.log("paragraph run font has been updated successfully");
			
			// Download updated document from storage server
			storageApi.GetDownload(name, null, null, function(responseMessage) {
				assert.equal(responseMessage.status, 'OK');
				var outfilename = 'updated-' + name;
				var writeStream = fs.createWriteStream(data_path + outfilename);
				writeStream.write(responseMessage.body);
				});
			});
	});

}catch (e) {
  console.log("exception in example");
  console.log(e);
}
//ExEnd:1