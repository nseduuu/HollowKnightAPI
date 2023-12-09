using HollowKnightAPI.models;
using HollowKnightAPI.Models.Enuns;

namespace RpgApi.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public int IdPersonagem { get; set; }
        public string NomePersonagem { get; set; } = string.Empty;  

        public List<Item> PersonagemItens { get; set; }

        public List<Mob> Mobs { get; set; }

    }
}