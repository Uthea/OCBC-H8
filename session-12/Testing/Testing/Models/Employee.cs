using System.ComponentModel.DataAnnotations;

namespace Testing.Models
{
    public class Employee
    {
       [Key]
       public int Id { get; set; }
       public string Name { get; set; }
       public string Desgination { get; set; }
    }
}