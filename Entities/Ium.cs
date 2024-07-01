namespace Entities
{
    /// <summary>
    /// Medicamento alternativo formulado por el profesional en salud
    /// </summary>
    public class Ium
    {
        /// <summary>
        /// Identificador del medicamento
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del medicamento
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del medicamento
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Ium()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
