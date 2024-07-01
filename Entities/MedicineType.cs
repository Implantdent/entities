namespace Entities
{
    /// <summary>
    /// Tipo de medicamento
    /// </summary>
    public class MedicineType
    {
        /// <summary>
        /// Identificador del tipo de medicamento
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Código del tipo de medicamento
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Nombre del tipo de medicamento
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public MedicineType()
        {
            Id = 0;
            Code = string.Empty;
            Name = string.Empty;
        }
    }
}
