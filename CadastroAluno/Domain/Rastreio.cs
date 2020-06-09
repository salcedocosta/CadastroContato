using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("tb_rastreio")]
    public class Rastreio : DomainBase
    {
        [Column("cod_rastreio")]
        public string Codigo { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("dt_cadastro")]
        public DateTime DataCadastro { get; set; }
        [Column("status")]
        public int Status { get; set; }
    }
}
