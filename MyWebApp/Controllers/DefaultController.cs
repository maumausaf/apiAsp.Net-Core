using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Acesso_Dados;
using MyWebApp.Entidades;

namespace MyWebApp.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        
        private readonly IProdutoRepository _produtoRepository;

        public  ProdutoController(IProdutoRepository produtoRepository)
        {
       
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepository.ListarProdutos());
            }
            catch(Exception e)
            {
                return BadRequest("Erro: "+ e.Message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var produto = _produtoRepository.ObeterById(id);
                return Ok(produto);
            }catch (Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                _produtoRepository.Isert(produto);
                return Created("/api/produto",produto);

            }catch(Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            
            if (id != produto.id) {
               return BadRequest("Erro: Id Informado não pertence ao Objeto");
            }
            try
            {

                _produtoRepository.UpdateAll(produto);
                return Ok("Atualização realizada");

            }catch(Exception e)
            {
                return BadRequest($"Erro:{e.Message}");
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {   
                _produtoRepository.Detele(id);
                return Ok("Success");
            }
            catch(Exception e)
            {
                return BadRequest($"Erro: {e.Message}");
            }
        }



    }
}