// See https://aka.ms/new-console-template for more information


using ContactList;

//while (true)
//{
//    insertPhoneBook()
//}

insertPhoneBook();


void insertPhoneBook()
{
    Console.WriteLine("Welcome to PhoneBook");

    Console.WriteLine("How many contacts do you want to insert?");
    int brContacts = int.Parse(Console.ReadLine());

    PhoneBook phoneBook = new PhoneBook();

    for (int i = 0; i < brContacts; i++)
    {

        Console.WriteLine("Insert name");
        var name = Console.ReadLine();

        Console.WriteLine("Insert surname");
        var surname = Console.ReadLine();

        Console.WriteLine("Insert address");
        var address = Console.ReadLine();


        Console.WriteLine("How many numbers do you want to insert>");

        int brNumber = int.Parse(Console.ReadLine());
        List<String> phoneNumbers = new List<String>();


        for (int j = 0; j < brNumber; j++)
        {
            Console.WriteLine($"Insert number{j+1}");

            phoneNumbers.Add(Console.ReadLine());
        }


        Contact contact = new Contact(name, surname, address, phoneNumbers);

    }
    phoneBook.ToString();
    insertPhoneBook();
}
