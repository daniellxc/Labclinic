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
    public class PacienteBO
    {
        #region DAO

        private class DAO : AbstractDAL<Paciente> { }

        private DAO _DAO = new DAO();

        #endregion

        #region Métodos Básicos

        public Paciente Get(int id)
        {
            return _DAO.Get(id);
        }

        public List<Paciente> GetAll()
        {
            return _DAO.GetAll();
        }

        public void Salvar(Paciente _paciente)
        {
            try
            {
                if (_paciente.IdPessoa == 0)
                {
                    _DAO.Add(_paciente);
                    _DAO.CommitChanges();
                }
                else
                {
                    _DAO.Update(_paciente, _paciente.IdPessoa);
                }

            }
            catch (DbUpdateException) { throw new Exceptions.ErroAoAtualizar(_paciente); }
            catch (Exception) { throw new Exceptions.ErroAoSalvar(_paciente); }
        }

        #endregion
    }
}
