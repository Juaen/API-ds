using System.Collections.Generic;
using System.Text.Json.Serialization;
using RpgApi.Models.Enuns;

namespace RpgApi.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe{ get; set; }

        public byte[] FotoPersonagem { get; set; }
        
        [JsonIgnore]//System.Text.Json.Serialization;
        public Usuario Usuario { get; set; }

        [JsonIgnore]
        public Arma Arma { get; set; }

        public List<PersonagemHabilidade> PersonagemHabilidades { get; set; }

        




    }
}



