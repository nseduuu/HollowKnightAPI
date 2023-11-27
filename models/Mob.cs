using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HollowKnightAPI.Models.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace HollowKnightAPI.models
{
    public class Mob
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public string Dificultade { get; set; }
        public string Localizacao { get; set; }
        public string Lore { get; set; }
        
        //public byte Foto {get; set;}
        public CategoriaEnum Categoria { get; set;}
    }
}