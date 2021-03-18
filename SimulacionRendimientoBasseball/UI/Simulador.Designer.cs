
namespace SimulacionRendimientoBasseball.UI
{
    partial class Simulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulador));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.JugadorTextBox = new System.Windows.Forms.TextBox();
            this.DiaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Curvaslabel = new System.Windows.Forms.Label();
            this.Rectaslabel = new System.Windows.Forms.Label();
            this.Sliderlabel = new System.Windows.Forms.Label();
            this.EnfermedadEstlabel = new System.Windows.Forms.Label();
            this.AVGLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LanzamientoLabel = new System.Windows.Forms.Label();
            this.EnfermedadLabel = new System.Windows.Forms.Label();
            this.BatazoLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LanzamientoTextBox = new System.Windows.Forms.TextBox();
            this.CantBatazosLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Cambioslabel = new System.Windows.Forms.Label();
            this.Nudilloslabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lanzamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enfermedad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Batazo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dia";
            // 
            // JugadorTextBox
            // 
            this.JugadorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JugadorTextBox.Location = new System.Drawing.Point(122, 41);
            this.JugadorTextBox.Name = "JugadorTextBox";
            this.JugadorTextBox.ReadOnly = true;
            this.JugadorTextBox.Size = new System.Drawing.Size(31, 30);
            this.JugadorTextBox.TabIndex = 7;
            // 
            // DiaTextBox
            // 
            this.DiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaTextBox.Location = new System.Drawing.Point(218, 41);
            this.DiaTextBox.Name = "DiaTextBox";
            this.DiaTextBox.ReadOnly = true;
            this.DiaTextBox.Size = new System.Drawing.Size(37, 30);
            this.DiaTextBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Nudilloslabel);
            this.groupBox1.Controls.Add(this.Cambioslabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CantBatazosLabel);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.AVGLabel);
            this.groupBox1.Controls.Add(this.EnfermedadEstlabel);
            this.groupBox1.Controls.Add(this.Sliderlabel);
            this.groupBox1.Controls.Add(this.Rectaslabel);
            this.groupBox1.Controls.Add(this.Curvaslabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(549, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 500);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enfermedad que mas afecto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hits por lanzamientos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "AVG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estadisticas";
            // 
            // Curvaslabel
            // 
            this.Curvaslabel.AutoSize = true;
            this.Curvaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Curvaslabel.Location = new System.Drawing.Point(120, 305);
            this.Curvaslabel.Name = "Curvaslabel";
            this.Curvaslabel.Size = new System.Drawing.Size(33, 20);
            this.Curvaslabel.TabIndex = 15;
            this.Curvaslabel.Text = "......";
            // 
            // Rectaslabel
            // 
            this.Rectaslabel.AutoSize = true;
            this.Rectaslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rectaslabel.Location = new System.Drawing.Point(120, 344);
            this.Rectaslabel.Name = "Rectaslabel";
            this.Rectaslabel.Size = new System.Drawing.Size(33, 20);
            this.Rectaslabel.TabIndex = 16;
            this.Rectaslabel.Text = "......";
            // 
            // Sliderlabel
            // 
            this.Sliderlabel.AutoSize = true;
            this.Sliderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sliderlabel.Location = new System.Drawing.Point(120, 379);
            this.Sliderlabel.Name = "Sliderlabel";
            this.Sliderlabel.Size = new System.Drawing.Size(33, 20);
            this.Sliderlabel.TabIndex = 17;
            this.Sliderlabel.Text = "......";
            // 
            // EnfermedadEstlabel
            // 
            this.EnfermedadEstlabel.AutoSize = true;
            this.EnfermedadEstlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnfermedadEstlabel.Location = new System.Drawing.Point(63, 460);
            this.EnfermedadEstlabel.Name = "EnfermedadEstlabel";
            this.EnfermedadEstlabel.Size = new System.Drawing.Size(51, 20);
            this.EnfermedadEstlabel.TabIndex = 18;
            this.EnfermedadEstlabel.Text = "Covid";
            // 
            // AVGLabel
            // 
            this.AVGLabel.AutoSize = true;
            this.AVGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVGLabel.Location = new System.Drawing.Point(63, 130);
            this.AVGLabel.Name = "AVGLabel";
            this.AVGLabel.Size = new System.Drawing.Size(36, 20);
            this.AVGLabel.TabIndex = 18;
            this.AVGLabel.Text = "000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(56, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Curvas";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(56, 347);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Rectas";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(56, 382);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "Slider";
            // 
            // LanzamientoLabel
            // 
            this.LanzamientoLabel.AutoSize = true;
            this.LanzamientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanzamientoLabel.Location = new System.Drawing.Point(190, 308);
            this.LanzamientoLabel.Name = "LanzamientoLabel";
            this.LanzamientoLabel.Size = new System.Drawing.Size(45, 20);
            this.LanzamientoLabel.TabIndex = 22;
            this.LanzamientoLabel.Text = ".........";
            // 
            // EnfermedadLabel
            // 
            this.EnfermedadLabel.AutoSize = true;
            this.EnfermedadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnfermedadLabel.Location = new System.Drawing.Point(191, 445);
            this.EnfermedadLabel.Name = "EnfermedadLabel";
            this.EnfermedadLabel.Size = new System.Drawing.Size(70, 20);
            this.EnfermedadLabel.TabIndex = 23;
            this.EnfermedadLabel.Text = "Ninguna";
            // 
            // BatazoLabel
            // 
            this.BatazoLabel.AutoSize = true;
            this.BatazoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatazoLabel.Location = new System.Drawing.Point(191, 379);
            this.BatazoLabel.Name = "BatazoLabel";
            this.BatazoLabel.Size = new System.Drawing.Size(45, 20);
            this.BatazoLabel.TabIndex = 24;
            this.BatazoLabel.Text = ".........";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(281, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 25);
            this.label18.TabIndex = 25;
            this.label18.Text = "Lanzamiento";
            // 
            // LanzamientoTextBox
            // 
            this.LanzamientoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LanzamientoTextBox.Location = new System.Drawing.Point(411, 41);
            this.LanzamientoTextBox.Name = "LanzamientoTextBox";
            this.LanzamientoTextBox.ReadOnly = true;
            this.LanzamientoTextBox.Size = new System.Drawing.Size(37, 30);
            this.LanzamientoTextBox.TabIndex = 26;
            // 
            // CantBatazosLabel
            // 
            this.CantBatazosLabel.AutoSize = true;
            this.CantBatazosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantBatazosLabel.Location = new System.Drawing.Point(63, 205);
            this.CantBatazosLabel.Name = "CantBatazosLabel";
            this.CantBatazosLabel.Size = new System.Drawing.Size(36, 20);
            this.CantBatazosLabel.TabIndex = 23;
            this.CantBatazosLabel.Text = "000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(45, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(123, 24);
            this.label20.TabIndex = 22;
            this.label20.Text = "Cant. Batazos";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(355, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 57);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(218, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cambios";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nudillos";
            // 
            // Cambioslabel
            // 
            this.Cambioslabel.AutoSize = true;
            this.Cambioslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cambioslabel.Location = new System.Drawing.Point(290, 308);
            this.Cambioslabel.Name = "Cambioslabel";
            this.Cambioslabel.Size = new System.Drawing.Size(33, 20);
            this.Cambioslabel.TabIndex = 26;
            this.Cambioslabel.Text = "......";
            // 
            // Nudilloslabel
            // 
            this.Nudilloslabel.AutoSize = true;
            this.Nudilloslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nudilloslabel.Location = new System.Drawing.Point(290, 350);
            this.Nudilloslabel.Name = "Nudilloslabel";
            this.Nudilloslabel.Size = new System.Drawing.Size(33, 20);
            this.Nudilloslabel.TabIndex = 27;
            this.Nudilloslabel.Text = "......";
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 544);
            this.Controls.Add(this.LanzamientoTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BatazoLabel);
            this.Controls.Add(this.EnfermedadLabel);
            this.Controls.Add(this.LanzamientoLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DiaTextBox);
            this.Controls.Add(this.JugadorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Simulador";
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Simulador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox JugadorTextBox;
        private System.Windows.Forms.TextBox DiaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label AVGLabel;
        private System.Windows.Forms.Label EnfermedadEstlabel;
        private System.Windows.Forms.Label Sliderlabel;
        private System.Windows.Forms.Label Rectaslabel;
        private System.Windows.Forms.Label Curvaslabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LanzamientoLabel;
        private System.Windows.Forms.Label EnfermedadLabel;
        private System.Windows.Forms.Label BatazoLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox LanzamientoTextBox;
        private System.Windows.Forms.Label CantBatazosLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Nudilloslabel;
        private System.Windows.Forms.Label Cambioslabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}