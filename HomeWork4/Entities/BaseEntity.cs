namespace HomeWork4.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime ModifyTime { get; set; }

        public BaseEntity()
        {
            CreateTime = DateTime.Now;
        }
    }
}
