namespace Entities
{
    /// <summary>
    /// Paciente
    /// </summary>
    public class Patient : IEntity
    {
        /// <summary>
        /// Identificador del paciente
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tipo de paciente
        /// </summary>
        public PatientType PatientType { get; set; }

        /// <summary>
        /// Primer nombre del paciente
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Segundo nombre del paciente
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Primer apellido del paciente
        /// </summary>
        public string FirstLastName { get; set; }

        /// <summary>
        /// Segundo apellido del paciente
        /// </summary>
        public string SecondLastName { get; set; }

        /// <summary>
        /// Tipo de documento del paciente
        /// </summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Número de documento del paciente
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Fecha de nacimiento del paciente
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Teléfono del paciente
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Ocupación del paciente
        /// </summary>
        public string Ocupation { get; set; }

        /// <summary>
        /// Género del paciente
        /// </summary>
        public Genre Genre { get; set; }

        /// <summary>
        /// Estado civil del paciente
        /// </summary>
        public CivilState CivilState { get; set; }

        /// <summary>
        /// Ciudad del paciente
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Tipo de zona donde reside el paciente
        /// </summary>
        public ZoneType ZoneType { get; set; }

        /// <summary>
        /// EPS del paciente
        /// </summary>
        public Eps Eps { get; set; }

        /// <summary>
        /// Dirección del paciente
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Teléfono de un contacto del paciente
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Nombre de un contacto del paciente
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Patient()
        {
            Id = 0;
            PatientType = new PatientType();
            FirstName = string.Empty;
            SecondName = string.Empty;
            FirstLastName = string.Empty;
            SecondLastName = string.Empty;
            DocumentType = new DocumentType();
            DocumentNumber = string.Empty;
            Birthday = DateTime.MinValue;
            Phone = string.Empty;
            Ocupation = string.Empty;
            Genre = new Genre();
            CivilState = new CivilState();
            City = new City();
            ZoneType = new ZoneType();
            Eps = new Eps();
            Address = string.Empty;
            ContactNumber = string.Empty;
            ContactName = string.Empty;
        }
    }
}
