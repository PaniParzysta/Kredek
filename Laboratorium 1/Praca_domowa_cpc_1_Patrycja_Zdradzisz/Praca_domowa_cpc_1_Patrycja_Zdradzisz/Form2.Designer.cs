
namespace Praca_domowa_cpc_1_Patrycja_Zdradzisz
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.buttonBack = new System.Windows.Forms.Button();
            this.timerAdd = new System.Windows.Forms.Timer(this.components);
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.textBoxGold = new System.Windows.Forms.TextBox();
            this.textBoxWood = new System.Windows.Forms.TextBox();
            this.textBoxIce = new System.Windows.Forms.TextBox();
            this.textBoxFish = new System.Windows.Forms.TextBox();
            this.textBoxKnowledge = new System.Windows.Forms.TextBox();
            this.textBoxPenguin = new System.Windows.Forms.TextBox();
            this.textBoxPenguinGun = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNewIgloo = new System.Windows.Forms.Button();
            this.buttonNewSawmill = new System.Windows.Forms.Button();
            this.buttonNewFishingSpot = new System.Windows.Forms.Button();
            this.buttonNewSchool = new System.Windows.Forms.Button();
            this.buttonNewPenguinGun = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.AutoSize = true;
            this.buttonBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.Location = new System.Drawing.Point(846, 456);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(132, 61);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back to menu";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // timerAdd
            // 
            this.timerAdd.Interval = 1000;
            this.timerAdd.Tick += new System.EventHandler(this.timerAdd_Tick);
            // 
            // timerEvent
            // 
            this.timerEvent.Interval = 1000;
            this.timerEvent.Tick += new System.EventHandler(this.timerEvent_Tick);
            // 
            // textBoxGold
            // 
            this.textBoxGold.Location = new System.Drawing.Point(74, 13);
            this.textBoxGold.Name = "textBoxGold";
            this.textBoxGold.Size = new System.Drawing.Size(27, 20);
            this.textBoxGold.TabIndex = 1;
            this.textBoxGold.Text = "200";
            // 
            // textBoxWood
            // 
            this.textBoxWood.Location = new System.Drawing.Point(157, 12);
            this.textBoxWood.Name = "textBoxWood";
            this.textBoxWood.Size = new System.Drawing.Size(27, 20);
            this.textBoxWood.TabIndex = 2;
            this.textBoxWood.Text = "0";
            // 
            // textBoxIce
            // 
            this.textBoxIce.Location = new System.Drawing.Point(238, 12);
            this.textBoxIce.Name = "textBoxIce";
            this.textBoxIce.Size = new System.Drawing.Size(27, 20);
            this.textBoxIce.TabIndex = 5;
            this.textBoxIce.Text = "10";
            // 
            // textBoxFish
            // 
            this.textBoxFish.Location = new System.Drawing.Point(333, 13);
            this.textBoxFish.Name = "textBoxFish";
            this.textBoxFish.Size = new System.Drawing.Size(27, 20);
            this.textBoxFish.TabIndex = 7;
            this.textBoxFish.Text = "10";
            // 
            // textBoxKnowledge
            // 
            this.textBoxKnowledge.Location = new System.Drawing.Point(428, 12);
            this.textBoxKnowledge.Name = "textBoxKnowledge";
            this.textBoxKnowledge.Size = new System.Drawing.Size(27, 20);
            this.textBoxKnowledge.TabIndex = 9;
            this.textBoxKnowledge.Text = "0";
            // 
            // textBoxPenguin
            // 
            this.textBoxPenguin.Location = new System.Drawing.Point(523, 11);
            this.textBoxPenguin.Name = "textBoxPenguin";
            this.textBoxPenguin.Size = new System.Drawing.Size(27, 20);
            this.textBoxPenguin.TabIndex = 11;
            this.textBoxPenguin.Text = "10";
            // 
            // textBoxPenguinGun
            // 
            this.textBoxPenguinGun.Location = new System.Drawing.Point(609, 11);
            this.textBoxPenguinGun.Name = "textBoxPenguinGun";
            this.textBoxPenguinGun.Size = new System.Drawing.Size(27, 20);
            this.textBoxPenguinGun.TabIndex = 13;
            this.textBoxPenguinGun.Text = "0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Praca_domowa_cpc_1_Patrycja_Zdradzisz.Properties.Resources.gun_penguin;
            this.pictureBox7.Location = new System.Drawing.Point(556, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Praca_domowa_cpc_1_Patrycja_Zdradzisz.Properties.Resources.penguins;
            this.pictureBox6.Location = new System.Drawing.Point(461, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Praca_domowa_cpc_1_Patrycja_Zdradzisz.Properties.Resources.knowlage;
            this.pictureBox5.Location = new System.Drawing.Point(366, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Praca_domowa_cpc_1_Patrycja_Zdradzisz.Properties.Resources.fish;
            this.pictureBox4.Location = new System.Drawing.Point(271, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Praca_domowa_cpc_1_Patrycja_Zdradzisz.Properties.Resources.ice;
            this.pictureBox3.Location = new System.Drawing.Point(190, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Praca_domowa_cpc_1_Patrycja_Zdradzisz.Properties.Resources.wood;
            this.pictureBox2.Location = new System.Drawing.Point(107, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNewIgloo
            // 
            this.buttonNewIgloo.Location = new System.Drawing.Point(325, 404);
            this.buttonNewIgloo.Name = "buttonNewIgloo";
            this.buttonNewIgloo.Size = new System.Drawing.Size(117, 44);
            this.buttonNewIgloo.TabIndex = 15;
            this.buttonNewIgloo.Text = "New Igloo 50 Gold/50 Ice/ 20 Fish";
            this.buttonNewIgloo.UseVisualStyleBackColor = true;
            this.buttonNewIgloo.Click += new System.EventHandler(this.buttonNewIgloo_Click);
            // 
            // buttonNewSawmill
            // 
            this.buttonNewSawmill.Location = new System.Drawing.Point(592, 376);
            this.buttonNewSawmill.Name = "buttonNewSawmill";
            this.buttonNewSawmill.Size = new System.Drawing.Size(117, 49);
            this.buttonNewSawmill.TabIndex = 16;
            this.buttonNewSawmill.Text = "New Sawmill 50 Gold";
            this.buttonNewSawmill.UseVisualStyleBackColor = true;
            this.buttonNewSawmill.Click += new System.EventHandler(this.buttonNewSawmill_Click);
            // 
            // buttonNewFishingSpot
            // 
            this.buttonNewFishingSpot.Location = new System.Drawing.Point(98, 404);
            this.buttonNewFishingSpot.Name = "buttonNewFishingSpot";
            this.buttonNewFishingSpot.Size = new System.Drawing.Size(106, 44);
            this.buttonNewFishingSpot.TabIndex = 17;
            this.buttonNewFishingSpot.Text = "New Fishing spot 20 Gold/ 50 Wood";
            this.buttonNewFishingSpot.UseVisualStyleBackColor = true;
            this.buttonNewFishingSpot.Click += new System.EventHandler(this.buttonNewFishingSpot_Click);
            // 
            // buttonNewSchool
            // 
            this.buttonNewSchool.Location = new System.Drawing.Point(629, 122);
            this.buttonNewSchool.Name = "buttonNewSchool";
            this.buttonNewSchool.Size = new System.Drawing.Size(131, 39);
            this.buttonNewSchool.TabIndex = 18;
            this.buttonNewSchool.Text = "New School 20 Penguins / 20 Gold ";
            this.buttonNewSchool.UseVisualStyleBackColor = true;
            this.buttonNewSchool.Click += new System.EventHandler(this.buttonNewSchool_Click);
            // 
            // buttonNewPenguinGun
            // 
            this.buttonNewPenguinGun.Location = new System.Drawing.Point(642, 11);
            this.buttonNewPenguinGun.Name = "buttonNewPenguinGun";
            this.buttonNewPenguinGun.Size = new System.Drawing.Size(118, 51);
            this.buttonNewPenguinGun.TabIndex = 19;
            this.buttonNewPenguinGun.Text = "New Gun Penguin 100 Gold/ 20 Knowledge";
            this.buttonNewPenguinGun.UseVisualStyleBackColor = true;
            this.buttonNewPenguinGun.Click += new System.EventHandler(this.buttonNewPenguinGun_Click);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevel.Location = new System.Drawing.Point(852, 18);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(78, 29);
            this.labelLevel.TabIndex = 20;
            this.labelLevel.Text = "Level 1";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 529);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.buttonNewPenguinGun);
            this.Controls.Add(this.buttonNewSchool);
            this.Controls.Add(this.buttonNewFishingSpot);
            this.Controls.Add(this.buttonNewSawmill);
            this.Controls.Add(this.buttonNewIgloo);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.textBoxPenguinGun);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.textBoxPenguin);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.textBoxKnowledge);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBoxFish);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxIce);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxWood);
            this.Controls.Add(this.textBoxGold);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Timer timerAdd;
        private System.Windows.Forms.Timer timerEvent;
        private System.Windows.Forms.TextBox textBoxGold;
        private System.Windows.Forms.TextBox textBoxWood;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxIce;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBoxFish;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox textBoxKnowledge;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBoxPenguin;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox textBoxPenguinGun;
        private System.Windows.Forms.Button buttonNewIgloo;
        private System.Windows.Forms.Button buttonNewSawmill;
        private System.Windows.Forms.Button buttonNewFishingSpot;
        private System.Windows.Forms.Button buttonNewSchool;
        private System.Windows.Forms.Button buttonNewPenguinGun;
        private System.Windows.Forms.Label labelLevel;
    }
}