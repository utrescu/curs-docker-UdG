using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Colors
{

    public class Color
    {
        public string Name { get; set; }
        public string Rgb { get; set; }
    }
    public class ColorData : ComponentBase
    {

        public const string RestServer = "https://localhost:5001";

        protected Color ColorActual = new Color { Name = "blanc", Rgb = "#000000" };
        protected System.Threading.Timer timer;


        protected string Error = "";
    }
}
