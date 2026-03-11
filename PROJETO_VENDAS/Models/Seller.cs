namespace PROJETO_VENDAS.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public int DepartmentId { get; set; }   // Chave estrangeira 
        public Department Department { get; set; }  // propriedade de navegação
        public List<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();  // Ligação de n para muitos


    }
}
