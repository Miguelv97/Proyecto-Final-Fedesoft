namespace Mundial.Utils
{
    using FluentValidation;
    using Mundial.DAL.DTO;

    public class ResultadoValidationDTO: AbstractValidator<ResultadoDTO>
    {
        /// <summary>
        /// Constructor de las validaciones de Resultados
        /// </summary>
        public ResultadoValidationDTO() 
        {

            RuleFor(s => s.Gf).NotEmpty()
                .WithMessage("Goles a favor no puedde ser vacio");

            RuleFor(s => s.Gc).NotEmpty()
                .WithMessage("Goles en contra no puedde ser vacio");

            RuleFor(s => s.NumeroPartido).NotEmpty()
                .WithMessage("Numero de Partidos no puede ser vacio");

            RuleFor(s => s.EquipoId).NotEmpty()
                .WithMessage("Id del Equipo no puede ser vacio");

        }

    }
}
