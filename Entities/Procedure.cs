namespace Entities
{
    /// <summary>
    /// Procedimiento ejecutado sobre un paciente
    /// </summary>
    public class Procedure
    {
        /// <summary>
        /// Identificador del procedimiento
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del procedimiento
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del procedimiento
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Procedure()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
