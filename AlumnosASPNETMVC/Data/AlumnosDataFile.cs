using System;
using CsvHelper;
using System.IO;
using AlumnosASPNETMVC.Models;
using System.Collections.Generic;

namespace AlumnosASPNETMVC.Data
{
    public class AlumnosDataFile
    {
        private readonly string path = Path.Combine(Directory.GetCurrentDirectory(), "Alumnos");

        public AlumnosDataFile()
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    // Console.WriteLine("Creamos el directorio para almacenar los datos de los alumnos.");
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    // Console.WriteLine("Directorio creado {0}.", Directory.GetCreationTime(path));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public void Save(AlumnoViewModel alumno)
        {
            var records = new List<AlumnoViewModel>
            {
                alumno
            };

            using (var writer = new StreamWriter(Path.Combine(path, alumno.RFC + ".csv")))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }
        }

        public IEnumerable<AlumnoViewModel> Read(string rfc)
        {
            TextReader reader = new StreamReader(path + rfc + ".csv");
            var csvReader = new CsvReader(reader);
            var records = csvReader.GetRecords<AlumnoViewModel>();

            return records;
        }
    }
}
