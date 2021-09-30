namespace projeto1
{
    public interface ILoja
    {
        int Id { get; set; }

        string NomeLoja { get; set; }
        string Segmento { get; set; }

        string NomeProduto { get; set; }

        double PrecoProduto { get; set; }

        public void CadastrarProdutos() { }
    }
}