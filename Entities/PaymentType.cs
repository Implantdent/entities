namespace Entities
{
    /// <summary>
    /// Tipo de pago realizado por el paciente
    /// </summary>
    public class PaymentType
    {
        /// <summary>
        /// Identificador del tipo de pago
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del tipo de pago
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del tipo de pago
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public PaymentType()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
