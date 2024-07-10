namespace Entities
{
    /// <summary>
    /// Consulta ejecutada sobre un paciente
    /// </summary>
    public class Query : IEntity
    {
        /// <summary>
        /// Identificador de la consulta
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Paciente al que se le realiza la consulta
        /// </summary>
        public Patient Patient { get; set; }

        /// <summary>
        /// Fecha de la consulta
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Procedimiento realizado al paciente
        /// </summary>
        public Procedure Procedure { get; set; }

        /// <summary>
        /// Modalidad de atención al paciente
        /// </summary>
        public Modality Modality { get; set; }

        /// <summary>
        /// Grupo de servicios al que pertenece la consulta
        /// </summary>
        public ServiceGroup ServiceGroup { get; set; }

        /// <summary>
        /// Servicio prestado al paciente
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Finalidad de la consulta
        /// </summary>
        public Finality Finality { get; set; }

        /// <summary>
        /// Causa por la que se realiza la consulta
        /// </summary>
        public ExternalCause ExternalCause { get; set; }

        /// <summary>
        /// Diagnóstico principal por el cual se realiza la consulta
        /// </summary>
        public Cie10 MainDiagnosis { get; set; }

        /// <summary>
        /// Diagnóstico relacionado 1 por el cual se realiza la consulta
        /// </summary>
        public Cie10 RelatedDiagnosis1 { get; set; }

        /// <summary>
        /// Diagnóstico relacionado 2 por el cual se realiza la consulta
        /// </summary>
        public Cie10 RelatedDiagnosis2 { get; set; }

        /// <summary>
        /// Diagnóstico relacionado 3 por el cual se realiza la consulta
        /// </summary>
        public Cie10 RelatedDiagnosis3 { get; set; }

        /// <summary>
        /// Tipo de diagnóstico de la consulta
        /// </summary>
        public DiagnosisType DiagnosisType { get; set; }

        /// <summary>
        /// Médico que realiza el procedimiento
        /// </summary>
        public Doctor Doctor { get; set; }

        /// <summary>
        /// Inicializa el objeto con valores por defecto
        /// </summary>
        public Query()
        {
            Id = 0;
            Patient = new Patient();
            Date = DateTime.Now;
            Procedure = new Procedure();
            Modality = new Modality();
            ServiceGroup = new ServiceGroup();
            Service = new Service();
            Finality = new Finality();
            ExternalCause = new ExternalCause();
            MainDiagnosis = new Cie10();
            RelatedDiagnosis1 = new Cie10();
            RelatedDiagnosis2 = new Cie10();
            RelatedDiagnosis3 = new Cie10();
            DiagnosisType = new DiagnosisType();
            Doctor = new Doctor();
        }
    }
}
