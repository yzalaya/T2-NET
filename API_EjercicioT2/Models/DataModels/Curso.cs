using System.ComponentModel.DataAnnotations;

namespace API_EjercicioT2.Models.DataModels
{
    public enum Level
    {
        Basico,
        Intermedio,
        Avanzado
    }

    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required, StringLength(560)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string PublicObjectives { get; set; } = string.Empty;
        [Required]
        public string Objectives { get; set; } = string.Empty;
        [Required]
        public string Requirements { get; set; } = string.Empty;
        [Required]
        public Level Level { get; set; } = Level.Basico;        
    }
}
