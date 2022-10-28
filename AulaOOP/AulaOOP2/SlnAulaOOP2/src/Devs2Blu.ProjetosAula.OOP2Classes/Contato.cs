﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP2Classes
{
    public class Contato
    {
        public String Nome { get; set; }
        public String TelCel { get; set; }
        public String Email { get; set; }
        public String CEP { get; set; }
        public String Rua { get; set; }
        public Int32 Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }

        public Contato(){}

        public Contato(String nome, String telCel, String email, String cep, String rua, Int32 numero, String bairro, String cidade, String estado)
        {
            Nome = nome;
            Email = email;
            TelCel = telCel;
            CEP = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
