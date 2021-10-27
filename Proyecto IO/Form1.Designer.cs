
namespace Proyecto_IO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NumVariables = new System.Windows.Forms.ComboBox();
            this.NumRestricciones = new System.Windows.Forms.ComboBox();
            this.CrearTabla = new System.Windows.Forms.Button();
            this.Solucion = new System.Windows.Forms.Button();
            this.terminar = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.NumVariables);
            this.flowLayoutPanel1.Controls.Add(this.NumRestricciones);
            this.flowLayoutPanel1.Controls.Add(this.CrearTabla);
            this.flowLayoutPanel1.Controls.Add(this.Solucion);
            this.flowLayoutPanel1.Controls.Add(this.terminar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(211, 537);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 125);
            this.panel1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Maximizar",
            "Minimizar"});
            this.comboBox1.Location = new System.Drawing.Point(0, 131);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Objetivo";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NumVariables
            // 
            this.NumVariables.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NumVariables.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NumVariables.FormattingEnabled = true;
            this.NumVariables.IntegralHeight = false;
            this.NumVariables.ItemHeight = 20;
            this.NumVariables.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.NumVariables.Location = new System.Drawing.Point(0, 159);
            this.NumVariables.Margin = new System.Windows.Forms.Padding(0);
            this.NumVariables.Name = "NumVariables";
            this.NumVariables.Size = new System.Drawing.Size(211, 28);
            this.NumVariables.TabIndex = 1;
            this.NumVariables.Text = "Num. Variables";
            this.NumVariables.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // NumRestricciones
            // 
            this.NumRestricciones.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NumRestricciones.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NumRestricciones.FormattingEnabled = true;
            this.NumRestricciones.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.NumRestricciones.Location = new System.Drawing.Point(0, 187);
            this.NumRestricciones.Margin = new System.Windows.Forms.Padding(0);
            this.NumRestricciones.Name = "NumRestricciones";
            this.NumRestricciones.Size = new System.Drawing.Size(211, 28);
            this.NumRestricciones.TabIndex = 0;
            this.NumRestricciones.Text = "Num Restricciones";
            this.NumRestricciones.SelectedIndexChanged += new System.EventHandler(this.NumRestricciones_SelectedIndexChanged);
            // 
            // CrearTabla
            // 
            this.CrearTabla.BackColor = System.Drawing.Color.OrangeRed;
            this.CrearTabla.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CrearTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrearTabla.Font = new System.Drawing.Font("Cartograph CF Demi Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CrearTabla.ForeColor = System.Drawing.Color.White;
            this.CrearTabla.Location = new System.Drawing.Point(0, 215);
            this.CrearTabla.Margin = new System.Windows.Forms.Padding(0);
            this.CrearTabla.Name = "CrearTabla";
            this.CrearTabla.Size = new System.Drawing.Size(211, 45);
            this.CrearTabla.TabIndex = 0;
            this.CrearTabla.Text = "Crear Tabla";
            this.CrearTabla.UseVisualStyleBackColor = false;
            this.CrearTabla.Click += new System.EventHandler(this.CrearTabla_Click);
            this.CrearTabla.MouseEnter += new System.EventHandler(this.CrearTabla_MouseEnter);
            this.CrearTabla.MouseLeave += new System.EventHandler(this.CrearTabla_MouseLeave);
            this.CrearTabla.MouseHover += new System.EventHandler(this.CrearTabla_MouseHover);
            // 
            // Solucion
            // 
            this.Solucion.BackColor = System.Drawing.Color.OrangeRed;
            this.Solucion.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Solucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Solucion.Font = new System.Drawing.Font("Cartograph CF Demi Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Solucion.ForeColor = System.Drawing.Color.White;
            this.Solucion.Location = new System.Drawing.Point(0, 260);
            this.Solucion.Margin = new System.Windows.Forms.Padding(0);
            this.Solucion.Name = "Solucion";
            this.Solucion.Size = new System.Drawing.Size(211, 45);
            this.Solucion.TabIndex = 6;
            this.Solucion.Text = "Solucionar";
            this.Solucion.UseVisualStyleBackColor = false;
            this.Solucion.Click += new System.EventHandler(this.Solucion_Click);
            // 
            // terminar
            // 
            this.terminar.BackColor = System.Drawing.Color.OrangeRed;
            this.terminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.terminar.Font = new System.Drawing.Font("Cartograph CF Demi Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.terminar.ForeColor = System.Drawing.Color.White;
            this.terminar.Location = new System.Drawing.Point(0, 305);
            this.terminar.Margin = new System.Windows.Forms.Padding(0);
            this.terminar.Name = "terminar";
            this.terminar.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.terminar.Size = new System.Drawing.Size(211, 45);
            this.terminar.TabIndex = 4;
            this.terminar.Text = "Terminar";
            this.terminar.UseVisualStyleBackColor = false;
            this.terminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv2
            // 
            this.dgv2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(245, 143);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 51;
            this.dgv2.RowTemplate.Height = 29;
            this.dgv2.Size = new System.Drawing.Size(524, 180);
            this.dgv2.TabIndex = 2;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv1
            // 
            this.dgv1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(245, 329);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 29;
            this.dgv1.Size = new System.Drawing.Size(524, 180);
            this.dgv1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(775, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 364);
            this.listBox1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(20)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 132);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_IO.Properties.Resources.Captura;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox NumVariables;
        public System.Windows.Forms.ComboBox NumRestricciones;
        private System.Windows.Forms.Button CrearTabla;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button Solucion;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button terminar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

