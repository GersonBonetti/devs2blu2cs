using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Domain.Interfaces.IService
{
    public interface INoteService
    {
        List<ServiceDTO> FindAll();
        Task<ServiceDTO> FindById(int id);
        Task<int> Save(ServiceDTO entity);
        Task<int> Update(ServiceDTO entity);
        Task<int> Delete(ServiceDTO entity);
    }
}