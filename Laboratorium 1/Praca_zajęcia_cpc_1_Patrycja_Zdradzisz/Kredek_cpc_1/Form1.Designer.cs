﻿
namespace Kredek_cpc_1
{
    partial class FormNew
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
            this.labelFormMainValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFormMainValue
            // 
            this.labelFormMainValue.AutoSize = true;
            this.labelFormMainValue.Location = new System.Drawing.Point(39, 49);
            this.labelFormMainValue.Name = "labelFormMainValue";
            this.labelFormMainValue.Size = new System.Drawing.Size(70, 13);
            this.labelFormMainValue.TabIndex = 0;
            this.labelFormMainValue.Text = "brak wartości";
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelFormMainValue);
            this.Name = "FormNew";
            this.Text = "Nowe okno";
            this.Load += new System.EventHandler(this.FormNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormMainValue;
    }
}