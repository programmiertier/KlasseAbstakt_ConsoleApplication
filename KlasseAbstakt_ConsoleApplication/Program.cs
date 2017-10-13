using System;
using static System.Console;

namespace KlasseAbstakt_ConsoleApplication
{
    class Program
    {
        class Klasse // name immer groß
        {
            // Attribute oder Felder
            // ohne einen explizieten 'Zugriffsmodifizierer'
            // private und nicht ohne Methode erreichbar
            int ganzZahl;
            string zeichenKette;


            // Methoden
            public void zeigeAlles()
            {
                WriteLine("Das Objekt hat die Attribute: ");
                WriteLine("{0}\t{1}", ganzZahl, zeichenKette);
            }
            public void setze_ganzZahl_auf(int wert)
            {
                ganzZahl = wert;
            }
            public void setze_zeichenKette_auf(string wert)
            {
                zeichenKette = wert;
            }
        }



        static void Main(string[] args)
        {
            // eine Klasse aber keine Instanz
            // OBjekt erzeugen oder Instanzieren
            // Klasse nennen und Objektname festlegen

            Klasse objekt = new Klasse();
            // wäre nur möglich, wenn public objekt.ganzZahl = 22; // unerwünscht
            objekt.setze_ganzZahl_auf(22);
            objekt.setze_zeichenKette_auf("das ist der string");
            objekt.zeigeAlles();
            ReadLine();
        }
    }
}
