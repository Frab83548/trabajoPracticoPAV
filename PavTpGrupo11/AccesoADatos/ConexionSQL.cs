﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using PavTpGrupo11.Formularios;
using PavTpGrupo11.Entidades;

namespace PavTpGrupo11.AccesoADatos


{
   public  class ConexionSQL
    {
        static string cadena = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlConnection conexion = new SqlConnection(cadena);

        public int Login( string us, string pass )
        {
            int count;
            conexion.Open();
            string query = "Select Count(*) FROM Usuario WHERE Nombre = '"+us+ "'and Contraseña = '"+pass+"'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();
            return count;
        }
        public DataTable ConsultarUsuarios()
        {
            string query = "SELECT * FROM Usuario";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }

        public int InsertarUsuarioU(Usuario us)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Usuario(Nombre, Contraseña ) values('" + us.nombre + "', '" +  us.contrasena + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int EliminarUsuario(string nom)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Usuario WHERE Nombre = '" + nom + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarUsuario(Usuario us)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Usuario SET Contraseña = '" + us.contrasena + "' WHERE Nombre = '" + us.nombre + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public DataTable ObtenerRepuestos()
        {
            string query = "SELECT * FROM REPUESTO";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }

        public int InsertarRepuesto(Repuesto re)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into REPUESTO(Codigo_Repuesto, Nombre_Repuesto ) values('" + re.Codigo + "', '" + re.nombre + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int EliminarRespuesto(int cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM REPUESTO WHERE Codigo_Repuesto = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarRepuesto(Repuesto re)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE REPUESTO SET Nombre_Repuesto = '" + re.nombre + "' WHERE Codigo_Repuesto = '" + re.Codigo + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        public DataTable ConsultarUsuariosDG()
        {
            string query = "SELECT * FROM Empleados";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public DataTable ConsultarBarriosDG()
        {
            string query = "SELECT * FROM Barrios";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;


        }
        public int InsertarEmpleado(Empleado emp)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Empleados(Cod_Empleado, Nombre, Telefono, Documento, calle, nro_Calle, id_barrio) values('" +emp.CodigoEmpleado + "', '" + emp.Nombre + "', '" + emp.telefono + "', '" + emp.NroTipoDocumento + "', '" + emp.calle + "', '" + emp.NroCalle + "', '" + emp.IdBarrio + "')";
            
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
               
            
        }
        public int  EliminarEmpleado(string cod)
        {

            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Empleados WHERE Cod_Empleado = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        public int ModificarEmpleado(Empleado emp)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Empleados SET Nombre = '" + emp.Nombre + "', Telefono = '" + emp.telefono + "', Documento = '" + emp.NroTipoDocumento + "', calle =  '" + emp.calle + "', nro_calle =  '" + emp.NroCalle + "', id_barrio = '" + emp.IdBarrio + "' WHERE Cod_Empleado = '" + emp.CodigoEmpleado + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        public bool InsertarBarrio(Barrio ba)

        {
            bool resultado = false;

            try
            {
                conexion.Open();
                string query = "insert into Barrios(id_barrio, nombre_barrio) values('" + ba.Id + "', '" + ba.Nombre + "')";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                
                resultado= true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }

        public int ModificarBarrio(Barrio ba)

        {
            int resultado = 0;
            try
            {
                conexion.Open();
                string query = "UPDATE Barrios SET nombre_barrio = '" + ba.Nombre + "' where id_barrio = '" + ba.Id + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                resultado =cmd.ExecuteNonQuery();

                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
            
          


        }
        public int EliminarBarrio(string id)

        {
            int flag = 0;

            try
            {
                conexion.Open();
                string query = "DELETE FROM Barrios WHERE id_barrio = '" + id + "'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                flag = cmd.ExecuteNonQuery();
                return flag;
                 
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
            
           


        }
        // proveedores david
        public DataTable ConsultarProveedoresDG()
        {
            string query = "SELECT * FROM Proveedor";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarProveedor(Proveedor pro)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Proveedor(Cod_Proveedor, Nombre, Telefono, Mail, Calle, nro_Calle, id_barrio) values('" + pro.cod_proveedor + "', '" + pro.Nombre + "', '" + pro.telefono + "', '" + pro.Mail + "', '" + pro.calle + "', '" + pro.NroCasa + "', '" + pro.IdBarrio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int ModificarProveedor(Proveedor pro)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Proveedor SET Nombre = '" + pro.Nombre + "', Telefono = '" + pro.telefono + "', Mail = '" + pro.Mail + "', Calle =  '" + pro.calle + "', nro_calle =  '" + pro.NroCasa + "', id_barrio = '" + pro.IdBarrio + "' WHERE Cod_Proveedor = '" + pro.cod_proveedor + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int EliminarProveedor(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Proveedor WHERE Cod_Proveedor = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
        // Obra david
        public DataTable ConsultarObrasDG()
        {
            string query = "SELECT * FROM Obras";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarObra(Obra ob)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Obras(codigo_obra, nombre_Obra, calle, nro_Calle, id_barrio) values('" + ob.Codigo_Obra + "','" + ob.NombreObra + "', '" + ob.calle + "', '" + ob.NroCalle + "', '" + ob.IdBarrio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }

        public int ModificarObra(Obra ob)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Obras SET nombre_Obra = '" + ob.NombreObra + "', Calle =  '" + ob.calle + "', nro_calle =  '" + ob.NroCalle + "', id_barrio = '" + ob.IdBarrio + "' WHERE codigo_Obra = '" + ob.Codigo_Obra + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int EliminarObra(string cod)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Obras WHERE codigo_Obra = '" + cod + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }


        public DataTable ObtenerCamiones()
        {
            string query = "SELECT * FROM Camiones";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarCamion(Camion cam)

        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Camiones(Patente, Marca_Camión, Año_Modelo, Capacidad ) values('" + cam.patente + "', '" + cam.Marca + "', '" + cam.Anio_modelo + "', '" + cam.Capacidad + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int eliminarCamion(string patente)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Camiones WHERE Patente = '" + patente + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int ModificarCamion(Camion cam)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Camiones SET Marca_Camión = '" + cam.Marca + "', Año_Modelo =  '" + cam.Anio_modelo + "', Capacidad =  '" + cam.Capacidad + "' WHERE Patente = '" + cam.patente + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }

        
        public DataTable ConsultarMaterialesDG()
        {
            string query = "SELECT * FROM Materiales";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }
        public int InsertarMaterial(Material ma)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Materiales(Codigo_Material, Cantidad, Cod_Unidad_Medida, Cod_Proveedor, Fecha_Ingreso, precio) values('" + ma.codigo_material + "','" + ma.cantidad + "', '" + ma.cod_unidad_medida + "', '" + ma.cod_proveedor + "', '" + ma.fecha_ingreso + "', '" + ma.precio + "')";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

        }
        public int ModificarMaterial(Material ma)

        {
            int flag = 0;
            conexion.Open();
            string query = "UPDATE Materiales SET Cantidad = '" + ma.cantidad + "', Cod_Unidad_Medida =  '" + ma.cod_unidad_medida + "', Cod_Proveedor =  '" + ma.cod_proveedor + "', Fecha_Ingreso = '" + ma.fecha_ingreso + "', precio = '"+ ma.precio + "' WHERE Codigo_Material = '" + ma.codigo_material + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;


        }
        public int eliminarMaterial(string Material)
        {
            int flag = 0;
            conexion.Open();
            string query = "DELETE FROM Materiales WHERE Codigo_Material = '" + Material + "'";

            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }
    }

}
