using System;
using System.Collections.Generic;

namespace MyWebApp.Models
{
    public class Comment
{
    public int CommentId { get; set; }
    public int MovieId { get; set; }
    public int UserId { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; }

    public User? User { get; set; } 
    public Movie? Movie { get; set; }
}



}