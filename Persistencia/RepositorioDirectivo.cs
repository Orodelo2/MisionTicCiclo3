using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioDirectivo : IRepositorioDirectivo
    {
        private readonly AplicacionContext _appContext;

        public RepositorioDirectivo(AplicacionContext appContext){
        
            _appContext = appContext;
        }

        public Directivo AddDirectivo(Directivo directivo)
        {
            var addDirectivo = _appContext.Add(directivo);
            _appContext.SaveChanges();
            return addDirectivo.Entity;
        }

        public void DeleteDirectivo(int idDirectivo)
        {
            var deleteDirectivo = _appContext.Directivos.FirstOrDefault(
                p => p.IdDirectivo == idDirectivo
            );

            if(deleteDirectivo == null)
            return;
            _appContext.Remove(deleteDirectivo);
            _appContext.SaveChanges();
        }

        public IEnumerable<Directivo> GetAllDirectivo()
        {
            return _appContext.Directivos;
        }

        public Directivo GetDirectivo(int idDirectivo)
        {
            return _appContext.Directivos.FirstOrDefault(
                p => p.IdDirectivo == idDirectivo
            );
        }

        public Directivo UpdateDirectivo(Directivo directivo)
        {
            var updateDirectivo = _appContext.Directivos.FirstOrDefault(
                p => p.IdDirectivo == directivo.IdDirectivo
            );
            if(updateDirectivo != null){

                updateDirectivo.Nombre = directivo.Nombre;
                updateDirectivo.Edad = directivo.Edad;
                updateDirectivo.TipoDocumento = directivo.TipoDocumento;
                updateDirectivo.NumeroDocumento = directivo.NumeroDocumento;
                _appContext.SaveChanges();
            }
            return updateDirectivo;

        }
    }
}