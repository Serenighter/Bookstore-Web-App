namespace BookstoreApp.Core.Entities;

public class ClientDb
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public IEnumerable<BookDb> Books { get; set; }

    public ClientDb(string name, string surname, string email, string phoneNumber)
    {
        Name = name;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
    }

}
