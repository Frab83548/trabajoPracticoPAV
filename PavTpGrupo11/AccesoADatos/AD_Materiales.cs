﻿using PavTpGrupo11.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavTpGrupo11.AccesoADatos
{
    public class AD_Materiales
    {
        ConexionSQL cn = new ConexionSQL();
        public DataTable ConsultarMaterialesDG()
        {
            return cn.ConsultarMaterialesDG();
        }
        public int InsertarMaterial(Material ma)
        {
            return cn.InsertarMaterial(ma);
        }
        public int ModificarMaterial(Material ma)
        {
            return cn.ModificarMaterial(ma);
        }
        public int eliminarMaterial(string Material)
        {
            return cn.eliminarMaterial(Material);
        }

    }
}
