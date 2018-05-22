using Promobusque.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobusque.Aplicacao
{ 
    public class EmpresaAplicacao
    {
        private DbSet<Empresa> EmpresaRepositorio;
        
        public bool Gravar(EmpresaModelo empresaModelo)
        {
            using (var contexto = new Contexto())
            {
                var empresa = new Empresa
                {
                    Celular = empresaModelo.Celular,
                    Cep = empresaModelo.Cep,
                    Cidade = empresaModelo.Cidade,
                    Cnpj = empresaModelo.Cnpj,
                    Id = empresaModelo.Id,
                    Endereco = empresaModelo.Endereco,
                    Estado = empresaModelo.Estado,
                    Site = empresaModelo.Site,
                    IdUsuario = empresaModelo.IdUsuario,
                    RazaoSocial = empresaModelo.RazaoSocial,
                    Telefone = empresaModelo.Telefone,
                    Logo = empresaModelo.Logo
                };

                if (empresaModelo.Id == 0)
                {
                    empresa.DataCadastro = DateTime.Now;
                    contexto.Empresa.Add(empresa);
                }
                else
                {
                    var objeto = EmpresaRepositorio.SingleOrDefault(e => e.Id == empresaModelo.Id);
                    objeto.IdUsuario = empresaModelo.IdUsuario;
                    objeto.Logo = empresaModelo.Logo;
                    objeto.RazaoSocial = empresaModelo.RazaoSocial;
                    objeto.Site = empresaModelo.Site;
                    objeto.Telefone = empresaModelo.Telefone;
                    objeto.Celular = empresaModelo.Celular;
                    objeto.Cep = empresaModelo.Cep;
                    objeto.Cidade = empresaModelo.Cidade;
                    objeto.Endereco = empresaModelo.Endereco;
                    objeto.Estado = empresaModelo.Estado;
                }

                contexto.SaveChanges();
                return true;
            }
        }
    }
}
