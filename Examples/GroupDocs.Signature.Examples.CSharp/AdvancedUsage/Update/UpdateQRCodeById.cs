﻿using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Signature.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Signature;
    using GroupDocs.Signature.Domain;

    public class UpdateQRCodeById
    {
        /// <summary>
        /// Update QR-code signature in the document by known SignatureId
        /// SignatureId could be obtained by Search or Sign method
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # UpdateQRCodeById : Update QR-code signature in the document by known SignatureId\n");

            // The path to the documents directory.
            string filePath = Constants.SAMPLE_SIGNED_MULTI;
            // copy source file since Update method works with same Document
            string fileName = Path.GetFileName(filePath);
            string outputFilePath = Path.Combine(Constants.OutputPath, "UpdateQRCodeById", fileName);
            Constants.CheckDir(outputFilePath);
            File.Copy(filePath, outputFilePath, true);
            // initialize Signature instance
            using (Signature signature = new Signature(outputFilePath))
            {
                // read from some data source signature Id value
                string[] signatureIdList = new string[]
                {
                    "eff64a14-dad9-47b0-88e5-2ee4e3604e71"
                };
                // create list of QR-code Signature by known SignatureId
                List<BaseSignature> signatures = new List<BaseSignature>();
                foreach (var item in signatureIdList)
                {
                    QrCodeSignature temp = new QrCodeSignature(item);
                    temp.Width = 150;
                    temp.Height = 150;
                    temp.Left = 200;
                    temp.Top = 200;
                    signatures.Add(temp);
                }
                // update all found signatures
                UpdateResult updateResult = signature.Update(signatures);
                if (updateResult.Succeeded.Count == signatures.Count)
                {
                    Console.WriteLine("All signatures were successfully updated!");
                }
                else
                {
                    Console.WriteLine($"Successfully updated signatures : {updateResult.Succeeded.Count}");
                    Helper.WriteError($"Not updated signatures : {updateResult.Failed.Count}");
                }
                Console.WriteLine("List of updated signatures:");
                foreach (BaseSignature temp in updateResult.Succeeded)
                {
                    Console.WriteLine($"Signature# Id:{temp.SignatureId}, Location: {temp.Left}x{temp.Top}. Size: {temp.Width}x{temp.Height}");
                }
            }
        }
    }
}