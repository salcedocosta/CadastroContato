using Domain;
using Persistence;
using Repository.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RastreioRepository : Repository<Rastreio>, IRastreioRepository
    {
        Contexto _contexto;
        public RastreioRepository(Contexto context) : base(context)
        {
            _contexto = context;

        }
    }
}
