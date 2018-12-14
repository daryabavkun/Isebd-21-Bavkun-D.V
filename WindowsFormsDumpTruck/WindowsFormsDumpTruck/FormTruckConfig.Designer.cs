namespace WindowsFormsDumpTruck
{
    partial class FormTruckConfig
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
            this.pictureBoxTruck = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTruck = new System.Windows.Forms.Label();
            this.labelDumpTruck = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelFuchsia = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelMaroon = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBurlyWood = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTruck
            // 
            this.pictureBoxTruck.Location = new System.Drawing.Point(14, 14);
            this.pictureBoxTruck.Name = "pictureBoxTruck";
            this.pictureBoxTruck.Size = new System.Drawing.Size(265, 196);
            this.pictureBoxTruck.TabIndex = 0;
            this.pictureBoxTruck.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTruck);
            this.groupBox1.Controls.Add(this.labelDumpTruck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelTruck
            // 
            this.labelTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTruck.Location = new System.Drawing.Point(27, 63);
            this.labelTruck.Name = "labelTruck";
            this.labelTruck.Size = new System.Drawing.Size(161, 65);
            this.labelTruck.TabIndex = 2;
            this.labelTruck.Text = "Грузовик";
            this.labelTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTruck.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragDrop);
            this.labelTruck.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragEnter);
            this.labelTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTruck_MouseDown);
            // 
            // labelDumpTruck
            // 
            this.labelDumpTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDumpTruck.Location = new System.Drawing.Point(27, 147);
            this.labelDumpTruck.Name = "labelDumpTruck";
            this.labelDumpTruck.Size = new System.Drawing.Size(161, 63);
            this.labelDumpTruck.TabIndex = 1;
            this.labelDumpTruck.Text = "Грузовик-самосвал";
            this.labelDumpTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDumpTruck.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragDrop);
            this.labelDumpTruck.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragEnter);
            this.labelDumpTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDumpTruck_MouseDown);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxTruck);
            this.panel1.Location = new System.Drawing.Point(250, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 367);
            this.panel1.TabIndex = 2;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTruck_DragEnter);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(45, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Основной цвет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.label1.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(45, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Доп. цвет";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelBurlyWood);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelFuchsia);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelMaroon);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(572, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 421);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(19, 36);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(60, 55);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(107, 36);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(60, 55);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelFuchsia
            // 
            this.panelFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelFuchsia.Location = new System.Drawing.Point(19, 118);
            this.panelFuchsia.Name = "panelFuchsia";
            this.panelFuchsia.Size = new System.Drawing.Size(60, 55);
            this.panelFuchsia.TabIndex = 1;
            this.panelFuchsia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(107, 118);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(60, 55);
            this.panelBlue.TabIndex = 1;
            this.panelBlue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelMaroon
            // 
            this.panelMaroon.BackColor = System.Drawing.Color.Maroon;
            this.panelMaroon.Location = new System.Drawing.Point(19, 198);
            this.panelMaroon.Name = "panelMaroon";
            this.panelMaroon.Size = new System.Drawing.Size(60, 55);
            this.panelMaroon.TabIndex = 1;
            this.panelMaroon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(107, 198);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(60, 55);
            this.panelYellow.TabIndex = 1;
            this.panelYellow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(19, 276);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(60, 55);
            this.panelGreen.TabIndex = 2;
            this.panelGreen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBurlyWood
            // 
            this.panelBurlyWood.BackColor = System.Drawing.Color.BurlyWood;
            this.panelBurlyWood.Location = new System.Drawing.Point(107, 276);
            this.panelBurlyWood.Name = "panelBurlyWood";
            this.panelBurlyWood.Size = new System.Drawing.Size(60, 55);
            this.panelBurlyWood.TabIndex = 3;
            this.panelBurlyWood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(110, 381);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 52);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTruckConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTruckConfig";
            this.Text = "Выбор грузовика";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTruck)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTruck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDumpTruck;
        private System.Windows.Forms.Label labelTruck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelBurlyWood;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelFuchsia;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelMaroon;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}