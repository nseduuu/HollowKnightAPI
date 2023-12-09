using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HollowKnightAPI.Models.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace HollowKnightAPI.models
{
    public class Item
    {
        public int Id { get; set; }
        public int IdItem { get; set; }
        public string NomeItem { get; set; }
        public string? FotoItem {get; set;}
        public string? DescricaoItem { get; set; }
        public CategoriaItemEnum CategoriaItem { get; set;}
    }
}