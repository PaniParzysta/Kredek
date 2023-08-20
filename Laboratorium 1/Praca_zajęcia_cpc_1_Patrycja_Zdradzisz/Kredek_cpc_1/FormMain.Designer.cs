
namespace Kredek_cpc_1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textboxAdd = new System.Windows.Forms.TextBox();
            this.Counter = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNewWndow = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(39, 33);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(83, 41);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "zmień kolor";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 83);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(83, 41);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "zwiększ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textboxAdd
            // 
            this.textboxAdd.Location = new System.Drawing.Point(149, 94);
            this.textboxAdd.Name = "textboxAdd";
            this.textboxAdd.Size = new System.Drawing.Size(100, 20);
            this.textboxAdd.TabIndex = 2;
            this.textboxAdd.Text = "1";
            // 
            // Counter
            // 
            this.Counter.Interval = 1000;
            this.Counter.Tick += new System.EventHandler(this.Counter_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(39, 130);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(83, 41);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonNewWndow
            // 
            this.buttonNewWndow.Location = new System.Drawing.Point(39, 177);
            this.buttonNewWndow.Name = "buttonNewWndow";
            this.buttonNewWndow.Size = new System.Drawing.Size(83, 41);
            this.buttonNewWndow.TabIndex = 4;
            this.buttonNewWndow.Text = "Nowe okno";
            this.buttonNewWndow.UseVisualStyleBackColor = true;
            this.buttonNewWndow.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.buttonNewWndow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textboxAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonColor);
            this.Name = "FormMain";
            this.Text = "Patrycja Zdradzisz - program laboratorium 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textboxAdd;
        private System.Windows.Forms.Timer Counter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNewWndow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

