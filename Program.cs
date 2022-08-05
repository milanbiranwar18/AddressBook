namespace AddressBook
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to Welcome to Address Book Program");
            AddressBookUC obj = new AddressBookUC();
            obj.AddNewContact();
            AddressBookUC.PrintAddressBook();
        }
    }
}

