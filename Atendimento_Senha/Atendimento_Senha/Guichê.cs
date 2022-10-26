using Atendimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_Senha
{
    internal class Guiche
    {
        public int id { get; set; }
        public Queue<Senha> atendimentos{ get; set; }
        Guiches guiches = new Guiches();


        public Guiche()
        {

        }

        public Guiche(int id)
        {
            this.id = id;
           
        }
        
        public bool chamar(Queue<Senha> filaSenhas)
        {
           
            atendimentos = new Queue<Senha>();
                if (filaSenhas.Count > 0)
                {
                    Senha senhaAtendida = filaSenhas.First();
                    senhaAtendida.dataAtend = DateTime.Now;
                    senhaAtendida.horaAtend = DateTime.Now;
                    atendimentos.Enqueue(senhaAtendida);
                    filaSenhas.Dequeue();
                  
                return true;
                }

                else
                {
                    return false;

                }
            }

                 
        }
    }
