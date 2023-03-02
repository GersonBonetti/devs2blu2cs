using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IRepositories;
using ProjetoNotas.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Application.Service.SQLServices
{
    public class NoteService : INoteService
    {
        private readonly INoteRepository _repository;
        public NoteService() { }
        public Task<int> Delete(ServiceDTO entity)
        {
            throw new NotImplementedException();
        }

        public List<ServiceDTO> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(ServiceDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ServiceDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
