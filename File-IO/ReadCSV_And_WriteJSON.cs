using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace File_IO
{
    public class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVToJSON()
        {
            string importFilePath = "E:\\RFP-267\\File-IO\\File-IO\\Import.csv";
            string exportFilePath = "E:\\RFP-267\\File-IO\\File-IO\\ExportInfo.json";
            using (var reader = new StreamReader(importFilePath))//streamreader reads character from a byte in particular encoding
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Contacts>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (Contacts addressData in records)
                {
                    Console.Write("\t" + addressData.FirstName);
                    Console.Write("\t" + addressData.LastName);
                    Console.Write("\t" + addressData.Address);
                    Console.Write("\t" + addressData.City);
                    Console.Write("\t" + addressData.State);
                    Console.Write("\t" + addressData.Zipcode);
                    Console.Write("\t" + addressData.PhoneNumber);
                    Console.Write("\t" + addressData.Email);
                    Console.WriteLine();
                }
                Console.WriteLine("**********************Reading fromcsv file and Write to Json file **************************");

                //Writing json file

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records); //     Serializes the specified System.Object and writes the JSON structure using the specified Newtonsoft.Json.JsonWriter.

                }

            }
        }
    }
}
