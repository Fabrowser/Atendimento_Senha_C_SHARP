using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento_Senha
{
    internal class Guiches
    {

        public List<Guiche> listaGuiches { get; set; }

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }
        public void adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
            //MessageBox.Show("GUICHES - " + listaGuiches.Count.ToString());
        }


        public bool ExisteGuiche(int id)
        {
            foreach (Guiche guiche in listaGuiches)
            {
                if (guiche.id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}






