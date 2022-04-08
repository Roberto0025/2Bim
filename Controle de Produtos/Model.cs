using System;
using System.Collections.Generic;
using System.Linq;

namespace Controle_de_Produtos
{
    public class Model
    {
        internal void SetUsuario(DtoUsuario u)
        {
            Context context = new Context();
            context.usuario.Add(u);
            context.SaveChanges();
        }
        public List<DtoUsuario2> GetUsuarios()
        {
            Context db = new Context();

            List<DtoUsuario2> usuario = (from u in db.usuario
                                 select new DtoUsuario2
                                 {
                                     id = u.id,
                                     nome = u.nome
                                 }).ToList();
            return usuario;
        }
        public DtoUsuario GetUsuario(int id)
        {
            Context db = new Context();
            DtoUsuario user = db.usuario.FirstOrDefault(p => p.id == id);
            return user;
        }
        internal void AlterarUsuario(DtoUsuario u)
        {
            Context db = new Context();
            DtoUsuario user = db.usuario.FirstOrDefault(p => p.id == u.id);
            user.nome = u.nome;
            user.login = u.login;
            user.senha = u.senha;
            db.SaveChanges();
        }

        internal DtoProduto GetProdutoId(int v)
        {
            Context db = new Context();
            DtoProduto prod = db.produto.FirstOrDefault(p => p.id == v);
            return prod;
        }

        internal void delUsuario(int id)
        {
            Context db = new Context();
            DtoUsuario user = db.usuario.FirstOrDefault(p => p.id == id);
            db.usuario.Remove(user);
            db.SaveChanges();
        }

        //===========================
        internal void SetProduto(DtoProduto p)
        {
            Context context = new Context();
            context.produto.Add(p);
            context.SaveChanges();
        }

        public List<DtoProduto2> GetProdutos()
        {
            Context db = new Context();

            List<DtoProduto2> prod = (from p in db.produto
                                     select new DtoProduto2
                                     {
                                         id = p.id,
                                         nome = p.nome,
                                         valorcompra = p.valorcompra,
                                         valorvenda = p.valorvenda,
                                         quantidade = p.quantidade,
                                         unidade = p.unidade
                                     }).ToList();
            return prod;
        }

        public DtoProduto GetProduto(int id)
        {
            Context db = new Context();
            DtoProduto prod = db.produto.FirstOrDefault(p => p.id == id);
            return prod;
        }
        internal void AlterarProduto(DtoProduto produto)
        {
            Context db = new Context();
            DtoProduto prod = db.produto.FirstOrDefault(p => p.id == produto.id);
            prod.nome = produto.nome;
            prod.valorvenda = produto.valorvenda;
            prod.valorcompra = produto.valorcompra;
            prod.quantidade = produto.quantidade;
            prod.unidade = produto.unidade;
            db.SaveChanges();
        }
        internal void delProduto(int id)
        {
            Context db = new Context();
            DtoProduto prod = db.produto.FirstOrDefault(p => p.id == id);
            db.produto.Remove(prod);
            db.SaveChanges();
        }
    }
}
