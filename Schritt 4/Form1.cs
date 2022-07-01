using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schritt_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temperatur temperaturklasse = null;

            // Inhalt entnehmen: DropDownList 1
            Object Box1_Inhalt = comboBox1.SelectedItem;
            string ursprungseinheit = Convert.ToString(Box1_Inhalt);

            if (ursprungseinheit == "°C") { temperaturklasse = new Celsius(); }
            if (ursprungseinheit == "°F") { temperaturklasse = new Fahrenheit(); }
            if (ursprungseinheit == "°K") { temperaturklasse = new Kelvin(); }

            // Inhalt entnehmen: DropDownList 2
            Object Box2_Inhalt = comboBox2.SelectedItem;
            string umrechnungseinheit = Convert.ToString(Box2_Inhalt);

            // Entnahme aus TextBox 1
            string temperatur = textBox1.Text;
            if (!double.TryParse(temperatur, out _))
            {
                textBox2.Text = "Ungültiger Wert";
                textBox1.Text = "";
                return;
            }

            double umgewandelte_temperatur = 0;

            // Feststellung in welche Einheit umgerechnet werden soll
            if (umrechnungseinheit == "°C")
            {
                umgewandelte_temperatur = temperaturklasse.Celsius_Umwandlung(Convert.ToDouble(temperatur));
            }
            if (umrechnungseinheit == "°F")
            {
                umgewandelte_temperatur = temperaturklasse.Fahrenheit_Umwandlung(Convert.ToDouble(temperatur));
            }
            if (umrechnungseinheit == "°K")
            {
                umgewandelte_temperatur = temperaturklasse.Kelvin_Umwandlung(Convert.ToDouble(temperatur));
            }

            // Ausgeben des Ergebnisses
            textBox2.Text = umgewandelte_temperatur + umrechnungseinheit;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Runder obj = new Runder();
            Runder.Kommastellen = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
