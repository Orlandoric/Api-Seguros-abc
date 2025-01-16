using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Business.Interfaces
{
    public interface ICliente
    {
        //Metodo que Devuelve una lista de clientes
        List<Cliente> GetClientes();

        //Crea un cliente
        string SetCliente(Cliente cliente);

        //Actualiza un cliente
        string UpdateCliente(Cliente cliente);

        //Elimina un cliente
        string DeleteCliente(int id);

        //Obtener un cliente
        string GetCliente(int id);

    }
}
