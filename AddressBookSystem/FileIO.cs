﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookTrail
{
    class FileIO
    {
        const string TXTPATH = @"C:\Users\ak\Desktop\BridgeLabz Project\AddressBookSystem\AddressBookSystem\StoredContact.txt";
        const string CSVPATH = @"C:\Users\ak\Desktop\BridgeLabz Project\AddressBookSystem\AddressBookSystem\StoredContactTable.csv";
        public static void WriteDataToTxt(Dictionary<string, Contact> DictName)
        {
            if (File.Exists(TXTPATH))
            {
                using (TextWriter tw = new StreamWriter(TXTPATH))
                {
                    tw.WriteLine(string.Format("FirstName,LastName,Address,City,State,ZipCode,PhoneNumber,Email"));
                    foreach (var element in DictName)
                    {
                        tw.WriteLine(string.Format($"{element.Value.FirstName},{element.Value.LastName},{element.Value.Address},{element.Value.City},{element.Value.State},{element.Value.ZipCode},{element.Value.PhoneNumber},{element.Value.Email}"));
                    }
                }
            }
            else Console.WriteLine("File doesn't exist, Check the Path");
        }
        public static void WriteDataToCSV(Dictionary<string, Contact> DictName)
        {
            if (File.Exists(CSVPATH))
            {
                using (TextWriter tw = new StreamWriter(CSVPATH))
                {
                    tw.WriteLine(string.Format("FirstName,LastName,Address,City,State,ZipCode,PhoneNumber,Email"));
                    foreach (var element in DictName)
                    {
                        tw.WriteLine(string.Format($"{element.Value.FirstName},{element.Value.LastName},{element.Value.Address},{element.Value.City},{element.Value.State},{element.Value.ZipCode},{element.Value.PhoneNumber},{element.Value.Email}"));
                    }
                }
            }
            else Console.WriteLine("File doesn't exist, Check the Path");
        }
    }
}
