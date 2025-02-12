using System.Collections.Generic;

namespace HistorialApp.ViewModels
{
    public class HistorialViewModel
    {
        public List<HistorialItem> Historial { get; set; }

        public HistorialViewModel()
        {
            Historial = new List<HistorialItem>
            {
                new HistorialItem { Dia = "Lunes", Porcentaje = "80%", Tiempo = "10:30 AM" },
                new HistorialItem { Dia = "Martes", Porcentaje = "65%", Tiempo = "12:00 PM" },
                new HistorialItem { Dia = "Miércoles", Porcentaje = "90%", Tiempo = "9:45 AM" }
            };
        }
    }

    public class HistorialItem
    {
        public string Dia { get; set; }
        public string Porcentaje { get; set; }
        public string Tiempo { get; set; }
    }
}