using MyWebApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Acesso_Dados
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyWebAppContext _myWebAppContext;        

        public  ProdutoRepository(MyWebAppContext myWebAppContext)
        {
            _myWebAppContext = myWebAppContext;
        }
        //delete
        public void Detele(int id)
        {            
            var item = this.ObeterById(id);
            _myWebAppContext.Remove(item);
            _myWebAppContext.SaveChanges();
        }
        //getItens
        public List<Produto> ListarProdutos()
        {
            return _myWebAppContext.Produtos.ToList();
        }
        //getIten
        public Produto ObeterById(int id)
        {
            return _myWebAppContext.Produtos.FirstOrDefault(p => p.id == id);
        }
        //Insert
        public void Isert(Produto produto)
        {
            _myWebAppContext.Produtos.Add(produto);
            _myWebAppContext.SaveChanges();
        }
        //Update
        public void UpdateAll(Produto produto)
        {
            _myWebAppContext.Update(produto);
            _myWebAppContext.SaveChanges();

        }
    }
}
