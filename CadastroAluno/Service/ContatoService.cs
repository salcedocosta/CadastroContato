using Domain;
using Microsoft.Data.SqlClient;
using Repository.IoC;
using Service.IoC;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Validations.Contato;


namespace Service
{
    public class ContatoService : IContatoService
    {
        private IContatoRepository _contatoRepository;
        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public Validate Add(Contato obj)
        {
            var val = ContatoValidations.ValidateContact(obj);

            if (val.Type == EnumValidate.Success)
            {
                _contatoRepository.Add(obj);
            }

            return val;
        }

        public Contato Get(int id)
        {
            return _contatoRepository.Get(id);
        }

        public IEnumerable<Contato> GetAll()
        {
            return _contatoRepository.GetAll();
        }

        public void Remove(Contato obj)
        {
            _contatoRepository.Remove(obj);
        }

        public void Update(Contato obj)
        {
            _contatoRepository.Update(obj);
        }
    }
}
