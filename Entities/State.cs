namespace Entities
{
    /// <summary>
    /// Departamento de un país
    /// </summary>
    public class State
    {
        /// <summary>
        /// Identificador del departamento
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// País al que pertenece el departamento
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Código del departamento
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del grupo de servicio
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public State()
        {
            Id = 0;
            Country = new Country();
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
