﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get;  set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataUpdate { get; set; }
    }
}
