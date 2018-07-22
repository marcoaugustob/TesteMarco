using MarcoTeste.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarcoTeste.WebAPI.Services
{
    public class MotoristaRepository
    {
        public Motorista[] GetAllDrivers()
        {
            return new Motorista[]
            {
            new Motorista
            {
                Id = 1,
                Nome = "Marco A"
            },
            new Motorista
            {
                Id = 2,
                Nome = "Augusto B"
            },
            new Motorista
            {
                 Id = 3,
                 Nome = "Bonfim C"
            }
            };
        }
    }
}