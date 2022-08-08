using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class MultiplePerson
    {
        AddressBookUC ObjAdd = new AddressBookUC();
        public void AddMultipleContact1()
        {
            Console.WriteLine("Enter the Number of Persons to add");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Num; i++)
            {
                ObjAdd.AddNewContact();
            }
        }
    }
}
