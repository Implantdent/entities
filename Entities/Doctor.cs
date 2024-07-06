namespace Entities
{
    /// <summary>
    /// Profesional de la salud que atiende un paciente
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// Identificador del médico
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Tipo de documento del médico
        /// </summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Número de documento del médico
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Nombres del médico
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Apellidos del médico
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Doctor()
        {
            Id = 0;
            DocumentType = new DocumentType();
            DocumentNumber = string.Empty;
            Name = string.Empty;
            LastName = string.Empty;
        }
    }
}
