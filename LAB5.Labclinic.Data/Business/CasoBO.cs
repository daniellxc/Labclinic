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
    public class CasoBO
    {
        #region DAO

        private class DAO : AbstractDAL<Caso> { }

        private DAO _DAO = new DAO();

        #endregion

        #region Métodos Básicos

        public Caso Get(int id)
        {
            return _DAO.Get(id);
        }

        public List<Caso> GetAll()
        {
            return _DAO.GetAll();
        }

        public void Salvar(Caso _caso)
        {
            try
            {
                if (_caso.IdCaso == 0)
                {
                    _DAO.Add(_caso);
                    _DAO.CommitChanges();
                }
                else
                {
                    _DAO.Update(_caso, _caso.IdCaso);
                }

            }
            catch (DbUpdateException) { throw new Exceptions.ErroAoAtualizar(_caso); }
            catch (Exception) { throw new Exceptions.ErroAoSalvar(_caso); }
        }

      

        #endregion
    }
}
