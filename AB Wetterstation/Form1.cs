using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_Wetterstation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Globale Variablen
        int[] wert = new int[12];                                           // Deklarartion Array wert[]
        int i = 0, max, min;                                                // Deklarartion i, max, min + i wird auf "0" initielisiert
        double mittel;                                                      // Deklarartion mittel

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (i < 12)                                                     // Prüfen, ob noch nicht > 12 Werte eingegeben wurden
                {
                    wert[i] = Convert.ToInt16(textBox1.Text);                   // Einlesen aus textBox1
                    textBox2.Text = textBox2.Text + Convert.ToString(wert[i]) + "\r\n";  // Ausgabe in mehrzeiliger textBox2
                    i = i + 1;                                                  // Hochzählen des Index i
                    if (i < 12)
                    {
                        label2.Text = Convert.ToString(i + 1);                  // Ausgabe des aktuellen Index + 1 , da Index bei "0" beginnt
                    }
                    else
                    {
                        textBox1.Enabled = false;
                        button1.Enabled = false;
                        button2.Focus();
                    }
                    textBox1.Text = "";                                         // Wert in textBox1 löschen
                    textBox1.Focus();                                           // Fokus auf die textBox1
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mittel = 0;                                                     // Initialisierung der Variable mittel mit "0"
            max = wert[0];                                                  // Initialisierung der Variable max mit erstem Wert
            min = wert[0];                                                  // Initialisierung der Variable min mit erstem Wert
            for (int j = 0; j < 12; j++)                                    // Schleife 0...11
            {
                if (max > wert[j])                                          // Prüfen, ob größer als Maximum
                {                                                           //nix
                }
                else
                {
                    max = wert[j];                                          // Neuer Maximalwert
                }
                if (min < wert[j])                                          // Prüfen, ob kleiner als Minimum
                {                                                           //nix
                }
                else
                {
                    min = wert[j];                                          // Neuer Minimalwert
                }
                mittel = mittel + wert[j];
            }
            textBox3.Text= Convert.ToString(max);                           // Ausgabe Maximum
            textBox4.Text= Convert.ToString(min);                           // Ausgabe Minimum
            textBox5.Text= Convert.ToString(mittel/12.0);                   // Ausgabe Mittelwert
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 12; j++)                                    // Schleife 0...11
            {
                wert[j] = 0;

            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            i = 0;
            label2.Text = "1";
            textBox1.Focus();
        }
    }
}
