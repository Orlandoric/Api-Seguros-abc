using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Data.Context;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Business.Classes
{
    public class LogicaCliente : ICliente
    {
        private AppDbContext db;

        public LogicaCliente(AppDbContext db)
        { 
            this.db = db;
        }
        
        //Implementacion de los metodos de la interfase
        public string DeleteCliente(int id)
        {
            var registro = db.Clientes.Find(id);
            db.Clientes.Remove(registro);
            db.SaveChanges();
            return "Registro eliminado";
        }

        public string GetCliente(int id)
        {
            return "value";
            
        }

        public List<Cliente> GetClientes()
        {
            return db.Clientes.ToList();
        }

        public string SetCliente(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
            return "Registro insertado";
        }

        public string UpdateCliente(Cliente cliente)
        {
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
            return "Registro actualizado";
        }
    }
}
