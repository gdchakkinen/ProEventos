using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    //[Table("EventosDetalhes")] Muda nome da migration
    public class Evento
    {
        public int Id { get; set; } //usa-se "Id" por convenção, mas pode ser usado qualquer nome. Basta apenas utilizar o DTO [Key]
        public string Local { get; set; }
        public string DataEvento { get; set; }
        //[NotMapped] exclui da migration
        //public int ContagemDias { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestranteEventos { get; set; }
    }
}