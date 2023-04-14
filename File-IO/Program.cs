using System;

namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To File IO Project");

           // FileOperation.FileExists();
           // FileOperation.ReadAllLines();
          //  FileOperation.ReadFromStreamReader();
          // FileOperation.WriteUsingStreamWriter();
          ReadWriteCSV.ImplementCSVDataHandling();
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();
        }
    }
}
