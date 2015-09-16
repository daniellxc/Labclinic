using LAB5.Labclinic.Data.Basic;
using LAB5.Labclinic.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5.Labclinic.Data.Business
{
    public class ProfissionalBO
    {
        #region DAO

        private class DAO : AbstractDAL<Profissional> { }

        private DAO _DAO = new DAO();

        #endregion

        #region Métodos Básicos

        public Profissional Get(int id)
        {
            return _DAO.Get(id);
        }

        public List<Profissional> GetAll()
        {
            return _DAO.GetAll();
        }

        public void Salvar(Profissional _profissional)
        {
            try
            {
                if (_profissional.IdPessoa == 0)
                {
                    _DAO.Add(_profissional);
                    _DAO.CommitChanges();
                }
                else
                {
                    _DAO.Update(_profissional, _profissional.IdPessoa);
                }

            }
            catch (DbUpdateException) { throw new Exceptions.ErroAoAtualizar(_profissional); }
            catch (Exception) { throw new Exceptions.ErroAoSalvar(_profissional); }
        }

        #endregion
    }
}
