using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SensorDetectWebApp.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Localização")]
        public string Localizacao { get; set; }

        public static IEnumerable<Sensor> GetAll()
        {
            var retorno = new List<Sensor>();

            retorno.Add(new Sensor()
            {
                Id = 1,
                Nome = "Sensor número 125",
                Localizacao="Rua dos Amburgos, Bonocô, Salvador"
            });
            retorno.Add(new Sensor()
            {
                Id = 2,
                Nome = "Sensor número 630",
                Localizacao = "Rua dos Amburgos, Bonocô, Salvador"
            });
            retorno.Add(new Sensor()
            {
                Id = 3,
                Nome = "Sensor número 11",
                Localizacao = "Rua Senador Medrado, Barra da Tijuca, Rio de Janeiro"
            });
            retorno.Add(new Sensor()
            {
                Id = 4,
                Nome = "Sensor número 136",
                Localizacao = "Rua Senador Medrado, Barra da Tijuca, Rio de Janeiro"
            });

            return retorno;

        }

        public Sensor GetById(int id)
        {
            var sensorRetorno = Sensor.GetAll().Where(s => s.Id.Equals(id)).FirstOrDefault();
            return sensorRetorno;
        }
    }
}
