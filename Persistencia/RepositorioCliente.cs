using System.Collections.Generic;
using Dominio;
using System.Linq;
using System;

namespace Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AplicacionContext _appContext;

        public RepositorioCliente(AplicacionContext appContext){
        
            _appContext = appContext;
        }

        public Cliente AddCliente(Cliente cliente)
        {
            var addcliente = _appContext.Add(cliente);
            _appContext.SaveChanges();
            return addcliente.Entity;
        }

        public void DeleteCliente(int idCliente)
        {
            var deletecliente = _appContext.Clientes.FirstOrDefault(
                p => p.IdCliente == idCliente
            );

            if(deletecliente == null)
            return;
            _appContext.Remove(deletecliente);
            _appContext.SaveChanges();
        }

        public IEnumerable<Cliente> GetAllCliente()
        {
            return _appContext.Clientes;
        }

        public Cliente GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(
                p => p.IdCliente == idCliente
            );
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var updateCliente = _appContext.Clientes.FirstOrDefault(
                p => p.Nombre == cliente.Nombre
            );
            if(updateCliente != null){

                updateCliente.IdCliente = cliente.IdCliente;
                updateCliente.Nombre = cliente.Nombre;
                updateCliente.Edad = cliente.Edad;
                updateCliente.TipoDocumento = cliente.TipoDocumento;
                updateCliente.NumeroDocumento = cliente.NumeroDocumento;
                _appContext.SaveChanges();
            } else {
                Console.WriteLine("No encontrado");
            }
            return updateCliente;

        }
    }
}