
namespace AutomaticPlantWatering
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxPlant = new System.Windows.Forms.PictureBox();
            this.trackBarMoisture = new System.Windows.Forms.TrackBar();
            this.panelMoisture = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelMoisture = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTemperature = new System.Windows.Forms.Panel();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWater = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelWater = new System.Windows.Forms.Panel();
            this.trackBarWater = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoisture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlant
            // 
            this.pictureBoxPlant.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlant.Image")));
            this.pictureBoxPlant.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPlant.Name = "pictureBoxPlant";
            this.pictureBoxPlant.Size = new System.Drawing.Size(277, 350);
            this.pictureBoxPlant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlant.TabIndex = 1;
            this.pictureBoxPlant.TabStop = false;
            // 
            // trackBarMoisture
            // 
            this.trackBarMoisture.AutoSize = false;
            this.trackBarMoisture.BackColor = System.Drawing.Color.White;
            this.trackBarMoisture.LargeChange = 1;
            this.trackBarMoisture.Location = new System.Drawing.Point(15, 107);
            this.trackBarMoisture.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarMoisture.Minimum = 1;
            this.trackBarMoisture.Name = "trackBarMoisture";
            this.trackBarMoisture.Size = new System.Drawing.Size(150, 40);
            this.trackBarMoisture.TabIndex = 2;
            this.trackBarMoisture.Value = 5;
            this.trackBarMoisture.ValueChanged += new System.EventHandler(this.trackBarMoisture_ValueChanged);
            // 
            // panelMoisture
            // 
            this.panelMoisture.BackColor = System.Drawing.Color.White;
            this.panelMoisture.Location = new System.Drawing.Point(15, 147);
            this.panelMoisture.Margin = new System.Windows.Forms.Padding(0);
            this.panelMoisture.Name = "panelMoisture";
            this.panelMoisture.Size = new System.Drawing.Size(150, 20);
            this.panelMoisture.TabIndex = 3;
            this.panelMoisture.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMoisture_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Soil Moisture";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.buttonCalculate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.buttonCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.buttonCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(212)))), ((int)(((byte)(250)))));
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalculate.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(15, 193);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(150, 30);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelMoisture
            // 
            this.labelMoisture.BackColor = System.Drawing.Color.White;
            this.labelMoisture.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoisture.Location = new System.Drawing.Point(15, 82);
            this.labelMoisture.Margin = new System.Windows.Forms.Padding(0);
            this.labelMoisture.Name = "labelMoisture";
            this.labelMoisture.Size = new System.Drawing.Size(150, 25);
            this.labelMoisture.TabIndex = 4;
            this.labelMoisture.Text = "5";
            this.labelMoisture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTemperature
            // 
            this.labelTemperature.BackColor = System.Drawing.Color.White;
            this.labelTemperature.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(15, 218);
            this.labelTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(150, 25);
            this.labelTemperature.TabIndex = 8;
            this.labelTemperature.Text = "25°C";
            this.labelTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Temperature";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTemperature
            // 
            this.panelTemperature.BackColor = System.Drawing.Color.White;
            this.panelTemperature.Location = new System.Drawing.Point(15, 283);
            this.panelTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.panelTemperature.Name = "panelTemperature";
            this.panelTemperature.Size = new System.Drawing.Size(150, 20);
            this.panelTemperature.TabIndex = 7;
            this.panelTemperature.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTemperature_Paint);
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.AutoSize = false;
            this.trackBarTemperature.BackColor = System.Drawing.Color.White;
            this.trackBarTemperature.LargeChange = 1;
            this.trackBarTemperature.Location = new System.Drawing.Point(15, 243);
            this.trackBarTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarTemperature.Maximum = 50;
            this.trackBarTemperature.Minimum = 1;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(150, 40);
            this.trackBarTemperature.TabIndex = 6;
            this.trackBarTemperature.Value = 25;
            this.trackBarTemperature.ValueChanged += new System.EventHandler(this.trackBarTemperature_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelTemperature);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelMoisture);
            this.panel1.Controls.Add(this.panelTemperature);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelMoisture);
            this.panel1.Controls.Add(this.trackBarTemperature);
            this.panel1.Controls.Add(this.trackBarMoisture);
            this.panel1.Location = new System.Drawing.Point(286, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 329);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Attributes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelWater);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panelWater);
            this.panel2.Controls.Add(this.trackBarWater);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonCalculate);
            this.panel2.Location = new System.Drawing.Point(472, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 329);
            this.panel2.TabIndex = 11;
            // 
            // labelWater
            // 
            this.labelWater.BackColor = System.Drawing.Color.White;
            this.labelWater.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWater.Location = new System.Drawing.Point(15, 82);
            this.labelWater.Margin = new System.Windows.Forms.Padding(0);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(150, 25);
            this.labelWater.TabIndex = 14;
            this.labelWater.Text = "1";
            this.labelWater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Water";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWater
            // 
            this.panelWater.BackColor = System.Drawing.Color.White;
            this.panelWater.Location = new System.Drawing.Point(15, 147);
            this.panelWater.Margin = new System.Windows.Forms.Padding(0);
            this.panelWater.Name = "panelWater";
            this.panelWater.Size = new System.Drawing.Size(150, 20);
            this.panelWater.TabIndex = 13;
            this.panelWater.Paint += new System.Windows.Forms.PaintEventHandler(this.panelWater_Paint);
            // 
            // trackBarWater
            // 
            this.trackBarWater.AutoSize = false;
            this.trackBarWater.BackColor = System.Drawing.Color.White;
            this.trackBarWater.Enabled = false;
            this.trackBarWater.LargeChange = 1;
            this.trackBarWater.Location = new System.Drawing.Point(15, 107);
            this.trackBarWater.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarWater.Minimum = 1;
            this.trackBarWater.Name = "trackBarWater";
            this.trackBarWater.Size = new System.Drawing.Size(150, 40);
            this.trackBarWater.TabIndex = 12;
            this.trackBarWater.Value = 1;
            this.trackBarWater.ValueChanged += new System.EventHandler(this.trackBarWater_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(195)))), ((int)(((byte)(247)))));
            this.label5.Location = new System.Drawing.Point(15, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 57);
            this.label5.TabIndex = 11;
            this.label5.Text = "Automatic Plant Watering";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutomaticPlantWatering.Properties.Resources.WateringCan;
            this.pictureBox1.Location = new System.Drawing.Point(66, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxPlant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic Plant Watering | Laconsay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoisture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPlant;
        private System.Windows.Forms.TrackBar trackBarMoisture;
        private System.Windows.Forms.Panel panelMoisture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelMoisture;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTemperature;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelWater;
        private System.Windows.Forms.TrackBar trackBarWater;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

