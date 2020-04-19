using System;

namespace API.Models
{
    public class OrdemServicoModel
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
        public DateTime? DataEntrada { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Defeito { get; set; }
        public string Descricao { get; set; }
        public string SenhaDesbloqueio { get; set; }
        public decimal? ValorOrcado { get; set; }
        public DateTime? DataSaida { get; set; }

        public virtual ClientesModel IdClienteNavigation { get; set; }
    }
}
