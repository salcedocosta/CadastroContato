using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("tb_contato")]
    public class Contato : DomainBase
    {
        [Column("nm_contato")]
        public string Nome { get; set; }
        [Column("dt_nascimento")]
        public DateTime DataNascimento{ get; set; }
        [Column("sexo")]
        public string Sexo { get; set; }
        [Column("idade")]
        public int Idade { get; set; }
    }
}
