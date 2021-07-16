using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ExercicioFinalPatric.Contexto;
using ExercicioFinalPatric.Modelo;

namespace ExercicioFinalPatric.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioRepositorio() { }

        public RetornoFuncao realizaLogin(string nome, string senha) 
        {
            try
            {
                var conexao = new BancoDadosDapperContexto();
                var bancoDados = conexao.conexaobanco();
                var consulta = @"SELECT 1 FROM usuarios WHERE nome = @nome AND senha = @senha";
                var usuarioSucesso = bancoDados.Query<int>(consulta, new { nome = nome, senha = senha }).FirstOrDefault() == 0 ? 0
                    : bancoDados.Query<int>(consulta, new { nome = nome, senha = senha}).FirstOrDefault();

                conexao.Desconectabanco();

                if (usuarioSucesso == 0)
                    return new RetornoFuncao() { sucesso = false, descricao = "Usuário ou Senha inválidos" };
                return new RetornoFuncao() { sucesso = true, descricao = "Login feito com sucesso!" };
            }

            catch (Exception erro)
            {
                return new RetornoFuncao() { sucesso = false, descricao = erro.Message };
            }
        }
    }
}
