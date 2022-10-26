using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Atendimento
{
    public class Senha
    {

        public int id { get; set; }
        public DateTime dataGerac { get; set; }
        public DateTime horaGerac { get; set; }
        public DateTime dataAtend { get; set; }
        public DateTime horaAtend { get; set; }

        public Senha()
        {
            
        }

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now;
        }

        public Senha(int id, DateTime DataAtend, DateTime HoraAtend)
        {    
            this.id = id;
        }


        public string dadosParciais()
        {
    
            return  id+"-" + "Data Geração: " +
                    dataGerac.Day + 
                    "/" + dataGerac.Month + 
                    "/" + dataGerac.Year + 
                    " | " +
                    "Hora Geração: " + 
                    horaGerac.Hour+
                    ":"+horaGerac.Minute+
                    ":"+horaGerac.Second;
        }
        public string dadosCompletos()
        {
            return  "Senha: " + id + " - Data Ger: " +
                    dataGerac.Day +
                    "/" + dataGerac.Month +
                    "/" + dataGerac.Year +
                    " | " +
                    "Hora Ger: " +
                    horaGerac.Hour +
                    ":" + horaGerac.Minute +
                    ":" + horaGerac.Second +
                    " | " +
                    "\nHora Atend: " +
                    horaAtend.Hour +
                    ":" + horaAtend.Minute +
                    ":" + horaAtend.Second;
        }
    }
}
