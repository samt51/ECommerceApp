namespace ECommerce.Shared.Commond
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifyDate { get; set; }
        public bool IsDeleted { get; set; }

        public int asd { get; set; }



    }
}
