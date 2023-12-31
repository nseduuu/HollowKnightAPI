using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HollowKnightAPI.Models.Enuns;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace HollowKnightAPI.models
{
    public class Mob
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? PontosVida { get; set; }
        public int? Forca { get; set; }
        public string? Dificultade { get; set; }
        public string? Localizacao { get; set; }
        public string? Lore { get; set; }
        public string? Foto {get; set;}
        
        // public List<Item> MobItens { get; set; }
        public CategoriaEnum Categoria { get; set;}
    }
}