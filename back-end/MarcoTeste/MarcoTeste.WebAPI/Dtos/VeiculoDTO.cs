using MarcoTeste.WebAPI.Models;
using System;

namespace MarcoTeste.WebAPI.Dtos
{
    public class VeiculoDTO
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Frota { get; set; }
        public bool Propriedade { get; set; }
        public string TipoVeiculo { get; set; }
        public string TipoCarroceria { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo { get; set; }
        public string Pais { get; set; }
        public string CidadeUF { get; set; }
        public float? Tara { get; set; }
        public float? CapacidadeCarga { get; set; }
        public float? Cubagem { get; set; }
        public string Proprietario { get; set; }
        public int? MotoristaId { get; set; }

        public virtual Motorista Motorista { get; set; }
    }
}