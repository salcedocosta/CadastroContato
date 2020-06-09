using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class DomainBase
    {
        [Key]
        public int Id { get; set; }
    }
}
