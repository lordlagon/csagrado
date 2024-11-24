using System.ComponentModel.DataAnnotations;

namespace Csagrado.Course
{
    public class GameModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? ReleaseDate { get; set; } = DateTime.MinValue;
    }

}