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
    public class ConsultaBO
    {
        #region DAO

        private class DAO : AbstractDAL<Consulta> { }

        private DAO _DAO = new DAO();

        #endregion

        #region Métodos Básicos

        public Consulta Get(int id)
        {
            return _DAO.Get(id);
        }

        public List<Consulta> GetAll()
        {
            return _DAO.GetAll();
        }

        public void Salvar(Consulta _consulta)
        {
            try
            {
                if (_consulta.IdConsulta == 0)
                {
                    _DAO.Add(_consulta);
                    _DAO.CommitChanges();
                }
                else
                {
                    _DAO.Update(_consulta, _consulta.IdConsulta);
                }

            }
            catch (DbUpdateException) { throw new Exceptions.ErroAoAtualizar(_consulta); }
            catch (Exception) { throw new Exceptions.ErroAoSalvar(_consulta); }
        }

        #endregion
    }
}
