namespace Entities
{
    /// <summary>
    /// Estado civil de un paciente
    /// </summary>
    public class CivilState
    {
        /// <summary>
        /// Identificador del estado civil
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Nombre del estado civil
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public CivilState()
        {
            Id = 0;
            Name = string.Empty;
        }
    }
}
