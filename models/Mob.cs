using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HollowKnightAPI.models.Enuns;
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
        public CategoriaEnum Categoria { get; set;}
    }

    [ApiController]
    [Route("[Controller]")]
    public class MobController : ControllerBase
    {
        private static List<Mob> mobs = new List<Mob>()
        {
            new Mob()  {Id = 1, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 2, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 3, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 4, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 5, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 6, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 7, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 8, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 9, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 10, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 11, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 12, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 13, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 14, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 15, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 16, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 17, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 18, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 19, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 20, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 21, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 22, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 23, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 24, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 25, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 26, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 27, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 28, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 29, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 30, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 31, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 32, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 33, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 34, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 35, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 36, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 37, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 38, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 39, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 40, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 41, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss},
            new Mob()  {Id = 42, Nome = "O Falso Cavaleiro", PontosVida = 105, Forca = 1, Dificultade = "E", Categoria = CategoriaEnum.Boss}

        };

    }

}