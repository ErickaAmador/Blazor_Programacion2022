using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios;

public class UsuarioRepositorio : IUsuarioRepositorio
{

    private string CadenaConexion;

    
    public UsuarioRepositorio(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;
    }


    private MySqlConnection Conexion() //METODO PARA CONECTARNOS A MYSQL
    {
        return new MySqlConnection(CadenaConexion);
    }






    public Task<bool> Actualizar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuario usuario)
    {
        throw new NotImplementedException();
    }


    //DEVUELVE TODOS LOS USUARIOS
    public async Task<IEnumerable<Usuario>> GetLista()
    {
        IEnumerable<Usuario> lista = new List<Usuario>();

        try
        {
            using MySqlConnection conexion = Conexion(); //Conexión que esta arriba    
            await conexion.OpenAsync();
            string sql = "SELECT + FROM usuario;";
            lista = await conexion.QueryAsync<Usuario>(sql);
        }
        catch (Exception ex)
        {
        }

        return lista;
    }



    public Task<Usuario> GetPorCodigo(string codigo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Nuevo(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
