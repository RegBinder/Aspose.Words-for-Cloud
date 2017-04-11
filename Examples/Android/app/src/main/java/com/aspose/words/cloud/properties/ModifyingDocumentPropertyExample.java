package com.aspose.words.cloud.properties;

import java.io.File;

import com.aspose.storage.api.StorageApi; import android.content.Context;
import com.aspose.words.api.WordsApi;
import com.aspose.words.cloud.R;
import com.aspose.words.cloud.Utils;
import com.aspose.words.cloud.config.Configuration;
import com.aspose.words.model.DocumentProperty;
import com.aspose.words.model.DocumentPropertyResponse;

public class ModifyingDocumentPropertyExample {

	public static void execute(Context context) throws Exception {
		// ExStart: ModifyingDocumentPropertyExample

		try {
			// Instantiate Aspose Storage API SDK
			StorageApi storageApi = new StorageApi(Configuration.apiKey, Configuration.appSID, true);

			// Instantiate Aspose Words API SDK
			WordsApi wordsApi = new WordsApi(Configuration.apiKey, Configuration.appSID, true);

			// set input file name
			String fileName = "SampleWordDocument.docx";
			String propertyName = "Author";
			String storage = null;
			String folder = null;

			DocumentProperty body = new DocumentProperty();
			body.setName("Author");
			body.setValue("Farooq Sheikh");

			File input = Utils.stream2file("SampleWordDocument","docx", context.getResources().openRawResource(R.raw.docsample));


			// upload input file to aspose cloud storage
			storageApi.PutCreate(fileName, "", "", input);

			// invoke Aspose.Words Cloud SDK API to update document property by
			// given name from a word document
			DocumentPropertyResponse apiResponse = wordsApi.PutUpdateDocumentProperty(fileName, propertyName, fileName,
					storage, folder, body);

			if (apiResponse != null && apiResponse.getStatus().equals("OK")) {

				DocumentProperty docProperty = apiResponse.getDocumentProperty();

				if (docProperty != null) {
					// display updated document property info
					System.out.println(docProperty.getName() + "  :  " + docProperty.getValue());
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
		// ExEnd: ModifyingDocumentPropertyExample

	}

}
