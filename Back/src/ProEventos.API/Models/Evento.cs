using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemURL { get; set; }

        public Evento()
        {

        }

        public Evento(int eventoId, string local, string dataEvento, string tema, int qtdPessoas, string lote, string imagemURL)
        {
            EventoId = eventoId;
            Local = local;
            DataEvento = dataEvento;
            Tema = tema;
            QtdPessoas = qtdPessoas;
            Lote = lote;
            ImagemURL = imagemURL;
        }
    }
}