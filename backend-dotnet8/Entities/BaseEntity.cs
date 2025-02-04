namespace backend_dotnet8.Entities
{
    public class BaseEntity<TID>
    {
     public TID Id { get; set; }
     public DateTime CreatedAt { get; set; } = DateTime.Now;
     public DateTime UpdatedAt { get; set; } = DateTime.Now;

     public bool IasActive { get; set; } = true;
     public bool IsDeleted { get; set; } = false;

     

    }
}
