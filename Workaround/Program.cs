using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person person = new Person();
            person.FirstName = "Metin";
            person.LastName = "Oktay";
            person.DateOfBirthYear = 1905;
            person.NationalIdentity = 19050001905;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person);
        }


    }

}