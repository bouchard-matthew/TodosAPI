using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ToDosAPI.Models;

public partial class User
{
    public long Id { get; set; }

    [Required]
    [StringLength(25, MinimumLength = 7)]
    public string Username { get; set; } = null!;

    [Required]
    [StringLength(255, MinimumLength = 2)]
    public string Firstname { get; set; } = null!;

    [Required]
    [StringLength(255, MinimumLength = 2)]
    public string Lastname { get; set; } = null!;

    [Required, RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Password must contain at least one uppercase and lowercase letter and a symbol.")]
    [StringLength(64, ErrorMessage = "Must be between 5 and 64 characters", MinimumLength = 5)]
    public string Password { get; set; } = null!;

    public DateTime Createdon { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
