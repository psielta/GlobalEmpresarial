using System.Globalization;
using GlobalEmpresarial.Core.Models;

namespace GlobalEmpresarial.Test;

public class Program
{
    public static void Main(string[] args)
    {
        using (var context = new GlobalErpDivisaContext()) // Substitua "YourDbContext" pelo nome do seu DbContext
        {
            // Consulta para obter todos os registros da tabela Person.Person
            var produtos =
                context.ProdutoEstoques
                    .ToList(); // Certifique-se de que o nome da propriedade corresponde ao DbSet no seu DbContext

            foreach (var produto in produtos)
            {
                Console.WriteLine(
                    $"[ID={produto.CdProduto}, Nome={produto.NmProduto}, Valor={produto.VlAVista.ToString():C}]");
            }
        }
    }
}