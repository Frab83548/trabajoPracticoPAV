﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.Entidades
{
    public class Barrio
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public Barrio(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
