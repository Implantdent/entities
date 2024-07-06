namespace Entities
{
    /// <summary>
    /// Unidad mímina de medicamento dispensada
    /// </summary>
    public class Upr
    {
        /// <summary>
        /// Identificador de la unidad
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la unidad
        /// </summary>
        public short Code { get; set; }

        /// <summary>
        /// Nombre de la unidad
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Upr()
        {
            Id = 0;
            Code = 0;
            Name = string.Empty;
        }
    }
}
