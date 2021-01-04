using System.Linq;
using Colors.Models;

namespace Colors.Data
{
    class DbInitializer
    {
        public static void Initialize(ColorContext context)
        {
            context.Database.EnsureCreated();

            if (context.Colors.Any())
            {
                return;
            }

            var colors = new Color[] {
                new Color { Name="Aiguamarina", Rgb="#7FFFD4"},
                new Color { Name="Albercoc", Rgb="#FBCEB1"},
                new Color { Name="Amarant", Rgb="#E52B50"},
                new Color { Name="Ambre", Rgb="#FFBF00"},
                new Color { Name="Ametista", Rgb="#9966CC"},
                new Color { Name="Atzur", Rgb="#007FFF"},
                new Color { Name="Beix", Rgb="#F5F5DC"},
                new Color { Name="Bistre", Rgb="#3D2B1F"},
                new Color { Name="Blanc", Rgb="#FFFFFF"},
                new Color { Name="Blat", Rgb="#F5DEB3"},
                new Color { Name="Blau", Rgb="#0000FF"},
                new Color { Name="Blau cel", Rgb="#77B5FE"},
                new Color { Name="Blau de cobalt", Rgb="#0047AB"},
                new Color { Name="Blau de França", Rgb="#318CE7"},
                new Color { Name="Blau de Prússia", Rgb="#003153"},
                new Color { Name="Blau fosc", Rgb="#00008B"},
                new Color { Name="Blau marí", Rgb="#000080"},
                new Color { Name="Blau reial", Rgb="#002366"},
                new Color { Name="Blauet", Rgb="#003399"},
                new Color { Name="Bronze", Rgb="#CD7F32"},
                new Color { Name="Camussa", Rgb="#F0DC82"},
                new Color { Name="Canyella", Rgb="#D2B48C"},
                new Color { Name="Caqui", Rgb="#C3B091"},
                new Color { Name="Cardenal", Rgb="#C41E3A"},
                new Color { Name="Carmesí", Rgb="#DC143C"},
                new Color { Name="Carmí", Rgb="#960018"},
                new Color { Name="Carnació", Rgb="#FEC3AC"},
                new Color { Name="Castany rogenc", Rgb="#CC8899"},
                new Color { Name="Celadont", Rgb="#2F847C"},
                new Color { Name="Ceruli", Rgb="#007BA7"},
                new Color { Name="Chartreuse", Rgb="#7FFF00"},
                new Color { Name="Cian", Rgb="#00FFFF"},
                new Color { Name="Cirera", Rgb="#DE3163"},
                new Color { Name="Corall", Rgb="#FF7F50"},
                new Color { Name="Coure", Rgb="#B87333"},
                new Color { Name="Crema", Rgb="#FFFDD0"},
                new Color { Name="Escarlata", Rgb="#FF2400"},
                new Color { Name="Fúcsia", Rgb="#E13571"},
                new Color { Name="Granat", Rgb="#800000"},
                new Color { Name="Gris", Rgb="#AAAAAA"},
                new Color { Name="Gris fosc", Rgb="#808080"},
                new Color { Name="Groc", Rgb="#FFFF00"},
                new Color { Name="Heliotropi", Rgb="#DF73FF"},
                new Color { Name="Indi", Rgb="#4B0082"},
                new Color { Name="Jade", Rgb="#00A86B"},
                new Color { Name="Lavanda", Rgb="#E6E6FA"},
                new Color { Name="Lila", Rgb="#660099"},
                new Color { Name="Llima", Rgb="#CCFF00"},
                new Color { Name="Magenta", Rgb="#FF00FF"},
                new Color { Name="Malva", Rgb="#E0B0FF"},
                new Color { Name="Marró", Rgb="#964B00"},
                new Color { Name="Morat", Rgb="#C54B8C"},
                new Color { Name="Negre", Rgb="#000000"},
                new Color { Name="Ocre", Rgb="#CC7722"},
                new Color { Name="Or", Rgb="#FFD700"},
                new Color { Name="Orquídia", Rgb="#DA70D6"},
                new Color { Name="Panotxa", Rgb="#CC5500"},
                new Color { Name="Plata", Rgb="#C0C0C0"},
                new Color { Name="Porpra", Rgb="#800080"},
                new Color { Name="Préssec", Rgb="#FFE5B4"},
                new Color { Name="Pruna", Rgb="#660066"},
                new Color { Name="Rosa", Rgb="#FFC0CB"},
                new Color { Name="Salmó", Rgb="#FF8C69"},
                new Color { Name="Sèpia", Rgb="#704214"},
                new Color { Name="Taronja", Rgb="#FF7F00"},
                new Color { Name="Turquesa", Rgb="#30D5C8"},
                new Color { Name="Verd", Rgb="#00FF00"},
                new Color { Name="Verd maragda", Rgb="#50C878"},
                new Color { Name="Verd oliva", Rgb="#808000"},
                new Color { Name="Verd veronès", Rgb="#40826D"},
                new Color { Name="Vermell", Rgb="#FF0000"},
                new Color { Name="Vermell fosc", Rgb="#8B0000"},
                new Color { Name="Vermelló", Rgb="#E34234"},
                new Color { Name="Vinca", Rgb="#CCCCFF"},
                new Color { Name="Violat", Rgb="#8B00FF"},
                new Color { Name="Vori", Rgb="#FFFFF0"},
                new Color { Name="Xarxet", Rgb="#008080"}
            };

            foreach (Color s in colors)
            {
                context.Colors.Add(s);
            }
            context.SaveChanges();

        }
    }
}