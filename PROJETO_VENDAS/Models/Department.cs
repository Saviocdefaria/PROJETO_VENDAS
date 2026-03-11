namespace PROJETO_VENDAS.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Seller>  Sellers { get; set; } = new List<Seller>();
    }
}
