namespace WindowsFormsDumpTruck
{
    partial class FormParking
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
            this.buttonSetTruck = new System.Windows.Forms.Button();
            this.buttonSetDumpTruck = new System.Windows.Forms.Button();
            this.buttonTakeTruck = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxTakeTruck = new System.Windows.Forms.PictureBox();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetTruck
            // 
            this.buttonSetTruck.Location = new System.Drawing.Point(925, 12);
            this.buttonSetTruck.Name = "buttonSetTruck";
            this.buttonSetTruck.Size = new System.Drawing.Size(130, 54);
            this.buttonSetTruck.TabIndex = 1;
            this.buttonSetTruck.Text = "Припарковать грузовик";
            this.buttonSetTruck.UseVisualStyleBackColor = true;
            this.buttonSetTruck.Click += new System.EventHandler(this.buttonSetTruck_Click);
            // 
            // buttonSetDumpTruck
            // 
            this.buttonSetDumpTruck.Location = new System.Drawing.Point(925, 90);
            this.buttonSetDumpTruck.Name = "buttonSetDumpTruck";
            this.buttonSetDumpTruck.Size = new System.Drawing.Size(130, 67);
            this.buttonSetDumpTruck.TabIndex = 2;
            this.buttonSetDumpTruck.Text = "Припарковать самосвал";
            this.buttonSetDumpTruck.UseVisualStyleBackColor = true;
            this.buttonSetDumpTruck.Click += new System.EventHandler(this.buttonSetDumpTruck_Click);
            // 
            // buttonTakeTruck
            // 
            this.buttonTakeTruck.Location = new System.Drawing.Point(935, 355);
            this.buttonTakeTruck.Name = "buttonTakeTruck";
            this.buttonTakeTruck.Size = new System.Drawing.Size(107, 28);
            this.buttonTakeTruck.TabIndex = 4;
            this.buttonTakeTruck.Text = "Забрать";
            this.buttonTakeTruck.UseVisualStyleBackColor = true;
            this.buttonTakeTruck.Click += new System.EventHandler(this.buttonTakeTruck_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(979, 318);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(54, 22);
            this.maskedTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(902, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Забрать грузовик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Место:";
            // 
            // pictureBoxTakeTruck
            // 
            this.pictureBoxTakeTruck.Location = new System.Drawing.Point(775, 394);
            this.pictureBoxTakeTruck.Name = "pictureBoxTakeTruck";
            this.pictureBoxTakeTruck.Size = new System.Drawing.Size(267, 160);
            this.pictureBoxTakeTruck.TabIndex = 3;
            this.pictureBoxTakeTruck.TabStop = false;
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(752, 554);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.buttonTakeTruck);
            this.Controls.Add(this.pictureBoxTakeTruck);
            this.Controls.Add(this.buttonSetDumpTruck);
            this.Controls.Add(this.buttonSetTruck);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetTruck;
        private System.Windows.Forms.Button buttonSetDumpTruck;
        private System.Windows.Forms.PictureBox pictureBoxTakeTruck;
        private System.Windows.Forms.Button buttonTakeTruck;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}