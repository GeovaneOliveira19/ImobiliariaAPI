using System.ComponentModel.DataAnnotations;

namespace ImobiliariaAPI
{
    public class Status
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string StatusTipo { get; set; } = string.Empty;
    }
}
