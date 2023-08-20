
namespace WindowsFormsApp1.Forms
{
    partial class FormProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.dataGridViewFilms = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelYearOfProdaction = new System.Windows.Forms.Label();
            this.labelSubtitles = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxYearOfProduction = new System.Windows.Forms.TextBox();
            this.textBoxSubtitles = new System.Windows.Forms.TextBox();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.labelRental = new System.Windows.Forms.Label();
            this.textBoxRental = new System.Windows.Forms.TextBox();
            this.buttonDeleteFilm = new System.Windows.Forms.Button();
            this.buttonEditFilm = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearchByActors = new System.Windows.Forms.Button();
            this.buttonSearchByGenres = new System.Windows.Forms.Button();
            this.buttonViewFilms = new System.Windows.Forms.Button();
            this.buttonRental = new System.Windows.Forms.Button();
            this.buttonSearchC = new System.Windows.Forms.Button();
            this.buttonSearchA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxActorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxActorLastName = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Location = new System.Drawing.Point(404, 290);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(114, 30);
            this.buttonAddFilm.TabIndex = 0;
            this.buttonAddFilm.Text = "Dodaj Film";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // dataGridViewFilms
            // 
            this.dataGridViewFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilms.Location = new System.Drawing.Point(32, 33);
            this.dataGridViewFilms.Name = "dataGridViewFilms";
            this.dataGridViewFilms.RowHeadersWidth = 51;
            this.dataGridViewFilms.RowTemplate.Height = 24;
            this.dataGridViewFilms.Size = new System.Drawing.Size(743, 236);
            this.dataGridViewFilms.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(31, 299);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 17);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(31, 339);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Title";
            // 
            // labelYearOfProdaction
            // 
            this.labelYearOfProdaction.AutoSize = true;
            this.labelYearOfProdaction.Location = new System.Drawing.Point(31, 373);
            this.labelYearOfProdaction.Name = "labelYearOfProdaction";
            this.labelYearOfProdaction.Size = new System.Drawing.Size(125, 17);
            this.labelYearOfProdaction.TabIndex = 4;
            this.labelYearOfProdaction.Text = "Year of production";
            // 
            // labelSubtitles
            // 
            this.labelSubtitles.AutoSize = true;
            this.labelSubtitles.Location = new System.Drawing.Point(31, 409);
            this.labelSubtitles.Name = "labelSubtitles";
            this.labelSubtitles.Size = new System.Drawing.Size(62, 17);
            this.labelSubtitles.TabIndex = 5;
            this.labelSubtitles.Text = "Subtitles";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(31, 442);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(72, 17);
            this.labelLanguage.TabIndex = 6;
            this.labelLanguage.Text = "Language";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(162, 294);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(217, 22);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(162, 334);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(217, 22);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxYearOfProduction
            // 
            this.textBoxYearOfProduction.Location = new System.Drawing.Point(162, 370);
            this.textBoxYearOfProduction.Name = "textBoxYearOfProduction";
            this.textBoxYearOfProduction.Size = new System.Drawing.Size(217, 22);
            this.textBoxYearOfProduction.TabIndex = 9;
            // 
            // textBoxSubtitles
            // 
            this.textBoxSubtitles.Location = new System.Drawing.Point(162, 409);
            this.textBoxSubtitles.Name = "textBoxSubtitles";
            this.textBoxSubtitles.Size = new System.Drawing.Size(217, 22);
            this.textBoxSubtitles.TabIndex = 10;
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.Location = new System.Drawing.Point(162, 442);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(217, 22);
            this.textBoxLanguage.TabIndex = 11;
            // 
            // labelRental
            // 
            this.labelRental.AutoSize = true;
            this.labelRental.Location = new System.Drawing.Point(31, 481);
            this.labelRental.Name = "labelRental";
            this.labelRental.Size = new System.Drawing.Size(49, 17);
            this.labelRental.TabIndex = 12;
            this.labelRental.Text = "Rental";
            // 
            // textBoxRental
            // 
            this.textBoxRental.Location = new System.Drawing.Point(162, 481);
            this.textBoxRental.Name = "textBoxRental";
            this.textBoxRental.Size = new System.Drawing.Size(217, 22);
            this.textBoxRental.TabIndex = 13;
            // 
            // buttonDeleteFilm
            // 
            this.buttonDeleteFilm.Location = new System.Drawing.Point(404, 330);
            this.buttonDeleteFilm.Name = "buttonDeleteFilm";
            this.buttonDeleteFilm.Size = new System.Drawing.Size(114, 30);
            this.buttonDeleteFilm.TabIndex = 14;
            this.buttonDeleteFilm.Text = "Usuń Film";
            this.buttonDeleteFilm.UseVisualStyleBackColor = true;
            this.buttonDeleteFilm.Click += new System.EventHandler(this.buttonDeleteFilm_Click);
            // 
            // buttonEditFilm
            // 
            this.buttonEditFilm.Location = new System.Drawing.Point(404, 370);
            this.buttonEditFilm.Name = "buttonEditFilm";
            this.buttonEditFilm.Size = new System.Drawing.Size(114, 30);
            this.buttonEditFilm.TabIndex = 15;
            this.buttonEditFilm.Text = "Edytuj Film";
            this.buttonEditFilm.UseVisualStyleBackColor = true;
            this.buttonEditFilm.Click += new System.EventHandler(this.buttonEditFilm_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(404, 416);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(114, 30);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Wyczyść pola";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearchByActors
            // 
            this.buttonSearchByActors.Location = new System.Drawing.Point(19, 557);
            this.buttonSearchByActors.Name = "buttonSearchByActors";
            this.buttonSearchByActors.Size = new System.Drawing.Size(152, 30);
            this.buttonSearchByActors.TabIndex = 17;
            this.buttonSearchByActors.Text = "Pokaż filmy i aktorów";
            this.buttonSearchByActors.UseVisualStyleBackColor = true;
            this.buttonSearchByActors.Click += new System.EventHandler(this.buttonSearchByActors_Click);
            // 
            // buttonSearchByGenres
            // 
            this.buttonSearchByGenres.Location = new System.Drawing.Point(187, 557);
            this.buttonSearchByGenres.Name = "buttonSearchByGenres";
            this.buttonSearchByGenres.Size = new System.Drawing.Size(158, 30);
            this.buttonSearchByGenres.TabIndex = 18;
            this.buttonSearchByGenres.Text = "Pokaż filmy i kategorie";
            this.buttonSearchByGenres.UseVisualStyleBackColor = true;
            this.buttonSearchByGenres.Click += new System.EventHandler(this.buttonSearchByGenres_Click);
            // 
            // buttonViewFilms
            // 
            this.buttonViewFilms.Location = new System.Drawing.Point(353, 521);
            this.buttonViewFilms.Name = "buttonViewFilms";
            this.buttonViewFilms.Size = new System.Drawing.Size(152, 30);
            this.buttonViewFilms.TabIndex = 19;
            this.buttonViewFilms.Text = "Pokaż filmy";
            this.buttonViewFilms.UseVisualStyleBackColor = true;
            this.buttonViewFilms.Click += new System.EventHandler(this.buttonViewFilms_Click);
            // 
            // buttonRental
            // 
            this.buttonRental.Location = new System.Drawing.Point(529, 521);
            this.buttonRental.Name = "buttonRental";
            this.buttonRental.Size = new System.Drawing.Size(152, 30);
            this.buttonRental.TabIndex = 20;
            this.buttonRental.Text = "Pokaż wypożyczenia";
            this.buttonRental.UseVisualStyleBackColor = true;
            this.buttonRental.Click += new System.EventHandler(this.buttonRental_Click);
            // 
            // buttonSearchC
            // 
            this.buttonSearchC.Location = new System.Drawing.Point(187, 521);
            this.buttonSearchC.Name = "buttonSearchC";
            this.buttonSearchC.Size = new System.Drawing.Size(152, 30);
            this.buttonSearchC.TabIndex = 22;
            this.buttonSearchC.Text = "Szukaj po gatunku";
            this.buttonSearchC.UseVisualStyleBackColor = true;
            this.buttonSearchC.Click += new System.EventHandler(this.buttonSearchC_Click);
            // 
            // buttonSearchA
            // 
            this.buttonSearchA.Location = new System.Drawing.Point(19, 521);
            this.buttonSearchA.Name = "buttonSearchA";
            this.buttonSearchA.Size = new System.Drawing.Size(152, 30);
            this.buttonSearchA.TabIndex = 21;
            this.buttonSearchA.Text = "Szukaj po aktorze";
            this.buttonSearchA.UseVisualStyleBackColor = true;
            this.buttonSearchA.Click += new System.EventHandler(this.buttonSearchA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Actor first name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Actor last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Category";
            // 
            // textBoxActorFirstName
            // 
            this.textBoxActorFirstName.Location = new System.Drawing.Point(658, 299);
            this.textBoxActorFirstName.Name = "textBoxActorFirstName";
            this.textBoxActorFirstName.Size = new System.Drawing.Size(128, 22);
            this.textBoxActorFirstName.TabIndex = 26;
            // 
            // textBoxActorLastName
            // 
            this.textBoxActorLastName.Location = new System.Drawing.Point(658, 337);
            this.textBoxActorLastName.Name = "textBoxActorLastName";
            this.textBoxActorLastName.Size = new System.Drawing.Size(128, 22);
            this.textBoxActorLastName.TabIndex = 27;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(658, 374);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(128, 22);
            this.textBoxCategory.TabIndex = 28;
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 599);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxActorLastName);
            this.Controls.Add(this.textBoxActorFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchC);
            this.Controls.Add(this.buttonSearchA);
            this.Controls.Add(this.buttonRental);
            this.Controls.Add(this.buttonViewFilms);
            this.Controls.Add(this.buttonSearchByGenres);
            this.Controls.Add(this.buttonSearchByActors);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEditFilm);
            this.Controls.Add(this.buttonDeleteFilm);
            this.Controls.Add(this.textBoxRental);
            this.Controls.Add(this.labelRental);
            this.Controls.Add(this.textBoxLanguage);
            this.Controls.Add(this.textBoxSubtitles);
            this.Controls.Add(this.textBoxYearOfProduction);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.labelSubtitles);
            this.Controls.Add(this.labelYearOfProdaction);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridViewFilms);
            this.Controls.Add(this.buttonAddFilm);
            this.Name = "FormProgram";
            this.Text = "Program";
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddFilm;
        private System.Windows.Forms.DataGridView dataGridViewFilms;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelYearOfProdaction;
        private System.Windows.Forms.Label labelSubtitles;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxYearOfProduction;
        private System.Windows.Forms.TextBox textBoxSubtitles;
        private System.Windows.Forms.TextBox textBoxLanguage;
        private System.Windows.Forms.Label labelRental;
        private System.Windows.Forms.TextBox textBoxRental;
        private System.Windows.Forms.Button buttonDeleteFilm;
        private System.Windows.Forms.Button buttonEditFilm;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearchByActors;
        private System.Windows.Forms.Button buttonSearchByGenres;
        private System.Windows.Forms.Button buttonViewFilms;
        private System.Windows.Forms.Button buttonRental;
        private System.Windows.Forms.Button buttonSearchC;
        private System.Windows.Forms.Button buttonSearchA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxActorFirstName;
        private System.Windows.Forms.TextBox textBoxActorLastName;
        private System.Windows.Forms.TextBox textBoxCategory;
    }
}