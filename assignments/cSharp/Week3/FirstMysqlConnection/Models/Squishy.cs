#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstMysqlConnection.Models;

public class Squishy {
    [Key]
    public int SquishyId {get; set;} // Auto generated Id do not need to put it inn the post method in the controller
    [Required]
    public string SquishyName {get; set;}
    [Required]
    public string SquishyImg {get; set;}
    [Required]
    public string Owner {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now; // Auto Generated
    public DateTime UpdatedAt { get; set; } = DateTime.Now; // Auto Generated
}