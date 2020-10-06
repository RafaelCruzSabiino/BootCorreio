using BootCorreio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCorreio.Abstratas
{
    public abstract class ConexaoWeb
    {
        //private Correios _webcorreio;

        public ConexaoWeb()
        {
        }

        public InfoEndereco GetEndereco(string cep)
        {
            InfoEndereco result = new InfoEndereco();

            try
            {
                using (var WebCorreio = new Correios.AtendeClienteClient())
                {
                    var resposta = WebCorreio.consultaCEP(cep);

                    result.Logradouro   = ValidarCampo(resposta.end);
                    result.Bairro       = ValidarCampo(resposta.bairro);
                    result.Cidade       = ValidarCampo(resposta.cidade);
                    result.Estado       = ValidarCampo(resposta.uf);
                    result.CEP          = ValidarCampo(resposta.cep);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }

            return result;
        }

        private string ValidarCampo(string str)
        {
            return string.IsNullOrEmpty(str) ? string.Empty : str.Trim();
        }
    }
}
