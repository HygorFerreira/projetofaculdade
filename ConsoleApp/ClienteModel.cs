using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ClienteModel
    {
        private int _id = 0;
        private string _nome = "";
        private string _endereco = "";
        private string _bairro = "";
        private string _cidade = "";
        private string _estado = "";
        private string _CEP = "";
        private string _CPF = "";
        private DateTime _dataNascimento = DateTime.MinValue;
        private string _telefone = "";
        private string _email = "";

        public int ID { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string CEP { get => _CEP; set => _CEP = value; }
        public string CPF { get => _CPF; set => _CPF = value; }
        public DateTime DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string eMail { get => _email; set => _email = value; }
    }
}
