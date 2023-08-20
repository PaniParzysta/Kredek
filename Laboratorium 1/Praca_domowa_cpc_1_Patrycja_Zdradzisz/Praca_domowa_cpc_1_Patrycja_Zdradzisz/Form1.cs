using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_domowa_cpc_1_Patrycja_Zdradzisz
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// wyświetlenie w funkcji informacji przed rozpoczęciem gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
           labelInfo.Text = "Witaj w wiosce pingwinów! Twoim celem jest w ciągu 3 rund \n zdobyć 3 pingwiny z pistoletami na kulki, żeby mogły odeprzeć \n atak niedźwiedzi." +
                            " Możesz kupować różne miejsca by zdobyć \n surowce, jak i je ulepszać by dostawać ich więcej. Co jakiś czas \n zaatakują cię niedźwiedzie i stracisz losową wartość każdego \n " +
                            "surowca. Każdy pingwin z bronią ogranicza ilość zabranych \n surowców. \n Miłej zabawy i powodzenia :)";
        }

        /// <summary>
        /// funkcja przycisku odpowiedzianego za start gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            //utworzenie obiektu kasy FormGame
            FormGame formGame = new FormGame();
            //wyświetlenie nowego okna i ukrycie dotychczasowego
            formGame.Show();
            this.Hide();
        }

        /// <summary>
        /// funkcja przycisku odpowiedzialnego za zamknięcie okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
