using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using WebApi.Enums;

namespace WebApi.Models
{
    public class FuncionarioModel
    {
            [Key]
            public int Id { get; set; }  
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public DepartamentoEnum Dapartamento { get; set; }
            public bool Ativo { get; set; }
            public TurnoEnum Turno { get; set;}
            public DateTime DataDeCriacao { get; set; } = DateTime.Now;
            public DateTime DataDeAlteracao { get; set; } = DateTime.Now;



    }

}
