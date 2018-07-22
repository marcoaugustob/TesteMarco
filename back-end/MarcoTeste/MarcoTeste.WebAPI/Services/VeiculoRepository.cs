using MarcoTeste.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarcoTeste.WebAPI.Services
{
    public class VeiculoRepository
    {
        private const string CacheKey = "VeiculoStore";

        public bool SaveVeiculo(Veiculo veiculo)
        {
            var ctx = HttpContext.Current;

            if (ctx != null)
            {
                try
                {
                    var currentData = ((Veiculo[])ctx.Cache[CacheKey]).ToList();
                    currentData.Add(veiculo);
                    ctx.Cache[CacheKey] = currentData.ToArray();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }

            return false;
        }


        public int CountVeiculos()
        {
            var ctx = HttpContext.Current;
            var qtdids = 0;


            if (ctx != null)
            {
                try
                {
                    var currentData = ((Veiculo[])ctx.Cache[CacheKey]).ToList();
                    qtdids = currentData.ToArray().Count();

                    return qtdids;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return 0;
                }
            }

            return 0;
        }
    }
}