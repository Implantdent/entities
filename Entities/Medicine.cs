namespace Entities
{
    /// <summary>
    /// Medicamento recetado a un paciente
    /// </summary>
    public class Medicine : IEntity
    {
        /// <summary>
        /// Identificador del medicamento
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Paciente al que pertenece el medicamento
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Fecha en que se recetó el medicamento
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Diagnóstico principal por el que se receta el medicamento
        /// </summary>
        public Cie10 MainDiagnosis { get; set; }

        /// <summary>
        /// Diagnóstico relacionado por el que se receta el medicamento
        /// </summary>
        public Cie10 RelatedDiagnosis { get; set; }

        /// <summary>
        /// Tipo de medicamento recetado
        /// </summary>
        public MedicineType MedicineType { get; set; }

        /// <summary>
        /// Identificador del medicamento recetado
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// Identificador del tipo de identificador del medicamento (0: CUM, 1: IUM)
        /// </summary>
        public bool IdentifierType { get; set; }

        /// <summary>
        /// Unidad de medida del medicamento
        /// </summary>
        public Umm MeasureUnit { get; set; }

        /// <summary>
        /// Tipo de empaque del medicamento
        /// </summary>
        public Ffm PackType { get; set; }

        /// <summary>
        /// Cantidad de medicamento recetada
        /// </summary>
        public short Quantity { get; set; }

        /// <summary>
        /// Cantidad de días por las que debe consumir el medicamento
        /// </summary>
        public short Days { get; set; }

        /// <summary>
        /// Médico que receta el medicamento
        /// </summary>
        public Doctor Doctor { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Medicine()
        {
            Id = 0;
            Patient = new Patient();
            Date = DateTime.MinValue;
            MainDiagnosis = new Cie10();
            RelatedDiagnosis = new Cie10();
            MedicineType = new MedicineType();
            Identifier = string.Empty;
            IdentifierType = false;
            MeasureUnit = new Umm();
            PackType = new Ffm();
            Quantity = 0;
            Days = 0;
            Doctor = new Doctor();
        }
    }
}
