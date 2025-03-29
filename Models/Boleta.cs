namespace CasaDeCambio.Models
{
    public class Boleta
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
    }
}