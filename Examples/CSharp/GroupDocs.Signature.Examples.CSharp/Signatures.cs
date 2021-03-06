﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDocs.Signature.Config;
using GroupDocs.Signature.Options;
using GroupDocs.Signature.Handler;
using System.IO;
using GroupDocs.Signature.Handler.Input;
using GroupDocs.Signature.Handler.Output;
using GroupDocs.Signature.Domain;
using System.Drawing;
using System.Drawing.Imaging;

namespace GroupDocs.Signature.Examples.CSharp
{
    class Signatures
    {
        #region WorkingWithTextSignature

        /// <summary>
        /// Signing a pdf document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignPdfDocumentWithText(string fileName)
        {
            //ExStart:signingandsavingpdfdocumentwithtext
            float size = 100;
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options 
            var signOptions = new PdfSignTextOptions("coca cola");
            signOptions.Left = 100;
            signOptions.Top = 100;
            //this feature is supported in 16.12.0
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            //---------------------------
            signOptions.ForeColor = System.Drawing.Color.Red;
            signOptions.BackgroundColor = System.Drawing.Color.Black;
            signOptions.Font = new Domain.SignatureFont { FontSize = size, FontFamily = "Comic Sans MS" };
            string fileExtension = Path.GetExtension(fileName);
            // save document
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingpdfdocumentwithtext
        }

        /// <summary>
        /// Signing a cell document with text
        /// </summary>
        /// <param name="fileName">Name of the input filel</param>
        public static void SignCellDocumentWithText(string fileName)
        {
            //ExStart:signingandsavingcellsdocumentwithtext
            float size = 100;
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options
            var signOptions = new CellsSignTextOptions("coca cola");
            // text position
            signOptions.RowNumber = 3;
            signOptions.ColumnNumber = 6;
            // text rectangle size
            signOptions.Height = 100;
            signOptions.Width = 100;
            //this feature is supported in 16.12.0
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            //----------------------------
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = false;
            signOptions.ForeColor = System.Drawing.Color.Red;
            signOptions.BackgroundColor = System.Drawing.Color.Black;
            signOptions.BorderColor = System.Drawing.Color.Green;
            signOptions.Font = new Domain.SignatureFont { FontSize = size, FontFamily = "Comic Sans MS" };
            // sign first sheet
            signOptions.SheetNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingcellsdocumentwithtext
        }

        /// <summary>
        /// Signing a slide document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentWithText(string fileName)
        {
            //ExStart:signingandsavingslidesdocumentwithtext
            SignatureConfig config = Utilities.GetConfigurations();
            float size = 100;
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options 
            var signOptions = new SlidesSignTextOptions("coca cola");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            //this feature is supported in 16.12.0
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            //----------------------------
            signOptions.ForeColor = System.Drawing.Color.Red;
            signOptions.BackgroundColor = System.Drawing.Color.Black;
            signOptions.BorderColor = System.Drawing.Color.Green;
            signOptions.Font = new Domain.SignatureFont { FontSize = size, FontFamily = "Comic Sans MS" };
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingslidesdocumentwithtext
        }

        /// <summary>
        /// Signing a word document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentWithText(string fileName)
        {
            //ExStart:signingandsavingworddocumentwithtext
            float size = 5;
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options
            var signOptions = new WordsSignTextOptions("coca cola");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            //this feature is supported in 16.12.0
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            //----------------------------
            signOptions.ForeColor = System.Drawing.Color.Red;
            signOptions.BackgroundColor = System.Drawing.Color.Black;
            signOptions.BorderColor = System.Drawing.Color.Green;
            signOptions.Font = new Domain.SignatureFont { FontSize = size, FontFamily = "Comic Sans MS" };
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingworddocumentwithtext
        }

        #endregion

        #region WorkingWithImageSignature

        /// <summary>
        /// Signing a pdf document with image
        /// </summary>
        /// <param name="fileName">Name of the input filed</param>
        public static void SignPdfDocumentWithImage(string fileName)
        {
            //ExStart:signingandsavingpdfdocumentwithimage
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new PdfSignImageOptions("sign.png");
            // image position
            signOptions.Left = 300;
            signOptions.Top = 200;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Left;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingpdfdocumentwithimage
        }

        /// <summary>
        /// Signing a cell document with image
        /// </summary>
        /// <param name="fileName">Name of the inut file</param>
        public static void SignCellDocumentWithImage(string fileName)
        {
            //ExStart:signingandsavingcelldocumentwithimage
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new CellsSignImageOptions("sign.png");
            // image position
            signOptions.RowNumber = 10;
            signOptions.ColumnNumber = 10;
            signOptions.SignAllPages = true;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 8 };
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingcelldocumentwithimage
        }

        /// <summary>
        /// Signing a slide document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentWithImage(string fileName)
        {
            //ExStart:signingandsavingslidedocumentwithimage
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new SlidesSignImageOptions("sign.png");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 15 };
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingslidedocumentwithimage
        }

        /// <summary>
        /// Signing word document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentWithImage(string fileName)
        {
            //ExStart:signingandsavingworddocumentwithimage
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new WordsSignImageOptions("sign.png");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 500 };
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Right;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingworddocumentwithimage
        }

        /// <summary>
        /// Setting Opacity to Image Signature appearance for Words Documents
        /// Feature is supported by version 17.03 or greater
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SetOpacityImageSignature(string fileName)
        {
            //ExStart:SetOpacityImageSignature
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(signConfig);
            //setup size and position
            WordsSignImageOptions signOptions = new WordsSignImageOptions("signature.jpg");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 200;
            signOptions.Height = 200;
            // setup rotation
            signOptions.RotationAngle = 48;
            // setup opacity
            signOptions.Opacity = 0.28;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Words_Image_Rotation_Opacity" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SetOpacityImageSignature
        }

        #endregion

        #region WorkingWithDigitalSignatures

        /// <summary>
        /// Signing a cell document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignCellDocumentDigitally(string fileName)
        {
            //ExStart:signingcelldocumentwithdigitalcertificate
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            //Image appearance, opacity and rotation are supported starting from version 17.03
            // FileStream blocks opened file while it is not disposed so, before 
            // using .pfx file for another purposes FileStream should be disposed
            Stream certificateStream = new FileStream("Ali.pfx",
                FileMode.Open);
            // setup digital signature options with image appearance
            CellsSignDigitalOptions signOptions = new CellsSignDigitalOptions(certificateStream, "signature.jpg");
            signOptions.Signature.Comments = "Test comment";
            signOptions.Signature.SignTime = new DateTime(2017, 1, 25, 10, 41, 54);
            signOptions.Password = "1234567890";
            // setup opacity and rotation
            signOptions.Opacity = 0.48;
            signOptions.RotationAngle = 45;
            //put image signature only on the last page
            signOptions.PagesSetup.LastPage = true;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions
                {
                    OutputType = OutputType.String,
                    OutputFileName = "SignedForVerification"
                });
            //File stream must be disposed after signing
            certificateStream.Dispose();
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:signingcelldocumentwithdigitalcertificate
        }

        /// <summary>
        /// Signing a pdf document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignPdfDocumentDigitally(string fileName)
        {
            //ExStart:signingpdfdocumentwithdigitalcertificate
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new PdfSignDigitalOptions("acer.pfx", "sign.png");
            signOptions.Password = null;
            // image position
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.Visible = true;
            signOptions.SignAllPages = true;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingpdfdocumentwithdigitalcertificate
        }

        /// <summary>
        /// Signing a word document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentDigitally(string fileName)
        {
            //ExStart:signingworddocumentwithdigitalcertificate
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new WordsSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingworddocumentwithdigitalcertificate
        }

        /// <summary>
        /// Signing a slide document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentDigitally(string fileName)
        {
            //ExStart:signingslidedocumentwithdigitalcertificate
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new SlidesSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 2;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingslidedocumentwithdigitalcertificate
        }

        #endregion

        #region Azure

        /// <summary>
        /// Custom input handling 
        /// </summary>
        /// <param name="inputFileName">Name of the input file</param>
        public static void CustomInputHandler(string inputFileName)
        {
            //ExStart:custominputhandler
            const string DevStorageEmulatorUrl = "http://127.0.0.1:10000/devstoreaccount1/";
            const string DevStorageEmulatorAccountName = "devstoreaccount1";
            const string DevStorageEmulatorAccountKey =
                "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==";

            SignatureConfig config = Utilities.GetConfigurations();

            // instantiating the signature handler
            var handler = new SignatureHandler(config);

            SaveOptions saveOptions = new SaveOptions(OutputType.String);
            IInputDataHandler customInputStorageProvider = new AzureInputDataHandler(DevStorageEmulatorUrl,
                DevStorageEmulatorAccountName, DevStorageEmulatorAccountKey, "testbucket");
            SignatureHandler handlerWithCustomStorage = new SignatureHandler(config, customInputStorageProvider);

            // setup image signature options
            var signOptions = new PdfSignImageOptions("sign.png");
            signOptions.DocumentPageNumber = 1;
            signOptions.Top = 500;
            signOptions.Width = 200;
            signOptions.Height = 100;
            string fileExtension = Path.GetExtension(inputFileName);
            Utilities.SaveFile(fileExtension, inputFileName, handler, null, signOptions, null);
            //ExEnd:custominputhandler
        }

        /// <summary>
        /// Custome output handling
        /// </summary>
        /// <param name="inputFileName">Name of the input file</param>
        public static void CustomOutputHandler(string inputFileName)
        {
            //ExStart:customoutputhandler
            const string DevStorageEmulatorUrl = "http://127.0.0.1:10000/devstoreaccount1/";
            const string DevStorageEmulatorAccountName = "devstoreaccount1";
            const string DevStorageEmulatorAccountKey =
                "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==";

            SignatureConfig config = Utilities.GetConfigurations();

            // instantiating the signature handler
            var handler = new SignatureHandler(config);

            SaveOptions saveOptions = new SaveOptions(OutputType.String);
            IOutputDataHandler customOutputStorageProvider = new AzureOutputDataHandler(
                DevStorageEmulatorUrl, DevStorageEmulatorAccountName, DevStorageEmulatorAccountKey, "tempbucket");
            SignatureHandler handlerWithCustomStorage = new SignatureHandler(config, customOutputStorageProvider);
            // setup image signature options
            var signOptions = new PdfSignImageOptions("sign.png");
            signOptions.DocumentPageNumber = 1;
            signOptions.Top = 500;
            signOptions.Width = 200;
            signOptions.Height = 100;
            string fileExtension = Path.GetExtension(inputFileName);
            Utilities.SaveFile(fileExtension, inputFileName, handler, null, signOptions, null);
            //ExEnd:customoutputhandler
        }

        #endregion

        #region OpenPasswordProtectedDocuments
        public static void GetPasswordProtectedDocs(string fileName)
        {
            //ExStart:GetPasswordProtectedDocs
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            var signOptions = new WordsSignTextOptions("John Smith");
            // specify load options
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.Password = "1234567890";
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:GetPasswordProtectedDocs
        }

        /// <summary>
        /// Shows how to manipulate password i-e open protected doc,change password etc with SaveOptions
        /// Feature is supported in version 17.04 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void ManipulatePasswordWithSaveOptions(string fileName)
        {
            try
            {
                //ExStart:ManipulatePasswordWithSaveOptions
                // setup Signature configuration
                SignatureConfig config = Utilities.GetConfigurations();
                string password_1 = "1234567890";
                string password_2 = "0987654321";

                // instantiating the signature handler
                var handler = new SignatureHandler(config);
                // setup options with text of signature
                SignOptions signOptions = new CellsSignTextOptions("John Smith");
                // specify load options
                LoadOptions loadOptions = new LoadOptions();
                // specify save options
                SaveOptions saveOptions = new SaveOptions { OutputType = OutputType.String };

                //Sign document and save it without password
                //Set signed document name
                saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_WithoutPassword";
                string signedDocumentWithoutPassword = handler.Sign<string>(fileName, signOptions, loadOptions, saveOptions);

                //Since we'll be using the documents created during code execution during next steps, so we'll use the output path in the configurations
                config.StoragePath = Utilities.outputPath;
                //Sign document and save it with new password
                //Set signed document name
                saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_NewPassword";
                //Add password to save options
                saveOptions.Password = password_1;
                //Sign document with new password
                string signedDocumentWithPassword = handler.Sign<string>(Path.GetFileName(signedDocumentWithoutPassword), signOptions, loadOptions, saveOptions);

                //Sign document and save it with original password
                //Set signed document name
                saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_OriginalPassword";
                //Add password to load options to have ability to open document
                loadOptions.Password = password_1;
                //Set saveOptions to use password from loadOptions
                saveOptions.UseOriginalPassword = true;
                saveOptions.Password = String.Empty;
                //Sign document with original password
                string signedDocumentWithOriginalPassword = handler.Sign<string>(Path.GetFileName(signedDocumentWithPassword), signOptions, loadOptions, saveOptions);

                //Sign document and save it with another password
                //Set signed document name
                saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_AnotherPassword";
                //Add password to load options to have ability to open document
                loadOptions.Password = password_1;
                //Set saveOptions to use another password
                saveOptions.UseOriginalPassword = false;
                saveOptions.Password = password_2;
                //Sign document with another password
                string signedDocumentWithAnotherPassword = handler.Sign<string>(Path.GetFileName(signedDocumentWithOriginalPassword), signOptions, loadOptions, saveOptions);

                //Sign document and save it without password
                //Set signed document name
                saveOptions.OutputFileName = "WorkWithPasswordProtectedDocuments_RemovedPassword";
                //Add password to load options to have ability to open document
                loadOptions.Password = password_2;
                //Set saveOptions with empty password
                saveOptions.UseOriginalPassword = false;
                saveOptions.Password = String.Empty;
                //Sign document with removed password
                string signedDocumentWithRemovedPassword = handler.Sign<string>(Path.GetFileName(signedDocumentWithAnotherPassword), signOptions, loadOptions, saveOptions);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("ERROR processing the examples.\n\n" + ex.Message);
            }
            //ExEnd:ManipulatePasswordWithSaveOptions
        }
        #endregion

        #region SaveTextSignedOutputWithFormatOptions

        /// <summary>
        /// Signing a pdf document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignPdfDocumentWithTextWithSaveFormat(string fileName)
        {
            //ExStart:SignPdfDocumentWithTextWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options 
            var signOptions = new PdfSignTextOptions("coca cola");
            signOptions.Left = 100;
            signOptions.Top = 100;
            string fileExtension = Path.GetExtension(fileName);
            // save document
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:SignPdfDocumentWithTextWithSaveFormat
        }

        /// <summary>
        /// Signing a cell document with text
        /// </summary>
        /// <param name="fileName">Name of the input filel</param>
        public static void SignCellDocumentWithTextWithSaveFormat(string fileName)
        {
            //ExStart:SignCellDocumentWithTextWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options
            var signOptions = new CellsSignTextOptions("coca cola");
            // text position
            signOptions.RowNumber = 3;
            signOptions.ColumnNumber = 6;
            // text rectangle size
            signOptions.Height = 100;
            signOptions.Width = 100;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = false;
            // sign first sheet
            signOptions.SheetNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:SignCellDocumentWithTextWithSaveFormat
        }

        /// <summary>
        /// Signing a slide document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentWithTextWithSaveFormat(string fileName)
        {
            //ExStart:SignSlideDocumentWithTextWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options 
            var signOptions = new SlidesSignTextOptions("coca cola");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:SignSlideDocumentWithTextWithSaveFormat
        }

        /// <summary>
        /// Signing a word document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentWithTextWithSaveFormat(string fileName)
        {
            //ExStart:SignWordDocumentWithTextWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options
            var signOptions = new WordsSignTextOptions("coca cola");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:SignWordDocumentWithTextWithSaveFormat
        }


        #endregion

        #region SaveImageSignedOutputWithFormatOptions

        /// <summary>
        /// Signing a pdf document with image
        /// </summary>
        /// <param name="fileName">Name of the input filed</param>
        public static void SignPdfDocumentWithImageWithSaveFormat(string fileName)
        {
            //ExStart:SignPdfDocumentWithImageWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new PdfSignImageOptions("sign.png");
            // image position
            signOptions.Left = 300;
            signOptions.Top = 200;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:SignPdfDocumentWithImageWithSaveFormat
        }

        /// <summary>
        /// Signing a cell document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignCellDocumentWithImageWithSaveFormat(string fileName)
        {
            //ExStart:SignCellDocumentWithImageWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new CellsSignImageOptions("sign.png");
            // image position
            signOptions.RowNumber = 10;
            signOptions.ColumnNumber = 10;
            signOptions.SignAllPages = true;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:SignCellDocumentWithImageWithSaveFormat
        }

        /// <summary>
        /// Signing a slide document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentWithImageWithSaveFormat(string fileName)
        {
            //ExStart:SignSlideDocumentWithImageWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new SlidesSignImageOptions("sign.png");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:SignSlideDocumentWithImageWithSaveFormat
        }

        /// <summary>
        /// Signing word document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentWithImageWithSaveFormat(string fileName)
        {
            //ExStart:SignWordDocumentWithImageWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new WordsSignImageOptions("sign.png");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:SignWordDocumentWithImageWithSaveFormat
        }

        #endregion

        #region SaveDigitalSignedOutputWithFormatOptions

        /// <summary>
        /// Signing a cell document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignCellDocumentDigitallyWithSaveFormat(string fileName)
        {
            //ExStart:signingcelldocumentwithdigitalcertificateWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new CellsSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingcelldocumentwithdigitalcertificateWithSaveFormat
        }

        /// <summary>
        /// Signing a pdf document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignPdfDocumentDigitallyWithSaveFormat(string fileName)
        {
            //ExStart:signingpdfdocumentwithdigitalcertificateWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new PdfSignDigitalOptions("acer.pfx", "sign.png");
            signOptions.Password = null;
            // image position
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingpdfdocumentwithdigitalcertificateWithSaveFormat
        }

        /// <summary>
        /// Signing a word document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentDigitallyWithSaveFormat(string fileName)
        {
            //ExStart:signingworddocumentwithdigitalcertificateWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new WordsSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingworddocumentwithdigitalcertificateWithSaveFormat
        }

        /// <summary>
        /// Signing a slide document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentDigitallyWithSaveFormat(string fileName)
        {
            //ExStart:signingslidedocumentwithdigitalcertificateWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new SlidesSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 2;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingslidedocumentwithdigitalcertificateWithSaveFormat
        }

        #endregion

        #region SetupMultipleSignatureOptions
        //Multiple sign options Pdf documents 
        public static void MultiplePdfSignOptions(string fileName)
        {
            //ExStart:multiplepdfsignoptions
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // define Signature Options Collection
            var collection = new SignatureOptionsCollection();
            // specify text option
            var signTextOptions = new PdfSignTextOptions("Mr. John", 100, 100, 100, 100);
            // add to collection
            collection.Add(signTextOptions);
            // specify image options
            var signImageOptions = new PdfSignImageOptions("sign.png");
            signImageOptions.Left = 200;
            signImageOptions.Top = 200;
            signImageOptions.Width = 100;
            signImageOptions.Height = 100;
            // add to collection
            collection.Add(signImageOptions);
            // specify digital options
            var signDigitalOptions = new PdfSignDigitalOptions("acer.pfx");
            //signDigitalOptions.Password = "1234567890";
            signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom;
            signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center;
            // add to collection
            collection.Add(signDigitalOptions);
            // sign document
            var signedPath = handler.Sign<string>(fileName, collection, new SaveOptions { OutputType = OutputType.String });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:multiplepdfsignoptions
        }

        //Multiple sign options Cells
        public static void MultipleCellSignOptions(string fileName)
        {
            //ExStart:MultipleCellSignOptoins
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // define Signature Options Collection
            var collection = new SignatureOptionsCollection();
            // specify text option
            var signTextOptions = new CellsSignTextOptions("some person");
            // add to collection
            collection.Add(signTextOptions);
            // specify image options
            var signImageOptions = new CellsSignImageOptions("sign.png");
            signImageOptions.Left = 200;
            signImageOptions.Top = 200;
            signImageOptions.Width = 100;
            signImageOptions.Height = 100;
            // add to collection
            collection.Add(signImageOptions);
            // specify digital options
            var signDigitalOptions = new CellsSignDigitalOptions("acer.pfx");
            ////add a password if the document is password protected
            //signDigitalOptions.Password = "1234567890";
            signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom;
            signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center;
            // add to collection
            collection.Add(signDigitalOptions);
            // sign document
            var signedPath = handler.Sign<string>(fileName, collection, new SaveOptions { OutputType = OutputType.String });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:MultipleCellSignOptoins
        }
        //Multiple sign options Word
        public static void MultipleWordSignOptions(string fileName)
        {
            //ExStart:MultipleWordSignOptoins
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // define Signature Options Collection
            var collection = new SignatureOptionsCollection();
            // specify text option
            var signTextOptions = new WordsSignTextOptions("some person");
            // add to collection
            collection.Add(signTextOptions);
            // specify image options
            var signImageOptions = new WordsSignImageOptions("sign.png");
            signImageOptions.Left = 200;
            signImageOptions.Top = 200;
            signImageOptions.Width = 100;
            signImageOptions.Height = 100;
            // add to collection
            collection.Add(signImageOptions);
            // specify digital options
            var signDigitalOptions = new WordsSignDigitalOptions("acer.pfx");
            //add a password if the document is password protected
            //signDigitalOptions.Password = "1234567890";
            signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom;
            signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center;
            // add to collection
            collection.Add(signDigitalOptions);
            // sign document
            var signedPath = handler.Sign<string>(fileName, collection, new SaveOptions { OutputType = OutputType.String });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:MultipleWordSignOptoins
        }

        //Multiple sign options slides
        //public static void MultipleSlideSignOptions(string fileName)
        //{
        //    //ExStart:multipleslidesignoptions
        //    SignatureConfig config = Utilities.GetConfigurations();
        //    // instantiating the signature handler
        //    var handler = new SignatureHandler(config);
        //    // define Signature Options Collection
        //    var collection = new SignatureOptionsCollection();
        //    // specify text option
        //    var signTextOptions = new SlideSignTextOptions("Mr. John", 100, 100, 100, 100);
        //    // add to collection
        //    collection.Add(signTextOptions);
        //    // specify image options
        //    var signImageOptions = new SlideSignImageOptions("sign.png");
        //    signImageOptions.Left = 200;
        //    signImageOptions.Top = 200;
        //    signImageOptions.Width = 100;
        //    signImageOptions.Height = 100;
        //    // add to collection
        //    collection.Add(signImageOptions);
        //    // specify digital options
        //    var signDigitalOptions = new SlideSignDigitalOptions("acer.pfx");
        //    //add a password if the document is password protected
        //    signDigitalOptions.Password = "1234567890";
        //    signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom;
        //    signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center;
        //    // add to collection
        //    collection.Add(signDigitalOptions);
        //    // sign document
        //    var signedPath = handler.Sign<string>(fileName, collection, new SaveOptions { OutputType = OutputType.String });
        //    Console.WriteLine("Signed file path is: " + signedPath);
        //    //ExEnd:multipleslidesignoptions
        //}
        #endregion

        #region SignatureAppearanceOptions

        /// <summary>
        /// Signs Pdf document with Text Signature as Image
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void SignPdfDocWithTextSignAsImage(string fileName)
        {
            //ExStart:SignPdfDocWithTextSignAsImage
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup image signature options with relative path - image file stores in config.ImagesPath folder
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            // setup colors settings
            signOptions.BackgroundColor = System.Drawing.Color.Beige;
            // setup text color
            signOptions.ForeColor = System.Drawing.Color.Red;
            // setup Font options
            signOptions.Font.Bold = true;
            signOptions.Font.Italic = true;
            signOptions.Font.Underline = true;
            signOptions.Font.FontFamily = "Arial";
            signOptions.Font.FontSize = 15;
            //type of implementation
            signOptions.SignatureImplementation = PdfTextSignatureImplementation.Image;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_TextSignatureAsImage" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocWithTextSignAsImage
        }

        /// <summary>
        /// Signs Pdf document with Text Signature as Annotation
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void SignPdfDocWithTextSignAsAnnotation(string fileName)
        {
            //ExStart:SignPdfDocWithTextSignAsAnnotation
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup image signature options with relative path - image file stores in config.ImagesPath folder
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Height = 200;
            signOptions.Width = 200;
            // setup colors settings
            signOptions.BackgroundColor = System.Drawing.Color.Beige;
            // setup text color
            signOptions.ForeColor = System.Drawing.Color.Red;
            // setup Font options
            signOptions.Font.Bold = true;
            signOptions.Font.Italic = true;
            signOptions.Font.Underline = true;
            signOptions.Font.FontFamily = "Arial";
            signOptions.Font.FontSize = 15;
            //type of implementation
            signOptions.SignatureImplementation = PdfTextSignatureImplementation.Annotation;
            // specify extended appearance options
            PdfTextAnnotationAppearance appearance = new PdfTextAnnotationAppearance();
            appearance.BorderColor = Color.Blue;
            appearance.BorderEffect = PdfTextAnnotationBorderEffect.Cloudy;
            appearance.BorderEffectIntensity = 2;
            appearance.BorderStyle = PdfTextAnnotationBorderStyle.Dashed;
            appearance.HCornerRadius = 10;
            appearance.BorderWidth = 5;
            appearance.Contents = signOptions.Text + " content description";
            appearance.Subject = "Appearance Subject";
            appearance.Title = "MrJohn Signature";
            signOptions.Appearance = appearance;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_TextSignatureAsAnnotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocWithTextSignAsAnnotation
        }

        /// <summary>
        /// Signs Pdf document with Text Signature as Sticker
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void SignPdfDocWithTextSignatureAsSticker(string fileName)
        {
            //ExStart:SignPdfDocWithTextSignatureAsSticker
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup signature options
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.HorizontalAlignment = HorizontalAlignment.Right;
            signOptions.VerticalAlignment = VerticalAlignment.Bottom;
            signOptions.Margin = new Padding(10);
            signOptions.BackgroundColor = Color.Red;
            signOptions.Opacity = 0.5;
            //type of implementation
            signOptions.SignatureImplementation = PdfTextSignatureImplementation.Sticker;
            // an appearance customizes more specific options
            PdfTextStickerAppearance appearance = new PdfTextStickerAppearance();
            signOptions.Appearance = appearance;
            // text content of an sticker
            appearance.Title = "Title";
            appearance.Subject = "Subject";
            appearance.Contents = "Contents";
            // is sticker opened by default
            appearance.Opened = false;
            // an icon of a sticker on a page
            appearance.Icon = PdfTextStickerIcon.Star;
            //If custom appearance is not set there will be used DefaultAppearance
            //User can change any parameter of DefaultAppearance
            //PdfTextStickerAppearance.DefaultAppearance.Title = "Title";
            //PdfTextStickerAppearance.DefaultAppearance.Subject = "Subject";
            //PdfTextStickerAppearance.DefaultAppearance.Contents = "Contents";
            //PdfTextStickerAppearance.DefaultAppearance.Opened = false;
            //PdfTextStickerAppearance.DefaultAppearance.State = PdfTextStickerState.Completed;
            //PdfTextStickerAppearance.DefaultAppearance.Icon = PdfTextStickerIcon.Note;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_TextSignatureAsSticker" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocWithTextSignatureAsSticker
        }

        /// <summary>
        /// Adds Rotation to Text Signature appearance
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void AddRotationToTextSignatureAppearance(string fileName)
        {
            //ExStart:AddRotationToTextSignatureAppearance
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup appearance options
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            signOptions.Font.FontSize = 32;
            signOptions.BackgroundColor = Color.BlueViolet;
            signOptions.ForeColor = Color.Orange;
            signOptions.Left = 200;
            signOptions.Top = 200;
            // setup rotation
            signOptions.RotationAngle = 48;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Text_Rotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:AddRotationToTextSignatureAppearance
        }

        /// <summary>
        /// Adds Transparency and Rotation to Text Signature appearance for Slides
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void AddTransparencyRotationToTextSignatureForSlides(string fileName)
        {
            //ExStart:AddTransparencyRotationToTextSignatureForSlides
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup appearance options
            SlidesSignTextOptions signOptions = new SlidesSignTextOptions("John Smith");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 200;
            signOptions.Height = 200;
            signOptions.ForeColor = Color.Orange;
            signOptions.BackgroundColor = Color.BlueViolet;
            signOptions.BorderColor = Color.Orange;
            signOptions.BorderWeight = 5;
            // setup rotation
            signOptions.RotationAngle = 48;
            // setup transparency
            signOptions.BackgroundTransparency = 0.4;
            signOptions.BorderTransparency = 0.8;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Slides_Text_Transparency_Rotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd: AddTransparencyRotationToTextSignatureForSlides
        }

        /// <summary>
        /// Adds Rotation to Image Signature appearance
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void AddRotationToImageSignatureAppearance(string fileName)
        {
            //ExStart:AddRotationToImageSignatureAppearance
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            //setup size and position
            PdfSignImageOptions signOptions = new PdfSignImageOptions("signature.jpg");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 200;
            signOptions.Height = 200;
            // setup rotation
            signOptions.RotationAngle = 48;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Image_Rotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:AddRotationToImageSignatureAppearance
        }

        /// <summary>
        /// Shows how to add extended options to Image Signature appearance
        /// This feature is suppored in version 17.04 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void ImageSignatureAppearanceExtendedoptions(string fileName)
        {
            //ExStart:ImageSignatureAppearanceExtendedoptions
            try
            {
                // setup Signature configuration
                SignatureConfig signConfig = Utilities.GetConfigurations();
                // instantiating the conversion handler
                SignatureHandler handler = new SignatureHandler(signConfig);
                //setup size and position
                WordsSignImageOptions signOptions = new WordsSignImageOptions("signature.jpg");
                signOptions.Left = 100;
                signOptions.Top = 100;
                signOptions.Width = 200;
                signOptions.Height = 200;
                // setup rotation
                signOptions.RotationAngle = 48;
                // setup opacity
                signOptions.Opacity = 0.88;
                //setup additional image appearance
                ImageAppearance imageAppearance = new ImageAppearance();
                imageAppearance.Brightness = 1.2f;
                imageAppearance.Grayscale = true;
                imageAppearance.BorderDashStyle = ExtendedDashStyle.Dot;
                imageAppearance.BorderColor = System.Drawing.Color.OrangeRed;
                imageAppearance.BorderWeight = 5;
                signOptions.Appearance = imageAppearance;

                // sign document
                string signedPath = handler.Sign<string>(fileName, signOptions,
                    new SaveOptions { OutputType = OutputType.String, OutputFileName = "Words_Image_Rotation_Opacity" });
                Console.WriteLine("Signed file path is: " + signedPath);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ExEnd:ImageSignatureAppearanceExtendedoptions
        }

        /// <summary>
        /// Specification of arbitrary pages of Document for processing signature or verification
        /// Feature is supported in version 17.03 or greater
        /// </summary>
        public static void SignArbitraryPages(string fileName)
        {
            //ExStart:SignArbitraryPages
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options of signature
            PdfSignImageOptions signOptions = new PdfSignImageOptions("signature.jpg");
            // setup image size
            signOptions.Width = 100;
            signOptions.Height = 100;
            // setup pages to sign
            signOptions.PagesSetup.FirstPage = true;
            signOptions.PagesSetup.EvenPages = true;
            signOptions.PagesSetup.PageNumbers.Add(1);
            signOptions.PagesSetup.LastPage = false;
            // specify load options
            LoadOptions loadOptions = new LoadOptions();
            // specify save options
            CellsSaveOptions saveOptions = new CellsSaveOptions()
            {
                OutputType = OutputType.String,
                OutputFileName = "ArbitraryPagesOfDocument"
            };
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions, loadOptions, saveOptions);
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignArbitraryPages
        }

        /// <summary>
        /// Shows how to sign PDF documents with text signature as watermark
        /// Feature is supporyted by version 17.05 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignPDFDocsWithTextSignatureAsWatermark(string fileName)
        {
            //ExStart:SignPDFDocsWithTextSignatureAsWatermark
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup text signature options
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            //type of implementation
            signOptions.SignatureImplementation = PdfTextSignatureImplementation.Watermark;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_TextSignatureWatermark" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPDFDocsWithTextSignatureAsWatermark
        }

        /// <summary>
        /// Shows how to specify different Measure Unit Types for PDF Text Signature
        /// Feature is supporyted by version 17.05 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SpecifyDifferentMeasureUnitsForPDFTextSignature(string fileName)
        {
            //ExStart:SpecifyDifferentMeasureUnitsForPDFTextSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);


            // setup text signature options and try locate signature at top right corner
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            signOptions.ForeColor = Color.Red;
            //setup text position on a page in 5 centimeters from top 
            signOptions.LocationMeasureType = MeasureType.Millimeters;
            signOptions.Top = 50;
            //setup signature area size in pixels
            signOptions.SizeMeasureType = MeasureType.Pixels;
            signOptions.Width = 200;
            signOptions.Height = 100;
            //setup signature margins and horizontal alignment
            signOptions.HorizontalAlignment = HorizontalAlignment.Right;
            signOptions.MarginMeasureType = MeasureType.Percents;
            signOptions.Margin.Right = 10;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "DifferentMeasureUnitTypes" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SpecifyDifferentMeasureUnitsForPDFTextSignature
        }

        /// <summary>
        /// Shows how to sign Words Documents with Text Signature to form text field
        /// Feature is supporyted by version 17.05 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignWordsDocsWithTextSignToFormTextField(string fileName)
        {
            //ExStart:SignWordsDocsWithTextSignToFormTextField
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup text signature options
            WordsSignTextOptions signOptions = new WordsSignTextOptions("John Smith");
            signOptions.SignatureImplementation = WordsTextSignatureImplementation.TextToFormField;
            signOptions.FormTextFieldType = WordsFormTextFieldType.RichText;
            signOptions.FormTextFieldTitle = "RT";
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Words_FormFields" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignWordsDocsWithTextSignToFormTextField
        }
        #endregion
        #region SetVerificationOptions

        /// <summary>
        /// Verifies PDF Documents signed with Text Signature 
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void TextVerificationOfPdfDocument(string fileName)
        {
            //ExStart:TextVerificationOfPdfDocument
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            String text = "John Smith, esquire";
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup image signature options with relative path - image file stores in config.ImagesPath folder
            PdfSignTextOptions signOptions = new PdfSignTextOptions(text);
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.DocumentPageNumber = 1;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Documents_Verification_Text" });
            // setup digital verification options
            PDFVerifyTextOptions verifyOptions = new PDFVerifyTextOptions(text);
            verifyOptions.DocumentPageNumber = 1;

            //verify document
            VerificationResult result = handler.Verify(signedPath, verifyOptions);
            Console.WriteLine("Verification result: " + result.IsValid);
            //ExEnd:TextVerificationOfPdfDocument
        }

        /// <summary>
        /// Verifies Cells Documents signed with .cer digital certificates 
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfCellsDocWithCerCertificateContainer(string fileName)
        {
            //ExStart:DigitalVerificationOfCellsDocWithCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            CellsVerifyDigitalOptions verifyOptions = new CellsVerifyDigitalOptions("signtest.cer");
            verifyOptions.Comments = "Test1";
            verifyOptions.SignDateTimeFrom = new DateTime(2017, 1, 26, 14, 55, 07);
            verifyOptions.SignDateTimeTo = new DateTime(2017, 1, 26, 14, 55, 09);

            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfCellsDocWithCertificateContainer
        }

        /// <summary>
        /// Digitally verifies cells document with .pfx certificate container
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfCellsDocWithPfxCertificateContainer(string fileName)
        {
            //ExStart:DigitalVerificationOfCellsDocWithPfxCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            CellsVerifyDigitalOptions verifyOptions1 = new CellsVerifyDigitalOptions("signtest.pfx");
            //password is needed to open .pfx certificate
            verifyOptions1.Password = "123";
            CellsVerifyDigitalOptions verifyOptions2 = new CellsVerifyDigitalOptions("signtest.cer");
            VerifyOptionsCollection verifyOptionsCollection =
                new VerifyOptionsCollection(new List<VerifyOptions>() { verifyOptions1, verifyOptions2 });

            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptionsCollection);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfCellsDocWithPfxCertificateContainer
        }

        /// <summary>
        /// Verifies pdf Documents signed with .cer digital certificates 
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfPdfWithCerContainer(string fileName)
        {
            //ExStart:DigitalVerificationOfPdfWithCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            PDFVerifyDigitalOptions verifyOptions = new PDFVerifyDigitalOptions("ali.cer");
            verifyOptions.Reason = "Test reason";
            verifyOptions.Contact = "Test contact";
            verifyOptions.Location = "Test location";
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfPdfWithCertificateContainer
        }


        /// <summary>
        /// Digitally verifies pdf document with .pfx certificate container
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfPdfWithPfxCertificateContainer(string fileName)
        {
            //ExStart:DigitalVerificationOfPdfWithPfxCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            PDFVerifyDigitalOptions verifyOptions1 = new PDFVerifyDigitalOptions("ali.pfx");
            //password is needed to open .pfx certificate
            verifyOptions1.Password = "1234567890";
            PDFVerifyDigitalOptions verifyOptions2 = new PDFVerifyDigitalOptions("ali.cer");
            VerifyOptionsCollection verifyOptionsCollection =
                new VerifyOptionsCollection(new List<VerifyOptions>() { verifyOptions1, verifyOptions2 });
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptionsCollection);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfPdfWithPfxCertificateContainer
        }

        /// <summary>
        /// Verifies word Documents signed with .cer digital certificates 
        /// </summary>
        public static void DigitalVerificationOfWordDocWithCerCertificateContainer(string fileName)
        {
            //ExStart:DigitalVerificationOfWordDocWithCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            VerifyOptionsCollection verifyOptionsCollection = new VerifyOptionsCollection();
            // setup digital verification options
            WordsVerifyDigitalOptions verifyOptions = new WordsVerifyDigitalOptions("signtest.cer");
            verifyOptions.Comments = "Test1";
            verifyOptions.SignDateTimeFrom = new DateTime(2017, 1, 26, 14, 55, 57);
            verifyOptions.SignDateTimeTo = new DateTime(2017, 1, 26, 14, 55, 59);
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfWordDocWithCertificateContainer
        }


        /// <summary>
        /// Digitally verifies word document with .pfx certificate container
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfWordDocWithPfxCertificateContainer(string fileName)
        {
            //ExStart:DigitalVerificationOfWordDocWithPfxCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            WordsVerifyDigitalOptions verifyOptions1 = new WordsVerifyDigitalOptions("signtest.pfx");
            //password is needed to open .pfx certificate
            verifyOptions1.Password = "123";
            WordsVerifyDigitalOptions verifyOptions2 = new WordsVerifyDigitalOptions("signtest.cer");
            VerifyOptionsCollection verifyOptionsCollection =
                new VerifyOptionsCollection(new List<VerifyOptions>() { verifyOptions1, verifyOptions2 });
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptionsCollection);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfWordDocWithPfxCertificateContainer
        }

        /// <summary>
        /// Verifies PDF Document signed with Text Signature Sticker
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void VerifyPdfDocumentSignedWithTextSignatureSticker(string fileName)
        {
            //ExStart:VerifyPdfDocumentSignedWithTextSignatureSticker
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            PDFVerifyTextOptions verifyOptions = new PDFVerifyTextOptions();
            // specify verification type
            verifyOptions.SignatureImplementation = PdfTextSignatureImplementation.Sticker;
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "Contents";
            // create Verify Extensions
            PdfTextStickerVerifyExtensions extensions = new PdfTextStickerVerifyExtensions();
            //If verify option is set, then appropriate property of Sticker must be equals
            extensions.Contents = "Contents";
            extensions.Subject = "Subject";
            extensions.Title = "Title";
            extensions.Icon = PdfTextStickerIcon.Cross;
            // set extensions to verification options
            verifyOptions.Extensions = extensions;
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyPdfDocumentSignedWithTextSignatureSticker
        }

        /// <summary>
        /// Verifies PDF Document signed with Text Signature Annotation
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void VerifyPdfDocumentSignedWithTextSignatureAnnotation(string fileName)
        {
            //ExStart:VerifyPdfDocumentSignedWithTextSignatureAnnotation
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            PDFVerifyTextOptions verifyOptions = new PDFVerifyTextOptions();
            // specify verification type
            verifyOptions.SignatureImplementation = PdfTextSignatureImplementation.Annotation;
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "John Smith_1";
            // create Verify Extensions
            PdfTextAnnotationVerifyExtensions extensions = new PdfTextAnnotationVerifyExtensions();
            //If verify option is set, then appropriate property of Annotation must be equals
            extensions.Contents = "John Smith_1";
            extensions.Subject = "John Smith_2";
            extensions.Title = "John Smith_3";
            // set extensions to verification options
            verifyOptions.Extensions = extensions;
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyPdfDocumentSignedWithTextSignatureAnnotation
        }

        /// <summary>
        /// Verification of Cells Document signed with Text Signature
        /// Feature is supported in version 17.03 or greater
        /// </summary>
        public static void VerifyCellDocumentSignedWithTextSignature(string fileName)
        {
            //ExStart:VerifyCellDocumentSignedWithTextSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            CellsVerifyTextOptions verifyOptions = new CellsVerifyTextOptions("John Smith");
            verifyOptions.PagesSetup.LastPage = true;
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:VerifyCellDocumentSignedWithTextSignature
        }

        /// <summary>
        /// Verification of Words Document signed with Text Signature
        /// Feature is supported in version 17.03 or greater
        /// </summary>
        public static void VerifyWordDocumentSignedWithTextSignature(string fileName)
        {
            //ExStart:VerifyWordDocumentSignedWithTextSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            WordsVerifyTextOptions verifyOptions = new WordsVerifyTextOptions("John Smith");
            verifyOptions.PagesSetup.FirstPage = true;
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:VerifyWordDocumentSignedWithTextSignature
        }

        /// <summary>
        /// Verification of Slides Document signed with Text Signature
        /// Feature is supported in version 17.03 or greater
        /// </summary>
        public static void VerifySlidesDocumentSignedWithTextSignature(string fileName)
        {
            //ExStart:VerifySlidesDocumentSignedWithTextSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            SlidesVerifyTextOptions verifyOptions = new SlidesVerifyTextOptions("John Smith");
            verifyOptions.PagesSetup.FirstPage = true;
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:VerifySlidesDocumentSignedWithTextSignature
        }

        /// <summary>
        /// Shows how to Verify Words Document signed with Text Signature to form text field
        /// Feature is supported in version 17.05 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void VerifyWordsDocWithTextSignatureToFormTextField(string fileName)
        {
            //ExStart:VerifyWordsDocWithTextSignatureToFormTextField
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            WordsVerifyTextOptions verifyOptions = new WordsVerifyTextOptions();
            // specify other options
            // text
            verifyOptions.Text = "John Smith";
            // type of text field
            verifyOptions.FormTextFieldType = WordsFormTextFieldType.AllTextTypes;
            // title of text field
            verifyOptions.FormTextFieldTitle = "RT";
            //verify document
            VerificationResult result = handler.Verify(fileName, verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:VerifyWordsDocWithTextSignatureToFormTextField
        }

        #endregion

        /// <summary>
        /// OUtput file name can be set in saveoptions
        /// </summary>
        public static void SetOutputFileName()
        {
            //ExStart:SetOutputFileName
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            SignOptions signOptions = new CellsSignTextOptions("John Smith");
            // specify load options
            LoadOptions loadOptions = new LoadOptions();
            // specify save options
            CellsSaveOptions saveOptions = new CellsSaveOptions()
            { OutputType = OutputType.String, OutputFileName = "FileWithDifferentFileName" };
            // sign document
            string signedPath = handler.Sign<string>("pie chart.xlsx", signOptions, loadOptions, saveOptions);
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SetOutputFileName
        }

        /// <summary>
        /// Shows how to obtain information about documents
        /// Feature is supported in version 17.05 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void GetDocumentInfo(string fileName)
        {
            //ExStart:GetDocumentInfo
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // Document description
            DocumentDescription docInfo = handler.GetDocumentDescription(fileName);
            Console.WriteLine("Document " + docInfo.Guid + " contains " + docInfo.PageCount + " pages");
            Console.WriteLine("Width of first page is " + docInfo.Pages.FirstOrDefault().Width);
            // Image from specified page
            byte[] bytesImage = handler.GetPageImage(fileName, 1);
            MemoryStream memoryStream = new MemoryStream(bytesImage);
            using (Image image = Image.FromStream(memoryStream))
            {
                // Make something with image   
                Console.WriteLine("Height of image is " + image.Height);
                image.Save(@"c:\Aspose\Test\Output\ImageFromPage.png", ImageFormat.Png);
            }
            memoryStream.Dispose();
            // Page size
            Size pageSize = handler.GetDocumentPageSize(@"c:\Aspose\Test\Storage\test.pdf", 1);
            Console.WriteLine("Page size is " + pageSize.Height + " x " + pageSize.Width);
            //ExEnd:GetDocumentInfo
        }

        #region working with barcode signatures
        /// <summary>
        /// Shows how to use bar code types in sign options
        /// Feature is supported in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void UsingBarCodeTypes(string fileName)
        {
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            //ExStart:UsingBarCodeTypes
            // setup text signature options
            var signOptions = new PdfBarcodeSignOptions();
            // barcode type
            signOptions.EncodeType = BarcodeTypes.EAN14;
            // signature text
            signOptions.Text = "12345678901234";
            // text position
            signOptions.HorizontalAlignment = HorizontalAlignment.Right;
            signOptions.VerticalAlignment = VerticalAlignment.Bottom;
            //ExEnd:UsingBarCodeTypes
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "BarCode_Document" });
            Console.WriteLine("Signed file path is: " + signedPath);
        }

        /// <summary>
        /// Shows how to sign cells document with barcode options
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignCellsDocumentWithBarCodeOptions(string fileName)
        {
            //ExStart:SignCellsDocumentWithBarCodeOptions
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            CellsBarcodeSignOptions signOptions = new CellsBarcodeSignOptions("12345678");
            // barcode type
            signOptions.EncodeType = BarcodeTypes.Code39Standard;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Cells_Documents_BarCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignCellsDocumentWithBarCodeOptions
        }

        /// <summary>
        /// Shows how to sign pdf document with barcode options
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignPdfDocumentWithBarCodeOptions(string fileName)
        {
            //ExStart:SignPdfDocumentWithBarCodeOptions
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            PdfBarcodeSignOptions signOptions = new PdfBarcodeSignOptions("12345678");
            // barcode type
            signOptions.EncodeType = BarcodeTypes.Code39Standard;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Documents_BarCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocumentWithBarCodeOptions
        }


        /// <summary>
        /// Shows how to sign sildes document with barcode options
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignSlidesDocumentWithBarCodeOptions(string fileName)
        {
            //ExStart:SignSlidesDocumentWithBarCodeOptions
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            SlidesBarcodeSignOptions signOptions = new SlidesBarcodeSignOptions("12345678");
            // barcode type
            signOptions.EncodeType = BarcodeTypes.Code39Extended;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Slides_Documents_BarCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignSlidesDocumentWithBarCodeOptions
        }

        /// <summary>
        /// Shows how to sign words document with barcode options
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignWordsDocumentWithBarCodeOptions(string fileName)
        {
            //ExStart:SignWordsDocumentWithBarCodeOptions
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            WordsBarcodeSignOptions signOptions = new WordsBarcodeSignOptions("12345678");
            // barcode type
            signOptions.EncodeType = BarcodeTypes.Code39Extended;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Words_Documents_BarCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignWordsDocumentWithBarCodeOptions
        }

        /// <summary>
        /// Shows how to verify Cells documents signed with barcode signature
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        public static void VerifyCellsDocumentsSignedWithBarcodeSignature(string cellsFileName)
        {
            //ExStart:VerifyCellsDocumentsSignedWithBarcodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            CellsVerifyBarcodeOptions verifyOptions = new CellsVerifyBarcodeOptions();
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            // barcode type
            verifyOptions.EncodeType = BarcodeTypes.Code39Standard;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "12345678";
            //verify document
            VerificationResult result = handler.Verify(cellsFileName, verifyOptions);

            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyCellsDocumentsSignedWithBarcodeSignature
        }


        /// <summary>
        /// Shows how to verify pdf documents signed with barcode signature
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void VerifyPdfDocumentsSignedWithBarcodeSignature(string PdfFileName)
        {
            //ExStart:VerifyPdfDocumentsSignedWithBarcodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            PDFVerifyBarcodeOptions verifyOptions = new PDFVerifyBarcodeOptions();
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            // barcode type
            verifyOptions.EncodeType = BarcodeTypes.Code39Standard;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "12345678";
            //verify document
            VerificationResult result = handler.Verify(PdfFileName, verifyOptions);

            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyPdfDocumentsSignedWithBarcodeSignature
        }

        /// <summary>
        /// Shows how to verify slides documents signed with barcode signature
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void VerifySlidesDocumentsSignedWithBarcodeSignature(string slidesFileName)
        {
            //ExStart:VerifySlidesDocumentsSignedWithBarcodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            SlidesVerifyBarcodeOptions verifyOptions = new SlidesVerifyBarcodeOptions();
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            // barcode type
            verifyOptions.EncodeType = BarcodeTypes.Code39Standard;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "12345678";
            //verify document
            VerificationResult result = handler.Verify(slidesFileName, verifyOptions);

            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifySlidesDocumentsSignedWithBarcodeSignature
        }

        /// <summary>
        /// Shows how to verify words documents signed with barcode signature
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void VerifyWordsDocumentsSignedWithBarcodeSignature(string wordsFileName)
        {
            //ExStart:VerifyWordsDocumentsSignedWithBarcodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            WordsVerifyBarcodeOptions verifyOptions = new WordsVerifyBarcodeOptions();
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            // barcode type
            verifyOptions.EncodeType = BarcodeTypes.Code39Standard;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "12345678";
            //verify document
            VerificationResult result = handler.Verify(wordsFileName, verifyOptions);

            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyWordsDocumentsSignedWithBarcodeSignature
        }


        /// <summary>
        /// Shows how to verify images documents signed with barcode signature
        /// This feature is availabale in version 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void VerifyImagesDocumentsSignedWithBarcodeSignature(string imagesFileName)
        {
            //ExStart:VerifyImagesDocumentsSignedWithBarcodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            VerifyOptionsCollection collection = new VerifyOptionsCollection();

            // setup verification options Code39Standard
            ImagesVerifyBarcodeOptions verifyOptions = new ImagesVerifyBarcodeOptions();
            verifyOptions.EncodeType = BarcodeTypes.Code39Standard;
            verifyOptions.MatchType = TextMatchType.Exact;
            verifyOptions.Text = "12345678";
            collection.Add(verifyOptions);

            // setup verification options DutchKIX
            verifyOptions = new ImagesVerifyBarcodeOptions();
            verifyOptions.EncodeType = BarcodeTypes.DutchKIX;
            verifyOptions.MatchType = TextMatchType.StartsWith;
            verifyOptions.Text = "1234";
            collection.Add(verifyOptions);

            // setup verification options DatabarLimited
            verifyOptions = new ImagesVerifyBarcodeOptions();
            verifyOptions.EncodeType = BarcodeTypes.DatabarLimited;
            verifyOptions.MatchType = TextMatchType.Contains;
            verifyOptions.Text = "5678";
            collection.Add(verifyOptions);

            //verify document
            VerificationResult result = handler.Verify(imagesFileName, collection);
            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyImagesDocumentsSignedWithBarcodeSignature
        }
        #endregion

        #region working with QR-code signatures

        /// <summary>
        /// Shows how to add QR-code in sign options
        /// Feature is supported in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void AddingQRCode(string fileName)
        {
            //ExStart:AddingQRCode
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup text signature options
            var signOptions = new PdfQRCodeSignOptions();
            //QR-code type
            signOptions.EncodeType = QRCodeTypes.QR;
            // signature text
            signOptions.Text = "12345678901234";
            // text position
            signOptions.HorizontalAlignment = HorizontalAlignment.Right;
            signOptions.VerticalAlignment = VerticalAlignment.Bottom;
            //ExEnd:AddingQRCode
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "QRCode_Document" });
            Console.WriteLine("Signed file path is: " + signedPath);
        }

        /// <summary>
        /// Shows how to sign cells document with QR-code options
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignCellsDocumentWithQrCodeSignature(string cellsFileName)
        {
            //ExStart:SignCellsDocumentWithQrCodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            CellsQRCodeSignOptions signOptions = new CellsQRCodeSignOptions("12345678");
            // QR-code type
            signOptions.EncodeType = QRCodeTypes.Aztec;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(cellsFileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Cells_Documents_QRCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignCellsDocumentWithQrCodeSignature
        }

        /// <summary>
        /// Shows how to sign pdf document with QR-code options
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignPdfDocumentWithQrCodeSignature(string pdfFileName)
        {
            //ExStart:SignPdfDocumentWithQrCodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            PdfQRCodeSignOptions signOptions = new PdfQRCodeSignOptions("12345678");
            // QR-code type
            signOptions.EncodeType = QRCodeTypes.Aztec;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(pdfFileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Documents_QRCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocumentWithQrCodeSignature
        }

        /// <summary>
        /// Shows how to sign slides document with QR-code options
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignSlidesDocumentWithQrCodeSignature(string slidesFileName)
        {
            //ExStart:SignSlidesDocumentWithQrCodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            SlidesQRCodeSignOptions signOptions = new SlidesQRCodeSignOptions("12345678");
            // QR-code type
            signOptions.EncodeType = QRCodeTypes.Aztec;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(slidesFileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Slides_Documents_QRCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignSlidesDocumentWithQrCodeSignature
        }

        /// <summary>
        /// Shows how to sign words document with QR-code options
        /// This feature is availabale in version 17.06 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignWordsDocumentWithQrCodeSignature(string wordsFileName)
        {
            //ExStart:SignWordsDocumentWithQrCodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            WordsQRCodeSignOptions signOptions = new WordsQRCodeSignOptions("12345678");
            // QR-code type
            signOptions.EncodeType = QRCodeTypes.Aztec;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(wordsFileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Words_Documents_QRCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignWordsDocumentWithQrCodeSignature
        }


        /// <summary>
        /// Shows how to verfiry cells documents signed with QR code signature
        /// Feature is supported in version 17.06 or greater
        /// </summary>
        /// <param name="cellsFileName"></param>
        public static void VerifyCellsDocumentSignedWithQrCodeSignature(string cellsFileName)
        {
            //ExStart:VerifyCellsDocumentSignedWithQrCodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            CellsVerifyQRCodeOptions verifyOptions = new CellsVerifyQRCodeOptions();
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            // QR-code type
            verifyOptions.EncodeType = QRCodeTypes.Aztec;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "12345678";
            //verify document
            VerificationResult result = handler.Verify(cellsFileName, verifyOptions);

            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyCellsDocumentSignedWithQrCodeSignature
        }

        /// <summary>
        /// Shows how to verfiry Pdf documents signed with QR code signature
        /// Feature is supported in version 17.06 or greater
        /// </summary>
        /// <param name="pdfFileName"></param>
        public static void VerifyPdfDocumentSignedWithQrCodeSignature(string pdfFileName)
        {
            //ExStart:VerifyPdfDocumentSignedWithQrCodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            PDFVerifyQRCodeOptions verifyOptions = new PDFVerifyQRCodeOptions();
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            // QR-code type
            verifyOptions.EncodeType = QRCodeTypes.Aztec;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "12345678";
            //verify document
            VerificationResult result = handler.Verify(pdfFileName, verifyOptions);

            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyPdfDocumentSignedWithQrCodeSignature
        }

        /// <summary>
        /// Shows how to verfiry Slides documents signed with QR code signature
        /// Feature is supported in version 17.06 or greater
        /// </summary>
        /// <param name="slidesFileName"></param>
        public static void VerifySlidesDocumentSignedWithQrCodeSignature(string slidesFileName)
        {
            //ExStart:VerifySlidesDocumentSignedWithQrCodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            SlidesVerifyQRCodeOptions verifyOptions = new SlidesVerifyQRCodeOptions();
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            // QR-code type
            verifyOptions.EncodeType = QRCodeTypes.Aztec;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "12345678";
            //verify document
            VerificationResult result = handler.Verify(slidesFileName, verifyOptions);

            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifySlidesDocumentSignedWithQrCodeSignature
        }

        /// <summary>
        /// Shows how to verfiry Words documents signed with QR code signature
        /// Feature is supported in version 17.06 or greater
        /// </summary>
        /// <param name="wordsFileName"></param>
        public static void VerifyWordsDocumentSignedWithQrCodeSignature(string wordsFileName)
        {
            //ExStart:VerifyWordsDocumentSignedWithQrCodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            WordsVerifyQRCodeOptions verifyOptions = new WordsVerifyQRCodeOptions();
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            // QR-code type
            verifyOptions.EncodeType = QRCodeTypes.Aztec;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "12345678";
            //verify document
            VerificationResult result = handler.Verify(wordsFileName, verifyOptions);

            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyWordsDocumentSignedWithQrCodeSignature
        }

        /// <summary>
        /// Shows how to verify images documents signed with QR-code signature
        /// This feature is availabale in version 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void VerifyImagesDocumentsSignedWithQRcodeSignature(string imagesFileName)
        {
            //ExStart:VerifyImagesDocumentsSignedWithQRcodeSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            VerifyOptionsCollection collection = new VerifyOptionsCollection();

            // setup verification options Aztec
            ImagesVerifyQRCodeOptions verifyOptions = new ImagesVerifyQRCodeOptions();
            verifyOptions.EncodeType = QRCodeTypes.Aztec;
            verifyOptions.MatchType = TextMatchType.Exact;
            verifyOptions.Text = "12345678";
            collection.Add(verifyOptions);

            // setup verification options DataMatrix
            verifyOptions = new ImagesVerifyQRCodeOptions();
            verifyOptions.EncodeType = QRCodeTypes.DataMatrix;
            verifyOptions.MatchType = TextMatchType.StartsWith;
            verifyOptions.Text = "1234";
            collection.Add(verifyOptions);

            // setup verification options QR
            verifyOptions = new ImagesVerifyQRCodeOptions();
            verifyOptions.EncodeType = QRCodeTypes.QR;
            verifyOptions.MatchType = TextMatchType.Contains;
            verifyOptions.Text = "5678";
            collection.Add(verifyOptions);

            //verify document
            VerificationResult result = handler.Verify(imagesFileName, collection);
            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyImagesDocumentsSignedWithQRcodeSignature
        }
        #endregion

        #region working with Stamp signatures

        /// <summary>
        /// Shows how to add stamp signature to pdf documents
        /// Feature is supported in version 17.07 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void AddingStampSignature(string fileName)
        {
            //ExStart:AddingStampSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup text signature options
            var signOptions = new PdfStampSignOptions();

            // OuterLines property contains list of StampLine object that describe Ring with Height, colored, borders
            // setup first external line of Stamp
            var line0 = new StampLine();
            line0.Text = " * European Union * European Union  * European Union  * European Union  * European Union  * ";
            line0.Font.FontSize = 12;
            line0.Height = 22;
            line0.TextBottomIntent = 6;
            line0.TextColor = Color.WhiteSmoke;
            line0.BackgroundColor = Color.DarkSlateBlue;
            signOptions.OuterLines.Add(line0);
            // draw another stamp ring - specify only thin 2 pixels White part
            var line1 = new StampLine();
            line1.Height = 2;
            line1.BackgroundColor = Color.White;
            signOptions.OuterLines.Add(line1);

            // add another Stamp ring
            var line2 = new StampLine();
            line2.Text = "* Entrepreneur * Entrepreneur ** Entrepreneur * Entrepreneur *";
            line2.TextColor = Color.DarkSlateBlue;
            line2.Font.FontSize = 15;
            line2.Height = 30;
            line2.TextBottomIntent = 8;
            line2.InnerBorder.Color = Color.DarkSlateBlue;
            line2.OuterBorder.Color = Color.DarkSlateBlue;
            line2.InnerBorder.Style = ExtendedDashStyle.Dot;
            signOptions.OuterLines.Add(line2);

            //Inner square lines - horizontal lines inside the rings
            var line3 = new StampLine();
            line3.Text = "John";
            line3.TextColor = Color.MediumVioletRed;
            line3.Font.FontSize = 20;
            line3.Font.Bold = true;
            line3.Height = 40;
            signOptions.InnerLines.Add(line3);

            var line4 = new StampLine();
            line4.Text = "Smith";
            line4.TextColor = Color.MediumVioletRed;
            line4.Font.FontSize = 20;
            line4.Font.Bold = true;
            line4.Height = 40;
            signOptions.InnerLines.Add(line4);

            var line5 = new StampLine();
            line5.Text = "SSN 1230242424";
            line5.TextColor = Color.MediumVioletRed;
            line5.Font.FontSize = 12;
            line5.Font.Bold = true;
            line5.Height = 40;
            signOptions.InnerLines.Add(line5);

            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>("test.pdf", signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Documents_Stamp" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:AddingStampSignature
        }

        /// <summary>
        /// Shows how to sign cells document with stamp signature options
        /// This feature is availabale in version 17.07 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignCellsDocumentWithStampSignature(string cellsFileName)
        {
            //ExStart:SignCellsDocumentWithStampSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            CellsStampSignOptions signOptions = new CellsStampSignOptions();
            signOptions.Height = 120;
            signOptions.Width = 300;
            //Inner square lines
            StampLine line0 = new StampLine();
            line0.Text = "John";
            line0.TextBottomIntent = 0;
            line0.TextColor = Color.MediumVioletRed;
            line0.OuterBorder.Color = Color.DarkSlateBlue;
            line0.InnerBorder.Color = Color.DarkSlateBlue;
            line0.InnerBorder.Style = ExtendedDashStyle.Dash;
            line0.Font.FontSize = 20;
            line0.Font.Bold = true;
            line0.Height = 40;
            signOptions.InnerLines.Add(line0);
            StampLine line1 = new StampLine();
            line1.Text = "Smith";
            line1.TextBottomIntent = 0;
            line1.TextColor = Color.MediumVioletRed;
            line1.InnerBorder.Color = Color.DarkSlateBlue;
            line1.Font.FontSize = 20;
            line1.Font.Bold = true;
            line1.Height = 40;
            signOptions.InnerLines.Add(line1);

            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(cellsFileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Cells_Documents_Stamp" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignCellsDocumentWithStampSignature
        }

        /// <summary>
        /// Shows how to sign pdf document with Stamp signature options
        /// This feature is availabale in version 17.07 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignPdfDocumentWithStampSignature(string pdfFileName)
        {
            //ExStart:SignPdfDocumentWithStampSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            //All examples for Cells, PDF, Slides and Words Stamp Signatures are different
            // setup options with text of signature
            PdfStampSignOptions signOptions = new PdfStampSignOptions();
            signOptions.Height = 300;
            signOptions.Width = 300;
            //Outer round lines
            StampLine line0 = new StampLine();
            line0.Text = " * European Union * European Union  * European Union  * European Union  * European Union  * ";
            line0.Font.FontSize = 12;
            line0.Height = 22;
            line0.TextBottomIntent = 6;
            line0.TextColor = Color.WhiteSmoke;
            line0.BackgroundColor = Color.DarkSlateBlue;
            signOptions.OuterLines.Add(line0);
            StampLine line1 = new StampLine();
            line1.Height = 2;
            line1.BackgroundColor = Color.White;
            signOptions.OuterLines.Add(line1);
            StampLine line2 = new StampLine();
            line2.Text = "* Entrepreneur * Entrepreneur ** Entrepreneur * Entrepreneur *";
            line2.TextColor = Color.DarkSlateBlue;
            line2.Font.FontSize = 15;
            line2.Height = 30;
            line2.TextBottomIntent = 8;
            line2.InnerBorder.Color = Color.DarkSlateBlue;
            line2.OuterBorder.Color = Color.DarkSlateBlue;
            line2.InnerBorder.Style = ExtendedDashStyle.Dot;
            signOptions.OuterLines.Add(line2);
            //Inner square lines
            StampLine line3 = new StampLine();
            line3.Text = "John";
            line3.TextColor = Color.MediumVioletRed;
            line3.Font.FontSize = 20;
            line3.Font.Bold = true;
            line3.Height = 40;
            signOptions.InnerLines.Add(line3);
            StampLine line4 = new StampLine();
            line4.Text = "Smith";
            line4.TextColor = Color.MediumVioletRed;
            line4.Font.FontSize = 20;
            line4.Font.Bold = true;
            line4.Height = 40;
            signOptions.InnerLines.Add(line4);
            StampLine line5 = new StampLine();
            line5.Text = "SSN 1230242424";
            line5.TextColor = Color.MediumVioletRed;
            line5.Font.FontSize = 12;
            line5.Font.Bold = true;
            line5.Height = 40;
            signOptions.InnerLines.Add(line5);
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            // sign document
            string signedPath = handler.Sign<string>(pdfFileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Documents_Stamp" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocumentWithStampSignature
        }

        /// <summary>
        /// Shows how to sign slides document with stamp signature options
        /// This feature is availabale in version 17.07 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignSlidesDocumentWithStampSignature(string slidesFileName)
        {
            //ExStart:SignSlidesDocumentWithStampSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            SlidesStampSignOptions signOptions = new SlidesStampSignOptions();
            signOptions.Height = 200;
            signOptions.Width = 400;
            //Outer round lines
            StampLine line0 = new StampLine();
            line0.Text = " * John * Smith  * John * Smith  * John * Smith  * John * Smith  * John * Smith * John * Smith *  John * Smith * ";
            line0.Font.FontSize = 12;
            line0.Height = 22;
            line0.TextBottomIntent = 6;
            line0.TextColor = Color.WhiteSmoke;
            line0.BackgroundColor = Color.DarkSlateBlue;
            signOptions.OuterLines.Add(line0);
            //Inner square lines
            StampLine line1 = new StampLine();
            line1.Text = "John Smith";
            line1.TextColor = Color.MediumVioletRed;
            line1.Font.FontSize = 24;
            line1.Font.Bold = true;
            line1.Height = 100;
            signOptions.InnerLines.Add(line1);
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;
            signOptions.Opacity = 0.8;
            // sign document
            string signedPath = handler.Sign<string>(slidesFileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Slides_Documents_Stamp" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignSlidesDocumentWithStampSignature
        }

        /// <summary>
        /// Shows how to sign words document with stamp signature options
        /// This feature is availabale in version 17.07 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignWordsDocumentWithStampSignature(string wordsFileName)
        {
            //ExStart:SignWordsDocumentWithStampSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            WordsStampSignOptions signOptions = new WordsStampSignOptions();
            signOptions.Height = 300;
            signOptions.Width = 300;
            signOptions.ImageGuid = "stamp.jpg";
            signOptions.BackgroundColor = Color.Aqua;

            //Inner square lines
            StampLine line0 = new StampLine();
            line0.Text = "John";
            line0.TextColor = Color.MediumVioletRed;
            line0.Font.FontSize = 20;
            line0.Font.Bold = true;
            line0.Height = 40;
            signOptions.InnerLines.Add(line0);
            StampLine line1 = new StampLine();
            line1.Text = "Smith";
            line1.TextColor = Color.MediumVioletRed;
            line1.Font.FontSize = 20;
            line1.Font.Bold = true;
            line1.Height = 40;
            signOptions.InnerLines.Add(line1);
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = true;

            // sign document
            string signedPath = handler.Sign<string>(wordsFileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Words_Documents_Stamp" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignWordsDocumentWithStampSignature
        }

        #endregion


        /// <summary>
        /// Shows how to sign Images document with Text Signature as image
        /// Feature is supported in version 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignImageDocumentWithTextSignatureAsImage(string fileName)
        {
            //ExStart:SignImageDocumentWithTextSignatureAsImage
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            // setup text signature options
            ImagesSignTextOptions signOptions = new ImagesSignTextOptions("John Smith");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            // setup background settings
            signOptions.BackgroundColor = Color.Beige;
            signOptions.BackgroundTransparency = 0.5;

            // setup border settings
            signOptions.BorderColor = Color.Black;
            signOptions.BorderDashStyle = ExtendedDashStyle.LongDash;
            signOptions.BorderWeight = 1.2;
            signOptions.BorderTransparency = 0.5;

            // setup text color
            signOptions.ForeColor = Color.Red;
            // setup Font options
            signOptions.Font.Bold = true;
            signOptions.Font.Italic = true;
            signOptions.Font.Underline = true;
            signOptions.Font.FontFamily = "Arial";
            signOptions.Font.FontSize = 15;

            // type of implementation
            signOptions.SignatureImplementation = ImagesTextSignatureImplementation.TextAsImage;

            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Images_Text_AsImage" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignImageDocumentWithTextSignatureAsImage
        }

        /// <summary>
        /// Shows how to sign Images document with Barcode Signature
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignImageDocumentWithBarCode(string fileName)
        {
            //ExStart:SignImageDocumentWithBarCode
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            SignatureOptionsCollection collection = new SignatureOptionsCollection();

            // barcode type Code39Standard
            ImagesBarcodeSignOptions signOptions = new ImagesBarcodeSignOptions("12345678");
            signOptions.EncodeType = BarcodeTypes.Code39Standard;
            signOptions.HorizontalAlignment = HorizontalAlignment.None;
            signOptions.VerticalAlignment = VerticalAlignment.None;
            collection.Add(signOptions);

            // barcode type DutchKIX
            signOptions = new ImagesBarcodeSignOptions("12345678");
            signOptions.EncodeType = BarcodeTypes.DutchKIX;
            signOptions.Top = 300;
            signOptions.HorizontalAlignment = HorizontalAlignment.None;
            signOptions.VerticalAlignment = VerticalAlignment.None;
            collection.Add(signOptions);

            // barcode type DatabarLimited
            signOptions = new ImagesBarcodeSignOptions("12345678");
            signOptions.EncodeType = BarcodeTypes.DatabarLimited;
            signOptions.HorizontalAlignment = HorizontalAlignment.None;
            signOptions.VerticalAlignment = VerticalAlignment.None;
            signOptions.Top = 600;
            collection.Add(signOptions);

            // sign document
            string signedPath = handler.Sign<string>(fileName, collection,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "DocImages_BarCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignImageDocumentWithBarCode
        }

        /// <summary>
        /// Shows how to sign Images document with QR-code Signature
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignImageDocumentWithQRCode(string fileName)
        {
            //ExStart:SignImageDocumentWithQrCode
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            SignatureOptionsCollection collection = new SignatureOptionsCollection();

            // QRCode type Aztec
            ImagesQRCodeSignOptions signOptions = new ImagesQRCodeSignOptions("12345678");
            signOptions.EncodeType = QRCodeTypes.Aztec;
            signOptions.HorizontalAlignment = HorizontalAlignment.None;
            signOptions.VerticalAlignment = VerticalAlignment.None;
            collection.Add(signOptions);

            // QRCode type DataMatrix
            signOptions = new ImagesQRCodeSignOptions("12345678");
            signOptions.EncodeType = QRCodeTypes.DataMatrix;
            signOptions.Top = 300;
            signOptions.HorizontalAlignment = HorizontalAlignment.None;
            signOptions.VerticalAlignment = VerticalAlignment.None;
            collection.Add(signOptions);

            // QRCode type QR
            signOptions = new ImagesQRCodeSignOptions("12345678");
            signOptions.EncodeType = QRCodeTypes.QR;
            signOptions.HorizontalAlignment = HorizontalAlignment.None;
            signOptions.VerticalAlignment = VerticalAlignment.None;
            signOptions.Top = 600;
            collection.Add(signOptions);

            // sign document
            string signedPath = handler.Sign<string>(fileName, collection,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "DocImages_QRCode" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignImageDocumentWithQrCode
        }

        /// <summary>
        /// Shows how to sign Images document with Stamp Signature
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignImageDocumentWithStampSignature(string fileName)
        {
            //ExStart:SignImageDocumentWithStampSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            // setup options
            ImagesStampSignOptions signOptions = new ImagesStampSignOptions();
            signOptions.Height = 300;
            signOptions.Width = 300;
            signOptions.BackgroundColor = Color.DarkOrange;
            signOptions.BackgroundColorCropType = StampBackgroundCropType.OuterArea; //This feature is supported starting from version 17.08
            signOptions.ImageGuid = "stamp.jpg";
            signOptions.BackgroundImageCropType = StampBackgroundCropType.InnerArea; //This feature is supported starting from version 17.08

            //Outer round lines
            StampLine line0 = new StampLine();
            line0.Text = "* European Union *";
            line0.TextRepeatType = StampTextRepeatType.FullTextRepeat; //This feature is supported starting from version 17.08
            line0.Font.FontSize = 12;
            line0.Height = 22;
            line0.TextBottomIntent = 6;
            line0.TextColor = Color.WhiteSmoke;
            line0.BackgroundColor = Color.DarkSlateBlue;
            signOptions.OuterLines.Add(line0);

            StampLine line1 = new StampLine();
            line1.Height = 2;
            line1.BackgroundColor = Color.White;
            signOptions.OuterLines.Add(line1);

            StampLine line2 = new StampLine();
            line2.Text = "* Entrepreneur *";
            line2.TextRepeatType = StampTextRepeatType.FullTextRepeat; //This feature is supported starting from version 17.08
            line2.TextColor = Color.DarkSlateBlue;
            line2.Font.FontSize = 15;
            line2.Height = 30;
            line2.TextBottomIntent = 8;
            line2.InnerBorder.Color = Color.DarkSlateBlue;
            line2.OuterBorder.Color = Color.DarkSlateBlue;
            line2.InnerBorder.Style = ExtendedDashStyle.Dot;
            signOptions.OuterLines.Add(line2);

            //Inner square lines
            StampLine line3 = new StampLine();
            line3.Text = "John";
            line3.TextColor = Color.MediumVioletRed;
            line3.Font.FontSize = 20;
            line3.Font.Bold = true;
            line3.Height = 40;
            signOptions.InnerLines.Add(line3);

            StampLine line4 = new StampLine();
            line4.Text = "Smith";
            line4.TextColor = Color.MediumVioletRed;
            line4.Font.FontSize = 20;
            line4.Font.Bold = true;
            line4.Height = 40;
            signOptions.InnerLines.Add(line4);

            StampLine line5 = new StampLine();
            line5.Text = "SSN 1230242424";
            line5.TextColor = Color.MediumVioletRed;
            line5.Font.FontSize = 12;
            line5.Font.Bold = true;
            line5.Height = 40;
            signOptions.InnerLines.Add(line5);

            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "DocImages_Stamp" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignImageDocumentWithStampSignature
        }

        /// <summary>
        /// Shows how to save signed Images Documents with different output file type
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SaveSignedImagesDocumentsWithDifferentOutputType(string fileName)
        {
            //ExStart:SaveSignedImagesDocumentsWithDifferentOutputType
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            // setup text signature options
            SignOptions signOptions = new ImagesSignTextOptions("John Smith");

            //Webp
            ImagesSaveOptions optionsWebp = new ImagesSaveOptions();
            optionsWebp.OutputType = OutputType.String;
            optionsWebp.FileFormat = ImagesSaveFileFormat.Webp;
            optionsWebp.OutputFileName = "Images_WithDifferentOutputFileType_Webp";
            string signedPath = handler.Sign<string>(fileName, signOptions, optionsWebp);

            // save to Jpeg format with specific options
            JpegSaveOptions saveOptionsJpeg = new JpegSaveOptions();
            saveOptionsJpeg.OutputType = OutputType.String;
            saveOptionsJpeg.ColorType = JpegCompressionColorMode.Cmyk;
            saveOptionsJpeg.CompressionType = JpegCompressionMode.Progressive;
            saveOptionsJpeg.OutputFileName = "Images_WithDifferentOutputFileType_Jpeg";
            signedPath = handler.Sign<string>(fileName, signOptions, saveOptionsJpeg);

            // save to Bmp format with specific options
            BmpSaveOptions saveOptionsBmp = new BmpSaveOptions();
            saveOptionsBmp.OutputType = OutputType.String;
            saveOptionsBmp.Compression = BitmapCompression.Rgb;
            saveOptionsBmp.HorizontalResolution = 120;
            saveOptionsBmp.VerticalResolution = 120;
            saveOptionsBmp.OutputFileName = "Images_WithDifferentOutputFileType_Bmp";
            signedPath = handler.Sign<string>(fileName, signOptions, saveOptionsBmp);

            // save to Tiff format with specific options
            TiffSaveOptions saveOptionsTiff = new TiffSaveOptions();
            saveOptionsTiff.OutputType = OutputType.String;
            saveOptionsTiff.ExpectedTiffFormat = TiffFormat.TiffCcitRle;
            saveOptionsTiff.OutputFileName = "Images_WithDifferentOutputFileType_Tiff";
            signedPath = handler.Sign<string>(fileName, signOptions, saveOptionsTiff);
            //ExEnd:SaveSignedImagesDocumentsWithDifferentOutputType
        }


        /// <summary>
        /// Shows how to apply transperancy and rotation to Text signature in Images document
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void ApplyTransperancyRotationToTextSignatureImagesDocument(string fileName)
        {
            //ExStart:ApplyTransperancyRotationToTextSignatureImagesDocument
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup appearance options
            ImagesSignTextOptions signOptions = new ImagesSignTextOptions("John Smith");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 200;
            signOptions.Height = 200;
            signOptions.ForeColor = Color.Orange;
            signOptions.BackgroundColor = Color.BlueViolet;

            // setup rotation
            signOptions.RotationAngle = 90;

            // setup transparency
            signOptions.BackgroundTransparency = 0.4;

            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Images_Text_Transparency_Rotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:ApplyTransperancyRotationToTextSignatureImagesDocument
        }

        /// <summary>
        /// Shows how to save signed Images Documents with different output file type
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignImagesDocumentsWithTextSignatureAsWatermark(string fileName)
        {
            //ExStart:SignImagesDocumentsWithTextSignatureAsWatermark
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            // setup text signature options
            ImagesSignTextOptions signOptions = new ImagesSignTextOptions("John Smith");
            signOptions.Font.FontSize = 64; signOptions.Font.Bold = true;
            signOptions.Font.Italic = true;
            signOptions.Font.Underline = true;
            signOptions.Opacity = 0.7;
            signOptions.ForeColor = Color.BlueViolet;
            // type of implementation
            signOptions.SignatureImplementation = ImagesTextSignatureImplementation.Watermark;
            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions, new SaveOptions { OutputType = OutputType.String, OutputFileName = "Images_TextSignatureWatermark" }); Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignImagesDocumentsWithTextSignatureAsWatermark
        }

        /// <summary>
        /// Shows how to sign image documents with image signature
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void SignImagesDocumentWithImageSignature(string fileName)
        {

            //ExStart:SignImagesDocumentWithImageSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            // setup image signature options
            ImagesSignImageOptions signOptions = new ImagesSignImageOptions("signature.jpg");

            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Images_ImageSignature" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignImagesDocumentWithImageSignature
        }

        /// <summary>
        /// Shows how to specify margins and alignment for image signature appearance in image documents
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void ImageDocumentMarginAlignmentForImageSignature(string fileName)
        {
            //ExStart:ImageDocumentMarginAlignmentForImageSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            // setup image signature options
            ImagesSignImageOptions signOptions = new ImagesSignImageOptions("signature.jpg");

            // specify horizontal alignment
            signOptions.HorizontalAlignment = HorizontalAlignment.Center;
            // specify vertical alignment
            signOptions.VerticalAlignment = VerticalAlignment.Bottom;

            // specify Margin
            signOptions.Margin = new Padding(10);
            // specify separate left margin value
            signOptions.Margin.Left = 20;

            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Images_ImageSignature_MarginsAndAlignment" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:ImageDocumentMarginAlignmentForImageSignature
        }

        /// <summary>
        /// Shows how to Specify Adjustment Size, Margins and Intents of Image Signature in an image document
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void ImageDocumentAdjustmentSizeMarginsIntentOfImageSignature(string fileName)
        {
            //ExStart:ImageDocumentAdjustmentSizeMarginsIntentOfImageSignature
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            SignatureOptionsCollection collection = new SignatureOptionsCollection();

            //Percents
            // setup image signature options
            ImagesSignImageOptions signOptionsPercents = new ImagesSignImageOptions("signature.jpg");
            // specify Size
            signOptionsPercents.Height = 25;
            signOptionsPercents.Width = 25;
            // specify size in percents of page size
            signOptionsPercents.SizeMeasureType = MeasureType.Percents;
            // specify Margin
            signOptionsPercents.Margin = new Padding(10);
            // specify margin in percents of page size
            signOptionsPercents.MarginMeasureType = MeasureType.Percents;
            // specify Intents
            signOptionsPercents.Top = 50;
            signOptionsPercents.Left = 20;
            // specify intents in percents of page size
            signOptionsPercents.LocationMeasureType = MeasureType.Percents;
            collection.Add(signOptionsPercents);

            //Millimeters
            // setup image signature options
            ImagesSignImageOptions signOptionsMillimeters = new ImagesSignImageOptions("signature.jpg");
            // specify Size
            signOptionsMillimeters.Height = 50;
            signOptionsMillimeters.Width = 50;
            // specify size in millimeters
            signOptionsMillimeters.SizeMeasureType = MeasureType.Millimeters;
            // specify Margin
            signOptionsMillimeters.HorizontalAlignment = HorizontalAlignment.Right;
            signOptionsMillimeters.VerticalAlignment = VerticalAlignment.Bottom;
            signOptionsMillimeters.Margin = new Padding(20);
            // specify margin in millimeters
            signOptionsMillimeters.MarginMeasureType = MeasureType.Millimeters;
            collection.Add(signOptionsMillimeters);

            // sign document
            string signedPath = handler.Sign<string>(fileName, collection,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Images_ImageSignature_Adjustment" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:ImageDocumentAdjustmentSizeMarginsIntentOfImageSignature
        }


        /// <summary>
        /// Shows how to add extended options to Image signature appearance in an image document
        /// Feature is supported in versin 17.8.0 or greater
        /// </summary>
        /// <param name="fileName"></param>
        public static void ImageDocumentImageSignatureExtendedOptions(string fileName) {
            //ExStart:ImageDocumentImageSignatureExtendedOptions
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            //setup size and position
            ImagesSignImageOptions signOptions = new ImagesSignImageOptions("signature.jpg");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 200;
            signOptions.Height = 200;

            // setup rotation
            signOptions.RotationAngle = 48;
            // setup opacity
            signOptions.Opacity = 0.88;
            //setup additional image appearance
            ImageAppearance imageAppearance = new ImageAppearance();
            imageAppearance.Brightness = 1.2f;
            imageAppearance.Grayscale = true;
            imageAppearance.BorderDashStyle = ExtendedDashStyle.Dot;
            imageAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            imageAppearance.BorderWeight = 5;
            signOptions.Appearance = imageAppearance;

            // sign document
            string signedPath = handler.Sign<string>(fileName, signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Images_Image_Rotation_Opacity" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:ImageDocumentImageSignatureExtendedOptions
        }


    }
}
