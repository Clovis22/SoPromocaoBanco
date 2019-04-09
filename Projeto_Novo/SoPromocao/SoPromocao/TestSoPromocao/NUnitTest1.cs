using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using SoPromocao.Models;

namespace SoPromocao.TestSoPromocao
{
    [TestFixture]
    public class NUnitTest1
    {
        private readonly ADMINISTRADOR _Administrador;

        public NUnitTest1()
        {
            _Administrador = new ADMINISTRADOR();
        }

        [Test]
        public bool validarRg()
        {
            string _rg = Convert.ToString(_Administrador.RG_A);
            if (_rg.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            throw new NotImplementedException("RG inválido, informe somente números");
        }

        [Test]
        public bool validarNome()
        {
            if (_Administrador.NOME.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            throw new NotImplementedException("Nome inválido, o nome não pode conter números");
        }

        [Test]
        public bool validarSobrenome()
        {
            if (_Administrador.SOBRENOME.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            throw new NotImplementedException("Sobrenome inválido, o sobrenome não pode conter números");
        }

        [Test]
        public bool validarSenha()
        {
            if(_Administrador.SENHA.Length >= 6)
               return true;
            throw new NotImplementedException("Senha inválida, informe uma senha com no mínimo 6 dígitos");
        }
        
        [Test]
        public bool validarEmail()
        {
            bool validarEmail = false;
            int indexArray = _Administrador.EMAIL.IndexOf('@');
            if (indexArray > 0)
            {
                int indexDot = _Administrador.EMAIL.IndexOf('.', indexArray);
                if (indexDot - 1 > indexArray)
                {
                    if (indexDot + 1 < _Administrador.EMAIL.Length)
                    {
                        string indexDot2 = _Administrador.EMAIL.Substring(indexDot + 1, 1);
                        if (indexDot2 != ".")
                            validarEmail = true;
                        
                    }
                }
                return validarEmail;
            }
            throw new NotImplementedException("Email inválido, informe no formato myemail@example.com");
        }

    }
}