using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorDetectWebApp.Models
{
    public class Trecho
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int SensorInId { get; set; }
        public int SensorOutId { get; set; }

        public static List<Trecho> GetAll()
        {
            var retorno = new List<Trecho>();

            retorno.Add(new Trecho 
            { 
                Id = 1,
                Nome = "Av Bonocô 001",
                SensorInId = 1,
                SensorOutId = 2
            });
            retorno.Add(new Trecho
            {
                Id = 2,
                Nome = "Senador Medrado 001",
                SensorInId = 3,
                SensorOutId = 4
            });

            return retorno;        
        }
        public Trecho GetById(int id)
        {
            var trechoRetorno = Trecho.GetAll().Where(t => t.Id.Equals(id)).FirstOrDefault();
            return trechoRetorno;
        }
    }
}
