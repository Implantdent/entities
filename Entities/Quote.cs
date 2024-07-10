namespace Entities
{
    /// <summary>
    /// Cotización realizada a un posible paciente
    /// </summary>
    public class Quote : IEntity
    {
        /// <summary>
        /// Identificador de la cotización
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre del paciente
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Nümero de documento del paciente
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Dirección del paciente
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Ciudad de residencia del paciente
        /// </summary>
        public City City { get; set; }

        /// <summary>
        /// Teléfono del paciente
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Correo del paciente
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Fecha de la cotización
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Valoración inicial
        /// </summary>
        public string InitialValoration { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Quote()
        {
            Id = 0;
            Name = string.Empty;
            DocumentNumber = string.Empty;
            Address = string.Empty;
            City = new City();
            Phone = string.Empty;
            Email = string.Empty;
            Date = DateTime.MinValue;
            InitialValoration = string.Empty;
        }
    }
}
