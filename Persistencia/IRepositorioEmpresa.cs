using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioEmpresa
    {
        IEnumerable<Empresa> GetAllEmpresa();
        Empresa AddEmpresa(Empresa empresa);
        Empresa UpdateEmpresa(Empresa empresa);
        void DeleteEmpresa(int id);
        Empresa GetEmpresa(int id);

    }
}