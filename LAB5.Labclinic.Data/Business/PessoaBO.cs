using LAB5.Labclinic.Data.Basic;
using LAB5.Labclinic.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Labclinic.Data.Business
{
    public class PessoaBO
    {
        #region DAO

        private  class DAO : AbstractDAL<Pessoa> { }

        private DAO _DAO = new DAO();

        #endregion

        #region Métodos Básicos

        public Pessoa Get(int id)
        {
            return _DAO.Get(id);
        }

        public List<Pessoa> GetAll()
        {
            return _DAO.GetAll();
        }

        public void Salvar(Pessoa _pessoa)
        {
            try
            {
                if (_pessoa.IdPessoa == 0)
                {
                    _DAO.Add(_pessoa);
                    _DAO.CommitChanges();
                }else
                    {
                        _DAO.Update(_pessoa, _pessoa.IdPessoa);
                    }

            }
            catch (DbUpdateException) { throw new Exceptions.ErroAoAtualizar(_pessoa); }
            catch (Exception) { throw new Exceptions.ErroAoSalvar(_pessoa); }
        }

        #endregion
    }
}
