using Domain;
using Repository.IoC;
using Service.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class RastreioService : IRastreioService
    {
        private IRastreioRepository _rastreioRepository;
        
        public RastreioService(IRastreioRepository rastreioRepository)
        {
            _rastreioRepository = rastreioRepository;
        }

        public Validate Add(Rastreio obj)
        {
            //if (true)
            //{
            //    _rastreioRepository.Add(obj);
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return null;
        }

        public Rastreio Get(int id)
        {
            return _rastreioRepository.Get(id);
        }

        public IEnumerable<Rastreio> GetAll()
        {
            return _rastreioRepository.GetAll();
        }

        public void Remove(Rastreio obj)
        {
            _rastreioRepository.Remove(obj);
        }

        public void Update(Rastreio obj)
        {
            _rastreioRepository.Update(obj);
        }
    }
}
