using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace JobScheduler
{
    public class EngineDb
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=sql7005.site4now.net;Initial Catalog=DB_A486E4_Legalizaciones;user id=DB_A486E4_Legalizaciones_admin; password=Innova4j;");
        public bool InsertKactusEmpleados(string SpName, List<KactusIntegration.Empleado> model)
        {
            bool resultado = false;
            using (Conexion)
            {
                Conexion.Open();
                SqlCommand command = new SqlCommand(SpName, Conexion);
                command.CommandType = CommandType.StoredProcedure;
                int nueva = 0;
                foreach (KactusIntegration.Empleado m in model)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Nueva", nueva);
                    command.Parameters.AddWithValue("@Cargo", m.Cargo);
                    command.Parameters.AddWithValue("@CargoEmpleado", m.CargoEmpleado);
                    command.Parameters.AddWithValue("@Celular", m.Celular);
                    command.Parameters.AddWithValue("@CentroCosto", m.CentroCosto);
                    command.Parameters.AddWithValue("@CodCiudadExpedicion", m.CodCiudadExpedicion);
                    command.Parameters.AddWithValue("@CodCiudadResidencia", m.CodCiudadResidencia);
                    command.Parameters.AddWithValue("@CodDeptoExpedicion", m.CodDeptoExpedicion);
                    command.Parameters.AddWithValue("@CodDeptoResidencia", m.CodDeptoResidencia);
                    command.Parameters.AddWithValue("@CodTipoEspPersonaPreliq", m.CodTipoEspPersonaPreliq);
                    command.Parameters.AddWithValue("@CodTipoPersona", m.CodTipoPersona);
                    command.Parameters.AddWithValue("@CodUbicacion", m.CodUbicacion);
                    command.Parameters.AddWithValue("@CodigoArea", m.CodigoArea);
                    command.Parameters.AddWithValue("@CodigoEmpresa", m.CodigoEmpresa);
                    command.Parameters.AddWithValue("@CodigoGrupo", m.CodigoGrupo);
                    command.Parameters.AddWithValue("@CodigoNivel", m.CodigoNivel);
                    command.Parameters.AddWithValue("@CodigoNivel1", m.CodigoNivel1);
                    command.Parameters.AddWithValue("@CodigoNivel2", m.CodigoNivel2);
                    command.Parameters.AddWithValue("@CodigoNivel3", m.CodigoNivel3);
                    command.Parameters.AddWithValue("@CodigoNivel4", m.CodigoNivel4);
                    command.Parameters.AddWithValue("@CodigoNivel5", m.CodigoNivel5);
                    command.Parameters.AddWithValue("@CodigoNivel6", m.CodigoNivel6);
                    command.Parameters.AddWithValue("@CodigoNivel7", m.CodigoNivel);
                    command.Parameters.AddWithValue("@Direccion", m.Direccion);
                    command.Parameters.AddWithValue("@Email", m.Email);
                    command.Parameters.AddWithValue("@Eps", m.Eps);
                    command.Parameters.AddWithValue("@EscalaSalarial", m.EscalaSalarial);
                    command.Parameters.AddWithValue("@EstadoEmpleado", m.EstadoEmpleado);
                    command.Parameters.AddWithValue("@ExtensionCompania", m.ExtensionCompania);
                    command.Parameters.AddWithValue("@FecActCargo", m.FecActCargo);
                    command.Parameters.AddWithValue("@FecActContr", m.FecActContr);
                    command.Parameters.AddWithValue("@FechaInicioContrato", m.FechaInicioContrato);
                    command.Parameters.AddWithValue("@FechaNacimiento", m.FechaNacimiento);
                    command.Parameters.AddWithValue("@GanaExtras", m.GanaExtras);
                    command.Parameters.AddWithValue("@IdentificacionExterna", m.IdentificacionExterna);
                    command.Parameters.AddWithValue("@NombreNivel", m.NombreNivel);
                    command.Parameters.AddWithValue("@NombreNivel1", m.NombreNivel1);
                    command.Parameters.AddWithValue("@NombreNivel2", m.NombreNivel2);
                    command.Parameters.AddWithValue("@NombreNivel3", m.NombreNivel3);
                    command.Parameters.AddWithValue("@NombreNivel4", m.NombreNivel4);
                    command.Parameters.AddWithValue("@NombreNivel5", m.NombreNivel5);
                    command.Parameters.AddWithValue("@NombreNivel6", m.NombreNivel6);
                    command.Parameters.AddWithValue("@NombreNivel7", m.NombreNivel7);
                    command.Parameters.AddWithValue("@NumeroContrato", m.NumeroContrato);
                    command.Parameters.AddWithValue("@NumeroDeIdentificacion", m.NumeroDeIdentificacion);
                    command.Parameters.AddWithValue("@PrimerApellido", m.PrimerApellido);
                    command.Parameters.AddWithValue("@PrimerNombre", m.PrimerNombre);
                    command.Parameters.AddWithValue("@PuedeSerVisitado", m.PuedeSerVisitado);
                    command.Parameters.AddWithValue("@Rh", m.Rh);
                    command.Parameters.AddWithValue("@SegundoApellido", m.SegundoApellido);
                    command.Parameters.AddWithValue("@SegundoNombre", m.SegundoNombre);
                    command.Parameters.AddWithValue("@Telefono", m.Telefono);
                    command.Parameters.AddWithValue("@TipoContratista", m.TipoContratista);
                    command.Parameters.AddWithValue("@TipoDeIdentificacion", m.TipoDeIdentificacion);
                    command.Parameters.AddWithValue("@TipoDeSangre", m.TipoDeSangre);
                    command.Parameters.AddWithValue("@Titular", m.Titular);
                    command.Parameters.AddWithValue("@ValidoParaLiqNomina", m.ValidoParaLiqNomina);
                    command.Parameters.AddWithValue("@VencimientoAccion", m.VencimientoAccion);
                    command.ExecuteNonQuery();
                    nueva++;
                }
                Conexion.Close();
                resultado = true;
            }
            return resultado;
        }

    }
}
