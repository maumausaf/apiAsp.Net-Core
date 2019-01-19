using System.Collections.Generic;
using MyWebApp.Entidades;

namespace MyWebApp.Acesso_Dados
{
    public interface IProdutoRepository
    {
        List<Produto> ListarProdutos();
        Produto ObeterById(int id);
        void Isert(Produto produto);
        void UpdateAll(Produto produto);
        void Detele(int id);
    }
}