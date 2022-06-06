using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoInventarioCTA.Vistas;
using ProyectoInventarioCTA.Menu;

namespace ProyectoInventarioCTA.Menu
{
    
    public class MainWindowViewModel
    {
        public MenuItem[] MenuItems { get; }
        public MainWindowViewModel()
        {
            MenuItems = new[]
            {
                new MenuItem("Inicio", new Start(),"Robot"),
                new MenuItem("Consultar", new SearchInformation(),"LaptopChromebook"),
            };
        }
        
    }

}
