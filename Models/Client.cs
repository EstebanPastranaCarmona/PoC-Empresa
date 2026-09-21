using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PoCEmPRESA.Models;

public class Client
{
    public int Id {get; set;}

    [Required]
    [StringLength(100, ErrorMessage = "The name can't pass the 100 characters")]
    public string Name {get; set;} = string.Empty;

    
    [Required]
    [StringLength(100, ErrorMessage = "The email account can't pass the 100 characters")]
    [EmailAddress(ErrorMessage = "Please submit a valid email")]
    public string Email {get; set;} = string.Empty;
}