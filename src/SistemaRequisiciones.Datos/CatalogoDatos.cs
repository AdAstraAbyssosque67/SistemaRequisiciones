using System;
using System.Collections.Generic;
using System.Data;
using SistemaRequisiciones.Entidades;

namespace SistemaRequisiciones.Datos
{
    // Lectura de los datos de apoyo (solicitantes y departamentos) para las listas desplegables.
    public class CatalogoDatos
    {
        public List<Solicitante> ListarSolicitantes()
        {
            DataTable tabla = AccesoDatos.ConsultarTabla(
                "SELECT IdSolicitante, Nombre, IdDepartamento FROM dbo.Solicitantes ORDER BY Nombre");

            List<Solicitante> solicitantes = new List<Solicitante>();
            foreach (DataRow fila in tabla.Rows)
            {
                solicitantes.Add(new Solicitante(
                    Convert.ToInt32(fila["IdSolicitante"]),
                    Convert.ToString(fila["Nombre"]),
                    Convert.ToInt32(fila["IdDepartamento"])));
            }
            return solicitantes;
        }

        public List<Departamento> ListarDepartamentos()
        {
            DataTable tabla = AccesoDatos.ConsultarTabla(
                "SELECT IdDepartamento, Nombre FROM dbo.Departamentos ORDER BY Nombre");

            List<Departamento> departamentos = new List<Departamento>();
            foreach (DataRow fila in tabla.Rows)
            {
                departamentos.Add(new Departamento(
                    Convert.ToInt32(fila["IdDepartamento"]),
                    Convert.ToString(fila["Nombre"])));
            }
            return departamentos;
        }
    }
}
