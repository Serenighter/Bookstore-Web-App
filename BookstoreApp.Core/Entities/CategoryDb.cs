using System.Security.Cryptography.X509Certificates;

namespace BookstoreApp.Core.Entities;

public class CategoryDb
{
    public int Id { get; set; }
    public string Name { get; set; }

    public IEnumerable<BookDb> Books { get; set; }

    public CategoryDb(string name)
    {
        Name = name;
    }
}