﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SistemaAlquiler.AccesoDatos;

/*using SistemaAlquiler.AccesoDatos.Interfaces;
using SistemaAlquiler.AccesoDatos.Implementaciones;
using SistemaAlquiler.LogicaNegocio.Interfaces;
using SistemaAlquiler.LogicaNegocio.Implementaciones;*/

namespace SistemaAlquiler.Controladora
{
    public static class Dependencia
    {
        public static void inyectarDependencia(this IServiceCollection servicios, IConfiguration configuracion)
        {
            servicios.AddDbContext<DB_Context>(opciones =>
            {
                opciones.UseNpgsql(configuracion.GetConnectionString("PostgreSQLConnection"));
            });
        }
    }
}