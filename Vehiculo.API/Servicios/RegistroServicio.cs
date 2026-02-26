using Abstracciones.Interfaces.Reglas;
using Abstracciones.Interfaces.Servicios;
using Abstracciones.Modelos.Servicios.Registro;

namespace Servicios
{
    
    public class RegistroServicio : IRegistroServicio
    {
        private readonly IConfiguracion configuracion;
        public Task<Propietario> Obtener(string placa)
        {
            throw new NotImplementedException();
        }
    }
}
