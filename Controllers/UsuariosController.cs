using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MenuHorizontal.Models;


namespace Usuarios.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : Controller
    {
        BasePruebaContext context = new BasePruebaContext();

        Usuario user=new Usuario();

        [HttpGet]
        [Route("DameDatos")]
        public List<Usuario> Obtenerdatos()
        {
            return context.Usuario.ToList();
        
        }
       
        /*public Usuario encontrar(string id)
        {
            return EncontrarUsuario(id);
        }*/
        
        [HttpPost]
        [Route("agregar")]
        public List<Usuario> AñadirUsuarios([FromBody]Usuario userTemp)
        {
            Usuario user = new Usuario
            {
                IdUsuario = userTemp.IdUsuario,
                NombreUsuario = userTemp.NombreUsuario,
                Nombre = userTemp.Nombre,
                Apellidos = userTemp.Apellidos,
                Password = userTemp.Password
            };
            context.Usuario.Add(user);
            context.SaveChanges();
            return context.Usuario.ToList();
        }
        [HttpPut]
        [Route("modificar")]
         public List<Usuario> modificarUsuario([FromBody]Usuario userTemp)
        {
            Usuario user = new Usuario
            {
                IdUsuario = userTemp.IdUsuario,
                NombreUsuario = userTemp.NombreUsuario,
                Nombre = userTemp.Nombre,
                Apellidos = userTemp.Apellidos,
                Password = userTemp.Password
            };
            context.Usuario.Add(user);
            context.SaveChanges();
            return context.Usuario.ToList();
        }


        [HttpGet]
        [Route("verificarUsuario/{usuario}/{contrasenna}")]
        public bool VerificarUsuario(string usuario,string contrasenna)
        {
            Usuario user = (from item in context.Usuario
                            where item.NombreUsuario == usuario
                            select item).FirstOrDefault<Usuario>();
            if(user.Password == contrasenna)
                return true;
            else
                return false;
        }
        [HttpGet]
        [Route("find/{id}")]
        public List<Usuario> EncontrarUsuario(string id)
        {

          try  
            {  
                Usuario user = context.Usuario.Find(id); 
                 List<Usuario> lista= new List<Usuario>();
                 lista.Add(user);
                
                return lista;  
            }  
            catch  
            {  
                throw;  
            }  

        
        }
    }
}
