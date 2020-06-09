using Domain;
using Persistence;
using Repository.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    public class ContatoRepository : Repository<Contato>, IContatoRepository
    {
        Contexto _contexto;

        public ContatoRepository(Contexto context) : base(context)
        {
            _contexto = context;
        }
      
    }
}
