using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteIterup.Models
{
    public class Usuario
    {
        [Key]
        [Column("id")]
        [JsonProperty("id")]
        public int Id { get; set; }
        [Required]
        [Column("email")]
        [JsonProperty("email")]
        public string Email { get; set; }
        [Required]
        [Column("senha")]
        [JsonProperty("senha")]
        public string Senha { get; set; }
    }
}
