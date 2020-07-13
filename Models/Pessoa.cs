using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteIterup.Models
{
    public class Pessoa
    {
        [Key]
        [Column("id")]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório.")]
        [Column("nome")]
        [JsonProperty(PropertyName = "nome")]
        [StringLength(100, ErrorMessage = "Nome é inválido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "CPF é obrigatório")]
        [Column("cpf")]
        [JsonProperty(PropertyName = "cpf")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF inválido.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "UF é obrigatório")]
        [Column("uf")]
        [JsonProperty(PropertyName = "uf")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "UF inválida.")]
        public string Uf { get; set; }
        [Required(ErrorMessage = "Data de nascimento é obrigatório.")]
        [Column("data_nascimento")]
        [JsonProperty(PropertyName = "data_nascimento")]
        [DataType(DataType.Date, ErrorMessage = "Data de nascimento inválida.")]
        public DateTime DataNascimento { get; set; }
    }
}
