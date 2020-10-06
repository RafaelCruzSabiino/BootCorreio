using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootCorreio.Abstratas;
using BootCorreio.Modelos;
using System.Threading;

namespace BootCorreio.Robo
{
    public class Boot : ConexaoWeb
    {
        private List<string> _listaCeps;
        private InfoEndereco _model;

        public Boot() : base()
        {
            _listaCeps  = new List<string>();
            _model      = new InfoEndereco();
            _listaCeps  = _model.GerarListaCeps();
        }

        public void Start()
        {
            try
            {
                Console.Write(string.Format("Inicio da execução do Boot {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));

                foreach (var Cep in _listaCeps)
                {
                    var Informacao = GetEndereco(Cep);

                    Console.WriteLine("");
                    Console.WriteLine(string.Format("Logradouro: {0}", Informacao.Logradouro));
                    Console.WriteLine(string.Format("Bairro: {0}", Informacao.Bairro));
                    Console.WriteLine(string.Format("Cidade: {0}", Informacao.Cidade));
                    Console.WriteLine(string.Format("Estado: {0}", Informacao.Estado));
                    Console.WriteLine(string.Format("Cep: {0}", Informacao.CEP));
                }

                Console.Write(string.Format("Fim da execução do Boot {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));

                Thread.Sleep(10000);
            }
            catch(Exception e)
            {
                Console.Write(e.ToString());
            }
        }
    }
}
