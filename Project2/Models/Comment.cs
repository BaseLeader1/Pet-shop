using System.ComponentModel.DataAnnotations;

public class Comment
{
    public int CommentId { get; set; }
    [Required]
    [DataType(DataType.MultilineText)]
    [MaxLength(20)]
    public string? CommentText { get; set; }
    public int AnimalId { get; set; }

}

