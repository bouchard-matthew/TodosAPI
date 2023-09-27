using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ToDosAPI.Models;

public partial class Task
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime Createdon { get; set; }
    public long? Userid { get; set; }
    [JsonIgnore]
    public virtual User? User { get; set; }
}
