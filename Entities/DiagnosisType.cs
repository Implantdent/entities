namespace Entities
{
    /// <summary>
    /// Tipo de diagnóstico realizado en una consulta
    /// </summary>
    public class DiagnosisType
    {
        /// <summary>
        /// Identificador del tipo de diagnóstico
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del tipo de diagnóstico
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del tipo de diagnóstico
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public DiagnosisType()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
