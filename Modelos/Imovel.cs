using System.ComponentModel.DataAnnotations;

namespace ImobiliariaAPI
{
    public class Imovel
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(200)]
        public string Comentarios { get; set; } = string.Empty;

        public int Tipo { get; set; }

        public TipoImovel? TipoImovel { get; set; }
    }
}
