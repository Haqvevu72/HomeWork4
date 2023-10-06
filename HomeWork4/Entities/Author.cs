namespace HomeWork4.Entities
{
    public class Author:BaseEntity
    {
        // navigation property
        ICollection<Book> Books { get; set; }
    }
}
