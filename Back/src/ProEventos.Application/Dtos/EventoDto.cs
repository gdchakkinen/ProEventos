
using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório."),
         MinLength(3, ErrorMessage ="{0} deve conter no minimo 3 caracteres."),
         MaxLength(50, ErrorMessage ="{0} deve conter no maximo 50 caracteres.")]
        public string Tema { get; set; }

        [Display(Name ="Qtd Pessoas"),
         Range(1, 12000, ErrorMessage ="{0} não pode ser menor que 1 e maior que 12.000")]
        public int QtdPessoas { get; set; }
        
        [RegularExpression(@".*\.(gif|jpeg?g|bmp|png)$", ErrorMessage ="Não é um imagem válida. (jpeg/jpg, png, bmp ou gif)")]
        public string ImagemURL { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório."),
         Phone(ErrorMessage ="Informe um {0} válido.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório."),
         Display(Name ="e-mail"), //formata o nome do campo Email para e-mail
         EmailAddress(ErrorMessage ="O campo {0} precisa ser um e-mail válido.")]
        public string Email { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestranteEventos { get; set; }
    }
}
