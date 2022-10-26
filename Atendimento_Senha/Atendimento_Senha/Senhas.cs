using Atendimento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento_Senha
{
    internal class Senhas
    {
        public int proximoAtendimento { get; set; }

        public Queue<Senha> fila;

        public Senhas()
        {
            fila = new Queue<Senha>();
            proximoAtendimento = 1;
        }
        public void gerar(Senha senha)
        {
            fila.Enqueue(senha);
            proximoAtendimento++;
        }
    }
}
