using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Services
{
    public class Myservice : IMyService
    {
        public string Saudacao(string nome)
        {
            return $"Bem-vindo, {nome} \n\n {DateTime.Now}";
        }
    }
}
