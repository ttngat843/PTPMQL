using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
  public class Person
  {
    [Key]
    public int Id {get; set; }
     public int PersonId {get; set;}
     public string Fullname { get; set;} = string.Empty;
     public string Address { get; set;} = string.Empty;
     public string? Discriminator { get; set; }

  }
}