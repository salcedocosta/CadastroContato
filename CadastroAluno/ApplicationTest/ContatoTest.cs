using Domain;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WebAPI.Controllers;
using NUnit.Extension.DependencyInjection;
using Service.IoC;
using System.Runtime.InteropServices;
using Moq;
using Validations.Contato;
using Microsoft.EntityFrameworkCore.Internal;
using System.Text.RegularExpressions;

namespace ApplicationTest
{
   
    [TestFixture]
    public class ContatoTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("M", "Salcedo", "11-07-1981",38)]       

        public void Add(string sexo, string nome, string dataNascimento, int idade)
        {//
            DateTime nascimento = Convert.ToDateTime(dataNascimento);
            var res = ContatoValidations.ValidateContact(new Contato()
            {
                Sexo = sexo,
                Nome = nome,
                DataNascimento = Convert.ToDateTime(dataNascimento),
                Idade = idade
            });

            int _idade = DateTime.Now.Year - Convert.ToDateTime(dataNascimento).Year;
            if (DateTime.Now.DayOfYear < nascimento.DayOfYear)
            { _idade = _idade - 1; }

            Assert.AreEqual(_idade, idade);
            Assert.AreEqual(EnumValidate.Success, res.Type);
            Assert.IsTrue(nascimento <= DateTime.Now);
            Assert.IsNotEmpty(nome);
        }
        [TestCase("11-07-1981",37)]
        public void VerificarIdade(string data, int idade)
        {
            DateTime aniversario = Convert.ToDateTime(data);
            int _idade = DateTime.Now.Year - Convert.ToDateTime(data).Year;
            if(DateTime.Now.DayOfYear < aniversario.DayOfYear)
            { _idade = _idade - 1; }            
            Assert.AreEqual(_idade, idade);
        }
        [TestCase("11-07-2024")]
        public void VerificarData(DateTime data)
        {
            Assert.IsTrue(data <= DateTime.Now);
        }

       [TestCase("Ricardo Salcedo Costa")]
        public void VerificarNome(string nome)
        {
            Assert.IsNotEmpty(nome);
         
        }
    }
}
