﻿using System;


namespace AddressBookUsingCSVandJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AddressBook");
            List<Person> listPersonInCity = new List<Person>();
            AddressBook AB = new AddressBook();

            AddressBook.AddRecords(listPersonInCity); //uc1
            //AddressBook.AddPerson(listPersonInCity); //uc2
            //AddressBook.edit(listPersonInCity);
            //AddressBook.DeletepersonName(listPersonInCity);
            //AddressBook.duplicateentry(listPersonInCity);
            //AddressBook.SameCityStateMates(listPersonInCity);
            //AddressBook.SortData(listPersonInCity);
            //AddressBook.SortDatabyCity(listPersonInCity);
            CSVandJSON.ImplemntCSVjSON();
        }
    }
}