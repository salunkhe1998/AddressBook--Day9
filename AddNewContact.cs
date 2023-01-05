using AddressBookProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook__Day9
{
    class AddressBook
    {

        private List<Contact> addressBookList = new List<Contact>();
        public List<Contact> AddressBookList
        {
            get { return addressBookList; }
            set { this.addressBookList = value; }
        }
        public AddressBook()
        {
            AddressBookList = new List<Contact>();
        }

        public void CreateUser()
        {
            Console.WriteLine("Enter FirstName:");
            var FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName:");
            var LastName = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            var Address = Console.ReadLine();

            Console.WriteLine("Enter City:");
            var City = Console.ReadLine();

            Console.WriteLine("Enter State:");
            var State = Console.ReadLine();

            Console.WriteLine("Enter Zip:");
            var Zip = Console.ReadLine();

            Console.WriteLine("Enter PhoneNum:");
            var PhoneNum = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            var Email = Console.ReadLine();

            Contact contact = new Contact(FirstName, LastName, Address, City, State, Zip, PhoneNum, Email);
            AddPersonToList(contact);

        }
        private void AddPersonToList(Contact contact) => AddressBookList.Add(contact);
        public void ShowAllPersonsInList()
        {
            foreach (var person in AddressBookList)
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName: {0}, LastName: {1}, Adress: {2}, City : {3}, State: {4}, Zip: {5}, PhoneNum: {6}, Email: {7}", person.FirstName, person.LastName, person.Address, person.City, person.State, person.Zip, person.PhoneNumber, person.Email);
            }
            Console.ReadLine();
        }
    }
}
