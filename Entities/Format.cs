namespace Entities
{
    /// <summary>
    /// Formato de documento que debe firmar el paciente
    /// </summary>
    public class Format
    {
        /// <summary>
        /// Identificador del formato
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre del formato
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Texto del formato
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Format()
        {
            Id = 0;
            Name = string.Empty;
            Text = string.Empty;
        }
    }
}
