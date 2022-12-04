using System.ComponentModel.DataAnnotations;

namespace ImobiliariaAPI
{
    public class TipoImovel
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Tipo { get; set; } = string.Empty;
    }
}
