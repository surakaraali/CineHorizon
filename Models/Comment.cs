using System;
using System.Collections.Generic;

namespace MyWebApp.Models
{
    public partial class Comment
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public string? Content { get; set; }

    public DateTime CreatedAt { get; set; }
}


}