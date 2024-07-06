namespace Entities
{
    /// <summary>
    /// Tipo de paciente
    /// </summary>
    public class PatientType
    {
        /// <summary>
        /// Identificador del tipo de paciente
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del tipo de paciente
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del tipo de paciente
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public PatientType()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
