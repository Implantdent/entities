namespace Entities
{
    /// <summary>
    /// Ciudad de un departamento de un país
    /// </summary>
    public class City
    {
        /// <summary>
        /// Identificador de la ciudad
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Departamento al que pertenece la ciudad
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Código de la ciudad
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la ciudad
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public City()
        {
            Id = 0;
            State = new State();
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
