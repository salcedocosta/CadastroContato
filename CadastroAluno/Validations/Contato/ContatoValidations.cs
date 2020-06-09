using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Validations.Contato
{
    public static class ContatoValidations
    {
        public static Validate ValidateContact(Domain.Contato obj) {
            if(obj.Nome.Length > 100)
            {
                return new Validate() { Type = EnumValidate.Error, Message = "Nome muito longo!" };
            } 
            else if(obj.Sexo != "F" && obj.Sexo != "M")
            {
                return new Validate() { Type = EnumValidate.Error, Message = "O sexo não é válido!" };
            }
            else
            {
                return new Validate() { Type = EnumValidate.Success, Message = "O usuário foi cadastrado!" };
            }
        }
    }
}
