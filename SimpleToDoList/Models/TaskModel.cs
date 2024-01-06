using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SimpleToDoList.Models
{
    public class TaskModel
    {
      [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [DisplayName("Nazwa zadania")]
    public string TaskName { get; set; }

    [DisplayName("Opis")]
    public string? Description { get; set; }

    [DisplayName("Wykonano")]
    public bool IsDone { get; set; } = false;
    }
}

