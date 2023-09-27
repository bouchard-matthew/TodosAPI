using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ToDosAPI.Models;

public partial class User
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
