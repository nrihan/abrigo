using System;

namespace Asylum.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string FiliacaoMae { get; set; }
        public string FiliacaoPai { get; set; }
        public string NumeroSUS { get; set; }
        public string LocalDeAcomodacao { get; set; }
        public string TipoDeBeneficio { get; set; }
        public string GrauDeDependencia { get; set; }
        public string Observacao { get; set; }
    }
}
