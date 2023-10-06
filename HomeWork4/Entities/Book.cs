using System.Security.Principal;

namespace HomeWork4.Entities
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }

        public int Page_Count { get; set; }

        // foreign key
        public int StudentId { get; set; }

        public int BookTypeId { get; set; }

        // navigation property
        public Student Student { get; set; }

        public ICollection<Author> Authors { get; set; }

        public BookType BookType { get; set; }
    }
}
