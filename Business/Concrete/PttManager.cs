using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;


        //Constructor new yapıldığında çalışır
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verildi");
                Console.BackgroundColor = ConsoleColor.DarkGreen;

            }
            else
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verilemedi!!!");
                Console.BackgroundColor = ConsoleColor.Red;

            }
        }
    }
}
