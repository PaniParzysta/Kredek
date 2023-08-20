using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kredek_cpc_1
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// zmienna przechowujaca wartość pola textboxAdd
        /// </summary>
        int number = 1;
        /// <summary>
        /// zmienna obsugująca licznik zegara
        /// </summary>
        int counter = 1;

        /// <summary>
        /// zmienna przechowujaca referencje do nowego okna
        /// </summary>
        FormNew formNew;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// przycisk zmieniający kolor tła i elementów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //zmiana koloru tła
            BackColor = Color.CornflowerBlue;
            //zmiana koloru przycisku
            buttonColor.BackColor = Color.AntiqueWhite;
        }

        /// <summary>
        /// przycisk zwiekszający wartość textboxAdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego na liczbe
            number = Int32.Parse(textboxAdd.Text);
            //dodanie wartości liczbowej
            number += 7;
            //zamiana liczby na string
            textboxAdd.Text = number.ToString();
            //dodanie warunku
            if(number>20)
                MessageBox.Show("Uwaga przekroczono próg 20");
        }

        /// <summary>
        /// uruchomienie timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            //uruchomienie zegara
            Counter.Start();
        }

        /// <summary>
        /// obsługa każdego tyknięcia timera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Counter_Tick(object sender, EventArgs e)
        {
            //zwiększanie zmiennej counter
            counter++;
            //odświerzenie zawartości texboxAdd
            textboxAdd.Text = counter.ToString();
        }

        /// <summary>
        /// funkcja tworząca nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_2(object sender, EventArgs e)
        {
            //utworzenie nowego obiektu kasy FormNew
            formNew = new FormNew();
            //przypisanie wartości do innego okna
            formNew.mainWindowValue = "Patrycja Zdradzisz";
            //otworzenie okna
            formNew.ShowDialog();
        }
    }
}
