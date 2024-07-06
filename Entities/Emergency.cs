namespace Entities
{
    /// <summary>
    /// Atención de urgencia de un paciente
    /// </summary>
    public class Emergency
    {
        /// <summary>
        /// Identificador de la urgencia
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Paciente al que se le realiza la urgencia
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Fecha de ingreso a la urgencia
        /// </summary>
        public DateTime DateIn { get; set; }

        /// <summary>
        /// Fecha de egreso a la urgencia
        /// </summary>
        public DateTime DateOut { get; set; }

        /// <summary>
        /// Causa o motivo de la urgencia
        /// </summary>
        public ExternalCause ExternalCause { get; set; }

        /// <summary>
        /// Diagnóstico principal al ingresar
        /// </summary>
        public Cie10 MainDiagnosis { get; set; }

        /// <summary>
        /// Diagnóstico principal al egresar
        /// </summary>
        public Cie10 MainDiagnosisEgress { get; set; }

        /// <summary>
        /// Diagnóstico relacionado 1
        /// </summary>
        public Cie10 RelatedDiagnosis1 { get; set; }

        /// <summary>
        /// Diagnóstico relacionado 2
        /// </summary>
        public Cie10 RelatedDiagnosis2 { get; set; }

        /// <summary>
        /// Diagnóstico relacionado 3
        /// </summary>
        public Cie10 RelatedDiagnosis3 { get; set; }

        /// <summary>
        /// Destino del paciente luego de salir de urgencias
        /// </summary>
        public DestinyPatient DestinyPatient { get; set; }

        /// <summary>
        /// Diagnóstico de la muerte del paciente si ocurre
        /// </summary>
        public Cie10 DeathDiagnosis { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Emergency()
        {
            Id = 0;
            Patient = new Patient();
            DateIn = DateTime.MinValue;
            DateOut = DateTime.MinValue;
            ExternalCause = new ExternalCause();
            MainDiagnosis = new Cie10();
            MainDiagnosisEgress = new Cie10();
            RelatedDiagnosis1 = new Cie10();
            RelatedDiagnosis2 = new Cie10();
            RelatedDiagnosis3 = new Cie10();
            DestinyPatient = new DestinyPatient();
            DeathDiagnosis = new Cie10();
        }
    }
}
