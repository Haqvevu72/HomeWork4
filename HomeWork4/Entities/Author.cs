namespace HomeWork4.Entities
{
    public class Author:BaseEntity
    {

        public  string FirstName{ get; set; }

        public string LastName { get; set; }
        // navigation property
        ICollection<Book> Books { get; set; }
    }
}
