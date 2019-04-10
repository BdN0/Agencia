using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace POO
{
    public class PontoTuristico
    {
        private DALMysql dao = new DALMysql();
        private int codigo;
        private string descricao, endereco;
        private DateTime data;
        private Cidade cidade = new Cidade();

       
        public string Descricao { get => descricao; set => descricao = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime Data { get => data; set => data = value; }
        public Cidade Cidade { get => cidade; set => cidade = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}