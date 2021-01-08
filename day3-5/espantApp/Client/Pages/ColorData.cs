using Microsoft.AspNetCore.Components;

namespace Colors
{

    public class Color
    {
        public string Name { get; set; }
        public string Rgb { get; set; }
    }
    public class ColorData : ComponentBase
    {

        protected Color ColorActual = new Color { Name = "blanc", Rgb = "#ffffff" };
        protected System.Threading.Timer timer;


        protected string Error = "";
    }
}
