using ExercicioFinalPatric.Modelo;
using ExercicioFinalPatric.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinalPatric.Controlador
{
    public class UsuarioControlador
    {
        UsuarioRepositorio _usuarioRepositorio;
        public UsuarioControlador()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }
        public RetornoFuncao realizaLogin(string nome, string senha)
        {
        
            var retorno = _usuarioRepositorio.realizaLogin(nome, senha);
            return retorno;
        }
    }
}
