namespace BookstoreApp.Core.Entities;
public class PublisherDb
{
      public int Id { get; set; }
      public string Name { get; set; }
      public IEnumerable<BookDb> Books { get; set; }

    public PublisherDb(string name)
    {  
        Name = name;
    }

}
