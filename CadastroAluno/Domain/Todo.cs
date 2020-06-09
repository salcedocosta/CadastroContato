using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Todo : DomainBase
    {
        [Column("Title")]
        public string Title { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Date")]
        public DateTime Date { get; set; }
    }
}
