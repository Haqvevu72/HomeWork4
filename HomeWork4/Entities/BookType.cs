namespace HomeWork4.Entities
{
    public class BookType:BaseEntity
    {
        public string Name { get; set; }

        // navigation property
        public ICollection<Book> Books { get; set; }
    }
}
