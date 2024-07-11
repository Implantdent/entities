namespace Entities.Test
{
    /// <summary>
    /// Pruebas de creaci�nde las entidades
    /// </summary>
    public class EntitiesTest
    {
        /// <summary>
        /// Prueba la creaci�n de un cap�tulo de la CIE versi�n 10
        /// </summary>
        [Fact]
        public void Create_ChapterCie10_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ChapterCie10>(new ChapterCie10());
        }

        /// <summary>
        /// Prueba la creaci�n de un pa�s
        /// </summary>
        [Fact]
        public void Create_Country_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Country>(new Country());
        }

        /// <summary>
        /// Prueba la creaci�n de un medicamento
        /// </summary>
        [Fact]
        public void Create_Cum_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Cum>(new Cum());
        }

        /// <summary>
        /// Prueba la creaci�n de un destino
        /// </summary>
        [Fact]
        public void Create_DestinyPatient_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<DestinyPatient>(new DestinyPatient());
        }

        /// <summary>
        /// Prueba la creaci�n de un tipo de diagn�stico
        /// </summary>
        [Fact]
        public void Create_DiagnosisType_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<DiagnosisType>(new DiagnosisType());
        }

        /// <summary>
        /// Prueba la creaci�n de un tipo de documento
        /// </summary>
        [Fact]
        public void Create_DocumentType_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<DocumentType>(new DocumentType());
        }

        /// <summary>
        /// Prueba la creaci�n de una causa de atenci�n
        /// </summary>
        [Fact]
        public void Create_ExternalCause_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ExternalCause>(new ExternalCause());
        }

        /// <summary>
        /// Prueba la creaci�n de una forma de entrega de un medicamento
        /// </summary>
        [Fact]
        public void Create_Ffm_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Ffm>(new Ffm());
        }

        /// <summary>
        /// Prueba la creaci�n de una finalidad
        /// </summary>
        [Fact]
        public void Create_Finality_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Finality>(new Finality());
        }

        /// <summary>
        /// Prueba la creaci�n de un formato
        /// </summary>
        [Fact]
        public void Create_Format_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Format>(new Format());
        }

        /// <summary>
        /// Prueba la creaci�n de un g�nero
        /// </summary>
        [Fact]
        public void Create_Genre_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Genre>(new Genre());
        }

        /// <summary>
        /// Prueba la creaci�n de un grupo de CIE10
        /// </summary>
        [Fact]
        public void Create_GroupCie10_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<GroupCie10>(new GroupCie10());
        }

        /// <summary>
        /// Prueba la creaci�n de una v�a de ingreso
        /// </summary>
        [Fact]
        public void Create_IngressVia_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<IngressVia>(new IngressVia());
        }

        /// <summary>
        /// Prueba la creaci�n de un medicamento alternativo
        /// </summary>
        [Fact]
        public void Create_Ium_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Ium>(new Ium());
        }

        /// <summary>
        /// Prueba la creaci�n de un tipo de medicamento
        /// </summary>
        [Fact]
        public void Create_MedicineType_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<MedicineType>(new MedicineType());
        }

        /// <summary>
        /// Prueba la creaci�n de una modalidad
        /// </summary>
        [Fact]
        public void Create_Modality_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Modality>(new Modality());
        }

        /// <summary>
        /// Prueba la creaci�n de un tipo de servicio no establecido
        /// </summary>
        [Fact]
        public void Create_OtherServiceType_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<OtherServiceType>(new OtherServiceType());
        }

        /// <summary>
        /// Prueba la creaci�n de un par�metro
        /// </summary>
        [Fact]
        public void Create_Parameter_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Parameter>(new Parameter());
        }

        /// <summary>
        /// Prueba la creaci�n de un tipo de paciente
        /// </summary>
        [Fact]
        public void Create_PatientType_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<PatientType>(new PatientType());
        }

        /// <summary>
        /// Prueba la creaci�n de un tipo de pago
        /// </summary>
        [Fact]
        public void Create_PaymentType_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<PaymentType>(new PaymentType());
        }

        /// <summary>
        /// Prueba la creaci�n de una pregunta de antecedentes personales
        /// </summary>
        [Fact]
        public void Create_PersonalBackgroundQuestion_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<PersonalBackgroundQuestion>(new PersonalBackgroundQuestion());
        }

        /// <summary>
        /// Prueba la creaci�n de un procedimiento
        /// </summary>
        [Fact]
        public void Create_Procedure_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Procedure>(new Procedure());
        }

        /// <summary>
        /// Prueba la creaci�n de un tipo de pregunta
        /// </summary>
        [Fact]
        public void Create_QuestionType_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<QuestionType>(new QuestionType());
        }

        /// <summary>
        /// Prueba la creaci�n de una relaci�n
        /// </summary>
        [Fact]
        public void Create_Relationship_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Relationship>(new Relationship());
        }

        /// <summary>
        /// Prueba la creaci�n de un servicio
        /// </summary>
        [Fact]
        public void Create_Service_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Service>(new Service());
        }

        /// <summary>
        /// Prueba la creaci�n de un grupo de servicio
        /// </summary>
        [Fact]
        public void Create_ServiceGroup_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ServiceGroup>(new ServiceGroup());
        }

        /// <summary>
        /// Prueba la creaci�n de un departamento
        /// </summary>
        [Fact]
        public void Create_State_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<State>(new State());
        }

        /// <summary>
        /// Prueba la creaci�n de un subgrupo de CIE10
        /// </summary>
        [Fact]
        public void Create_SubGroupCie10_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<SubGroupCie10>(new SubGroupCie10());
        }

        /// <summary>
        /// Prueba la creaci�n de una medida de medicamento
        /// </summary>
        [Fact]
        public void Create_Umm_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Umm>(new Umm());
        }

        /// <summary>
        /// Prueba la creaci�n de una medida m�mima de medicamento dispensada
        /// </summary>
        [Fact]
        public void Create_Upr_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Upr>(new Upr());
        }

        /// <summary>
        /// Prueba la creaci�n de un usuario
        /// </summary>
        [Fact]
        public void Create_User_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<User>(new User());
        }

        /// <summary>
        /// Prueba la creaci�n de una zona
        /// </summary>
        [Fact]
        public void Create_ZoneType_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ZoneType>(new ZoneType());
        }

        /// <summary>
        /// Prueba la creaci�n de una enfermedad
        /// </summary>
        [Fact]
        public void Create_Cie10_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Cie10>(new Cie10());
        }

        /// <summary>
        /// Prueba la creaci�n de una ciudad
        /// </summary>
        [Fact]
        public void Create_City_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<City>(new City());
        }

        /// <summary>
        /// Prueba la creaci�n de una pregunta de historia cl�nica
        /// </summary>
        [Fact]
        public void Create_ClinicHistoryQuestion_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ClinicHistoryQuestion>(new ClinicHistoryQuestion());
        }

        /// <summary>
        /// Prueba la creaci�n de un m�dico
        /// </summary>
        [Fact]
        public void Create_Doctor_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Doctor>(new Doctor());
        }

        /// <summary>
        /// Prueba la creaci�n de un estado civil
        /// </summary>
        [Fact]
        public void Create_CivilState_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<CivilState>(new CivilState());
        }

        /// <summary>
        /// Prueba la creaci�n de un paciente
        /// </summary>
        [Fact]
        public void Create_Patient_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Patient>(new Patient());
        }

        /// <summary>
        /// Prueba la creaci�n de una historia cl�nica
        /// </summary>
        [Fact]
        public void Create_ClinicHistory_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ClinicHistory>(new ClinicHistory());
        }

        /// <summary>
        /// Prueba la creaci�n de una urgencia
        /// </summary>
        [Fact]
        public void Create_Emergency_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Emergency>(new Emergency());
        }

        /// <summary>
        /// Prueba la creaci�n de un antecedente familiar
        /// </summary>
        [Fact]
        public void Create_FamilyBackground_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<FamilyBackground>(new FamilyBackground());
        }

        /// <summary>
        /// Prueba la creaci�n de un medicamento
        /// </summary>
        [Fact]
        public void Create_Medicine_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Medicine>(new Medicine());
        }

        /// <summary>
        /// Prueba la creaci�n de una respuesta de antecedente personal
        /// </summary>
        [Fact]
        public void Create_PersonalBackgroundAnswer_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<PersonalBackgroundAnswer>(new PersonalBackgroundAnswer());
        }

        /// <summary>
        /// Prueba la creaci�n de un procedimiento a un paciente
        /// </summary>
        [Fact]
        public void Create_ProcedureToPatient_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<ProcedureToPatient>(new ProcedureToPatient());
        }

        /// <summary>
        /// Prueba la creaci�n de una consulta a un paciente
        /// </summary>
        [Fact]
        public void Create_Query_Okt()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Query>(new Query());
        }

        /// <summary>
        /// Prueba la creaci�n de una cotizaci�n
        /// </summary>
        [Fact]
        public void Create_Quote_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Quote>(new Quote());
        }

        /// <summary>
        /// Prueba la creaci�n de un rol
        /// </summary>
        [Fact]
        public void Create_Role_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<Role>(new Role());
        }

        /// <summary>
        /// Prueba la creaci�n de un log de base de datos
        /// </summary>
        [Fact]
        public void Create_LogDb_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<LogDb>(new LogDb());
        }

        /// <summary>
        /// Prueba la creaci�n de un log de componentes
        /// </summary>
        [Fact]
        public void Create_LogComponent_Ok()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsType<LogComponent>(new LogComponent());
        }
    }
}