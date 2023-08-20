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
    public partial class FormNew : Form
    {
        /// <summary>
        /// zmienna publiczna pozwalajaca na dostęp  innym obiektom
        /// </summary>
        public string mainWindowValue = "brak wartości";

        public FormNew()
        {
            InitializeComponent();
        }

        public void FormNew_Load(object sender, EventArgs e) 
        {
            //przypisanie wartości ze zmiennej do obiektu label
            labelFormMainValue.Text = mainWindowValue;
        }

    }
}
