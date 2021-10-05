using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly AplicacionContext _appContext;

        public RepositorioEmpleado(AplicacionContext appContext){
        
            _appContext = appContext;
        }

        public Empleado AddEmpleado(Empleado empleado)
        {
            var addEmpleado = _appContext.Add(empleado);
            _appContext.SaveChanges();
            return addEmpleado.Entity;
        }

        public void DeleteEmpleado(int idEmpleado)
        {
            var deleteEmpleado = _appContext.Empleados.FirstOrDefault(
                p => p.IdEmpleado == idEmpleado
            );

            if(deleteEmpleado == null)
            return;
            _appContext.Remove(deleteEmpleado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Empleado> GetAllEmpleado()
        {
            return _appContext.Empleados;
        }

        public Empleado GetEmpleado(int idEmpleado)
        {
            return _appContext.Empleados.FirstOrDefault(
                p => p.IdEmpleado == idEmpleado
            );
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            var updateEmpleado = _appContext.Empleados.FirstOrDefault(
                p => p.IdEmpleado == empleado.IdEmpleado
            );
            if(updateEmpleado != null){

                updateEmpleado.Nombre = empleado.Nombre;
                updateEmpleado.Apellido = empleado.Apellido;
                updateEmpleado.Salario = empleado.Salario;
                updateEmpleado.Edad = empleado.Edad;
                updateEmpleado.TipoDocumento = empleado.TipoDocumento;
                updateEmpleado.NumeroDocumento = empleado.NumeroDocumento;
                _appContext.SaveChanges();
            }
            return updateEmpleado;

        }
    }
}