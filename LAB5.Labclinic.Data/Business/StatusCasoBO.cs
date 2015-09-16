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
    public class StatusCasoBO
    {
        #region DAO

        private class DAO : AbstractDAL<StatusCaso> { }

        private DAO _DAO = new DAO();

        #endregion

        #region Métodos Básicos

        public StatusCaso Get(int id)
        {
            return _DAO.Get(id);
        }

        public List<StatusCaso> GetAll()
        {
            return _DAO.GetAll();
        }

        public void Salvar(StatusCaso _statusCaso)
        {
            try
            {
                if (_statusCaso.IdStatusCaso == 0)
                {
                    _DAO.Add(_statusCaso);
                    _DAO.CommitChanges();
                }
                else
                {
                    _DAO.Update(_statusCaso, _statusCaso.IdStatusCaso);
                }

            }
            catch (DbUpdateException) { throw new Exceptions.ErroAoAtualizar(_statusCaso); }
            catch (Exception) { throw new Exceptions.ErroAoSalvar(_statusCaso); }
        }

        #endregion
    }
}
