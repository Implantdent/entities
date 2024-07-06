namespace Entities
{
    /// <summary>
    /// Modalidad de la prestación del servicio de salud
    /// </summary>
    public class Modality
    {
        /// <summary>
        /// Identificador de la prestación del servicio de salud
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la prestación del servicio de salud
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la prestación del servicio de salud
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Modality()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
