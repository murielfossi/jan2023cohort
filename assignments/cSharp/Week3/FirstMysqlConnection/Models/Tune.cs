#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FirstMysqlConnection.Models;

public class Tune {
    [Key]
    public int TuneId {get; set;} // Auto generated Id
    [Required]
    public string TuneName {get; set;}
    [Required]
    public string TuneImg {get; set;}
    [Required]
    public string TuneOwner {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now; // Auto Generated
    public DateTime UpdatedAt { get; set; } = DateTime.Now; // Auto Generated
}