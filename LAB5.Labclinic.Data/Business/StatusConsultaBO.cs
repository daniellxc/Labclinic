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
    public class StatusConsultaBO
    {
        #region DAO

        private class DAO : AbstractDAL<StatusConsulta> { }

        private DAO _DAO = new DAO();

        #endregion

        #region Métodos Básicos

        public StatusConsulta Get(int id)
        {
            return _DAO.Get(id);
        }

        public List<StatusConsulta> GetAll()
        {
            return _DAO.GetAll();
        }

        public void Salvar(StatusConsulta _statusConsulta)
        {
            try
            {
                if (_statusConsulta.IdStatusConsulta == 0)
                {
                    _DAO.Add(_statusConsulta);
                    _DAO.CommitChanges();
                }
                else
                {
                    _DAO.Update(_statusConsulta, _statusConsulta.IdStatusConsulta);
                }

            }
            catch (DbUpdateException) { throw new Exceptions.ErroAoAtualizar(_statusConsulta); }
            catch (Exception) { throw new Exceptions.ErroAoSalvar(_statusConsulta); }
        }

        #endregion
    }
}
