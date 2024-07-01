namespace Entities
{
    /// <summary>
    /// Vía de ingreso de un paciente
    /// </summary>
    public class IngressVia
    {
        /// <summary>
        /// Identificador de la vía de ingreso
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código de la vía de ingreso
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre de la vía de ingreso
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public IngressVia()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
