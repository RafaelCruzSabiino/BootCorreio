using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCorreio.Modelos
{
    public class InfoEndereco
    {
        public string CEP           { get; set; }
        public string Logradouro    { get; set; }
        public string Bairro        { get; set; }
        public string Cidade        { get; set; }
        public string Estado        { get; set; }

        public List<string> ListaCeps;

        public InfoEndereco()
        {
            CEP         = string.Empty;
            Logradouro  = string.Empty;
            Bairro      = string.Empty;
            Cidade      = string.Empty;
            Estado      = string.Empty;
            ListaCeps   = new List<string>();
        }

        public List<string> GerarListaCeps()
        {
            ListaCeps.Add("17213540");
            ListaCeps.Add("17213530");
            ListaCeps.Add("17213520");
            ListaCeps.Add("17213570");
            ListaCeps.Add("17213580");

            return ListaCeps;
        }
    }
}
