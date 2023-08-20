using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataBase;

namespace WindowsFormsApp1.Forms
{
    
    public partial class FormProgram : Form
    {
        private readonly Repository _repository = new Repository();
        public FormProgram()
        {
            InitializeComponent();

            //sprawdzenie czy użytkownik nie jest adminem i zablokowanie mu dostępu do zmian w bazie danych
            if (Program.User != "Admin")
            {
                buttonAddFilm.Enabled = false;
                buttonDeleteFilm.Enabled = false;
                buttonEditFilm.Enabled = false;
                buttonClear.Enabled = false;
                buttonRental.Enabled = false;
            }
            else
            {
                //MessageBox.Show("Admin");
            }
        }

        private void Program_Load(object sender, EventArgs e)
        {
            RefreshDataGridViewFilms();
        }

        private void dataGridViewFilms_SelectionChanged(object sender, EventArgs e)
        {
            //Jeśli żadnen wiersz nie jest zaznaczony lub jest zaznaczonych więcej niż jeden to nic nie rób (return)
            int rowsCount = dataGridViewFilms.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1)
                return;

            //weź pierwszy zaznaczony wiersz
            DataGridViewRow row = dataGridViewFilms.SelectedRows[0];

            //wyciągnij dane z zaznaczonego wiersza
            int id = int.Parse(row.Cells[2].Value.ToString());
            string title = row.Cells[3].Value.ToString();
            int yearOfProduction = int.Parse(row.Cells[4].Value.ToString());
            string subtitles = row.Cells[0].Value.ToString();
            string languages = row.Cells[1].Value.ToString();
            int rental = int.Parse(row.Cells[5].Value.ToString());

            //poustawiaj dane w textboxach wybranego filmu
            textBoxId.Text = id.ToString();
            textBoxTitle.Text = title;
            textBoxYearOfProduction.Text = yearOfProduction.ToString();
            textBoxSubtitles.Text = subtitles.ToString();
            textBoxLanguage.Text = languages;
            textBoxRental.Text = rental.ToString();
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do ddodania filmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            int yearOfProduction = int.Parse(textBoxYearOfProduction.Text);
            string subtitles = textBoxSubtitles.Text;
            string language = textBoxLanguage.Text;
            int rental = int.Parse(textBoxRental.Text);

            _repository.AddFilm(title, yearOfProduction, subtitles, language, rental);

            RefreshDataGridViewFilms();
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku do usuwania filmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteFilm_Click(object sender, EventArgs e)
        {
            //wyciągnięcie bookId z textboxu
            int filmId = int.Parse(textBoxId.Text);

            //usunięcie książki z bazy danych
            _repository.DeleteFilm(filmId);

            RefreshDataGridViewFilms();
        }


        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku od edycji filmu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditFilm_Click(object sender, EventArgs e)
        {
            //wyciągnięcie danych z textboxów
            int filmId = int.Parse(textBoxId.Text);
            string title = textBoxTitle.Text;
            int yearOfPublication = int.Parse(textBoxYearOfProduction.Text);
            string subtitles = textBoxSubtitles.Text;
            string language = textBoxLanguage.Text;
            int rental = int.Parse(textBoxRental.Text);

            //aktualizacja książki
            _repository.EditFilm(filmId, title, yearOfPublication, subtitles, language, rental);

            RefreshDataGridViewFilms();
        }

        /// <summary>
        /// Metoda wywoływana po naciśnięciu przycisku od czyszczenia TextBoxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxTitle.Text = "";
            textBoxYearOfProduction.Text = "";
            textBoxSubtitles.Text = "";
            textBoxLanguage.Text = "";
            textBoxRental.Text = "";
        }

        private void RefreshDataGridViewFilms()
        {
            //pobierz wszystkie filmy z bazy danych
            DataTable films = _repository.GetFilms();

            //przypisz wszystkie filmy do DatagridViewFilms
            dataGridViewFilms.DataSource = films;
        }

        /// <summary>
        /// wyświetlenie filmów z aktorami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchByActors_Click(object sender, EventArgs e)
        {
            DataTable filmActors = _repository.GetFilmsActor();
            dataGridViewFilms.DataSource = filmActors;
        }

        /// <summary>
        /// wyświetlenie tablicy filmów z kategoriami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchByGenres_Click(object sender, EventArgs e)
        {
            DataTable filmCategory = _repository.GetFilmsCategory();
            dataGridViewFilms.DataSource = filmCategory;
        }

        /// <summary>
        /// wyświetlenie tablicy z filmami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonViewFilms_Click(object sender, EventArgs e)
        {
            RefreshDataGridViewFilms();
        }

        /// <summary>
        /// wywołanie wyświetlenia tablicy z wypożyczeniami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRental_Click(object sender, EventArgs e)
        {
            DataTable filmRental = _repository.GetFilmsRental();
            dataGridViewFilms.DataSource = filmRental;
        }

        private void buttonSearchA_Click(object sender, EventArgs e)
        {
            string firstName = textBoxActorFirstName.Text;
            string lastName = textBoxActorLastName.Text;
            DataTable actors = _repository.GetActor(firstName, lastName);
            dataGridViewFilms.DataSource = actors;
        }

        private void buttonSearchC_Click(object sender, EventArgs e)
        {
            string category = textBoxCategory.Text;
            DataTable categories = _repository.GetCategory(category);
            dataGridViewFilms.DataSource = categories;
        }
    }
}
