namespace Entities
{
    /// <summary>
    /// Destino del paciente luego de salir de urgencias u hospitalización
    /// </summary>
    public class DestinyPatient
    {
        /// <summary>
        /// Identificador del destino
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del destino
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del destino
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public DestinyPatient()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
