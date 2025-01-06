using System.ComponentModel.DataAnnotations;

namespace BookLibrary.API.Data;

public class Book
{
    public int Id { get; set;}
    public required string Title { get; set; }
    public required string ISBN { get; set; }

    //Publisher

    //UserId

    public int? PublicationYear { get; set;}
    public bool IsAvailable { get; set; }
    
    //IEnum, Array of Author

    public int? AuthorId { get; set; }
    public string? Author { get; set; }

}
