using System.ComponentModel.DataAnnotations;

namespace API_EjercicioT2.Models.DataModels
{
    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required, StringLength(560)]
        public string LongDescription { get; set; } = string.Empty;
        [Required, StringLength(560)]
        public string PublicObjective { get; set; } = string.Empty;
        [Required, StringLength(560)]
        public string Objectives { get; set; } = string.Empty;
        [Required, StringLength(560)]
        public string Requirements { get; set; } = string.Empty;
        public enum Level
        {
            Basico = 1,
            Intermedio =2,
            Avanzado = 3,
        }
    }
}