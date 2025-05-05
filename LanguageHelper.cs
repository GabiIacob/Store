using System;
using System.Collections.Generic;

namespace Pr2_Magazin
{
    public static class LanguageHelper
    {
        private static Dictionary<string, Dictionary<string, string>> languageEntries = new Dictionary<string, Dictionary<string, string>>();
        private static string currentLanguage = "en";

        static LanguageHelper()
        {
            // textele în limba engleză
            languageEntries["en"] = new Dictionary<string, string>
            {
                { "AddProduct", "Add Product" },
                { "ViewSales", "View Sales" },
                { "Categories", "Categories" },
                { "SearchProducts", "Search Products" },
                { "UpdateClients", "Update Clients" },
                { "Language", "Language" }
            };

            // textele în limba română (fără diacritice)
            languageEntries["ro"] = new Dictionary<string, string>
            {
                { "AddProduct", "Adauga Produs" },
                { "ViewSales", "Vizualizare Vanzari" },
                { "Categories", "Categorii" },
                { "SearchProducts", "Cautare Produse" },
                { "UpdateClients", "Actualizare Clienti" },
                { "Language", "Limba" }
            };

            // textele în limba germană
            languageEntries["de"] = new Dictionary<string, string>
            {
                { "AddProduct", "Produkt Hinzufügen" },
                { "ViewSales", "Verkäufe Anzeigen" },
                { "Categories", "Kategorien" },
                { "SearchProducts", "Produkte Suchen" },
                { "UpdateClients", "Kunden Aktualisieren" },
                { "Language", "Sprache" }
            };

            // textele în limba spaniolă
            languageEntries["es"] = new Dictionary<string, string>
            {
                { "AddProduct", "Agregar Producto" },
                { "ViewSales", "Ver Ventas" },
                { "Categories", "Categorías" },
                { "SearchProducts", "Buscar Productos" },
                { "UpdateClients", "Actualizar Clientes" },
                { "Language", "Idioma" }
            };
        }

        public static void SetLanguage(string languageCode)
        {
            if (languageEntries.ContainsKey(languageCode))
            {
                currentLanguage = languageCode;
            }
            else
            {
                throw new ArgumentException($"Language '{languageCode}' is not supported.");
            }
        }

        public static string GetText(string key)
        {
            if (languageEntries[currentLanguage].ContainsKey(key))
            {
                return languageEntries[currentLanguage][key];
            }
            else
            {
                return $"[Missing: {key}]";
            }
        }
    }
}
