using System.Data.Common;
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        private readonly AplicacionContext _appContext;

        public RepositorioEmpresa(AplicacionContext appContext){
        
            _appContext = appContext;
        }

        public Empresa AddEmpresa(Empresa empresa)
        {
            var addEmpresa = _appContext.Add(empresa);
            _appContext.SaveChanges();
            return addEmpresa.Entity;
        }

        public void DeleteEmpresa(int id)
        {
            var deleteEmpresa = _appContext.Empresas.FirstOrDefault(
                p => p.Id == id
            );

            if(deleteEmpresa == null)
            return;
            _appContext.Remove(deleteEmpresa);
            _appContext.SaveChanges();
        }

        public IEnumerable<Empresa> GetAllEmpresa()
        {
            return _appContext.Empresas;
        }

        public Empresa GetEmpresa(int id)
        {
            return _appContext.Empresas.FirstOrDefault(
                p => p.Id == id
            );
        }

        public Empresa UpdateEmpresa(Empresa empresa)
        {
            var updateEmpresa = _appContext.Empresas.FirstOrDefault(
                p => p.Id == empresa.Id
            );
            if(updateEmpresa != null){
                                
                updateEmpresa.Nombre = empresa.Nombre;
                updateEmpresa.NIT= empresa.NIT;
                _appContext.SaveChanges();
            }
            return updateEmpresa;

        }
    }
}