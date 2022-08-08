namespace AddressBook
{
   public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Wellcome to Welcome to Address Book Program");
            AddressBookUC obj = new AddressBookUC();
            //obj.AddNewContact();
            //AddressBookUC.PrintAddressBook();

            //Console.WriteLine("Enter the FirstName to Edit");
            //string firstName = Console.ReadLine();
            //obj.EditContact(firstName);
            //AddressBookUC.PrintAddressBook();

            //Console.WriteLine("Enter the FirstName to Delete");
            //string firstName1 = Console.ReadLine();
            //obj.DeleteContact(firstName1);
            //AddressBookUC.PrintAddressBook();
            //Console.ReadLine();


            // obj.AddMultipleContact1();


            MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
            multipleAddressBook.AddAddressBook();


        }
    }
}

