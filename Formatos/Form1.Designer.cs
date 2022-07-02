
namespace Formatos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_Blue = new System.Windows.Forms.Button();
            this.btn_Green = new System.Windows.Forms.Button();
            this.btn_Reduce = new System.Windows.Forms.Button();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Redtxt = new System.Windows.Forms.Button();
            this.btn_Greentxt = new System.Windows.Forms.Button();
            this.btn_Bluetxt = new System.Windows.Forms.Button();
            this.numericUpDown1_TextSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ckb_Underline = new System.Windows.Forms.CheckBox();
            this.ckb_Cursive = new System.Windows.Forms.CheckBox();
            this.ckb_Bold = new System.Windows.Forms.CheckBox();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbox_Fuentes = new System.Windows.Forms.ListBox();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_TextSize)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btn_Reduce);
            this.panel1.Controls.Add(this.btn_Maximize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 140);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Red);
            this.groupBox1.Controls.Add(this.btn_Blue);
            this.groupBox1.Controls.Add(this.btn_Green);
            this.groupBox1.Location = new System.Drawing.Point(18, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color de formulario";
            // 
            // btn_Red
            // 
            this.btn_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Red.Location = new System.Drawing.Point(95, 22);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(38, 38);
            this.btn_Red.TabIndex = 2;
            this.btn_Red.UseVisualStyleBackColor = false;
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // btn_Blue
            // 
            this.btn_Blue.BackColor = System.Drawing.Color.Blue;
            this.btn_Blue.Location = new System.Drawing.Point(51, 22);
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(38, 38);
            this.btn_Blue.TabIndex = 1;
            this.btn_Blue.UseVisualStyleBackColor = false;
            this.btn_Blue.Click += new System.EventHandler(this.btn_Blue_Click);
            // 
            // btn_Green
            // 
            this.btn_Green.BackColor = System.Drawing.Color.Green;
            this.btn_Green.Location = new System.Drawing.Point(7, 22);
            this.btn_Green.Name = "btn_Green";
            this.btn_Green.Size = new System.Drawing.Size(38, 38);
            this.btn_Green.TabIndex = 0;
            this.btn_Green.UseVisualStyleBackColor = false;
            this.btn_Green.Click += new System.EventHandler(this.btn_Green_Click);
            // 
            // btn_Reduce
            // 
            this.btn_Reduce.Location = new System.Drawing.Point(99, 32);
            this.btn_Reduce.Name = "btn_Reduce";
            this.btn_Reduce.Size = new System.Drawing.Size(75, 23);
            this.btn_Reduce.TabIndex = 2;
            this.btn_Reduce.Text = "Reducir";
            this.btn_Reduce.UseVisualStyleBackColor = true;
            this.btn_Reduce.Click += new System.EventHandler(this.btn_Reduce_Click_1);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Location = new System.Drawing.Point(18, 32);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(75, 23);
            this.btn_Maximize.TabIndex = 1;
            this.btn_Maximize.Text = "Aumentar";
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Propiedades del FROM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.numericUpDown1_TextSize);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 158);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Redtxt);
            this.groupBox2.Controls.Add(this.btn_Greentxt);
            this.groupBox2.Controls.Add(this.btn_Bluetxt);
            this.groupBox2.Location = new System.Drawing.Point(18, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 66);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color de texto";
            // 
            // btn_Redtxt
            // 
            this.btn_Redtxt.BackColor = System.Drawing.Color.Red;
            this.btn_Redtxt.Location = new System.Drawing.Point(95, 22);
            this.btn_Redtxt.Name = "btn_Redtxt";
            this.btn_Redtxt.Size = new System.Drawing.Size(38, 38);
            this.btn_Redtxt.TabIndex = 5;
            this.btn_Redtxt.UseVisualStyleBackColor = false;
            this.btn_Redtxt.Click += new System.EventHandler(this.btn_Redtxt_Click);
            // 
            // btn_Greentxt
            // 
            this.btn_Greentxt.BackColor = System.Drawing.Color.Green;
            this.btn_Greentxt.Location = new System.Drawing.Point(7, 22);
            this.btn_Greentxt.Name = "btn_Greentxt";
            this.btn_Greentxt.Size = new System.Drawing.Size(38, 38);
            this.btn_Greentxt.TabIndex = 3;
            this.btn_Greentxt.UseVisualStyleBackColor = false;
            this.btn_Greentxt.Click += new System.EventHandler(this.btn_Greentxt_Click);
            // 
            // btn_Bluetxt
            // 
            this.btn_Bluetxt.BackColor = System.Drawing.Color.Blue;
            this.btn_Bluetxt.Location = new System.Drawing.Point(51, 22);
            this.btn_Bluetxt.Name = "btn_Bluetxt";
            this.btn_Bluetxt.Size = new System.Drawing.Size(38, 38);
            this.btn_Bluetxt.TabIndex = 4;
            this.btn_Bluetxt.UseVisualStyleBackColor = false;
            this.btn_Bluetxt.Click += new System.EventHandler(this.btn_Bluetxt_Click);
            // 
            // numericUpDown1_TextSize
            // 
            this.numericUpDown1_TextSize.Location = new System.Drawing.Point(18, 36);
            this.numericUpDown1_TextSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1_TextSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1_TextSize.Name = "numericUpDown1_TextSize";
            this.numericUpDown1_TextSize.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1_TextSize.TabIndex = 1;
            this.numericUpDown1_TextSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1_TextSize.ValueChanged += new System.EventHandler(this.numericUpDown1_TextSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tamaño del texto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ckb_Underline);
            this.panel3.Controls.Add(this.ckb_Cursive);
            this.panel3.Controls.Add(this.ckb_Bold);
            this.panel3.Controls.Add(this.btn_Hide);
            this.panel3.Controls.Add(this.btn_Show);
            this.panel3.Controls.Add(this.btn_Close);
            this.panel3.Location = new System.Drawing.Point(12, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 93);
            this.panel3.TabIndex = 2;
            // 
            // ckb_Underline
            // 
            this.ckb_Underline.AutoSize = true;
            this.ckb_Underline.Location = new System.Drawing.Point(250, 59);
            this.ckb_Underline.Name = "ckb_Underline";
            this.ckb_Underline.Size = new System.Drawing.Size(82, 19);
            this.ckb_Underline.TabIndex = 9;
            this.ckb_Underline.Text = "Subrayado";
            this.ckb_Underline.UseVisualStyleBackColor = true;
            this.ckb_Underline.CheckedChanged += new System.EventHandler(this.ckb_Underline_CheckedChanged);
            // 
            // ckb_Cursive
            // 
            this.ckb_Cursive.AutoSize = true;
            this.ckb_Cursive.Location = new System.Drawing.Point(134, 59);
            this.ckb_Cursive.Name = "ckb_Cursive";
            this.ckb_Cursive.Size = new System.Drawing.Size(65, 19);
            this.ckb_Cursive.TabIndex = 8;
            this.ckb_Cursive.Text = "Cursiva";
            this.ckb_Cursive.UseVisualStyleBackColor = true;
            this.ckb_Cursive.CheckedChanged += new System.EventHandler(this.ckb_Cursive_CheckedChanged);
            // 
            // ckb_Bold
            // 
            this.ckb_Bold.AutoSize = true;
            this.ckb_Bold.Location = new System.Drawing.Point(18, 59);
            this.ckb_Bold.Name = "ckb_Bold";
            this.ckb_Bold.Size = new System.Drawing.Size(65, 19);
            this.ckb_Bold.TabIndex = 7;
            this.ckb_Bold.Text = "Negrita";
            this.ckb_Bold.UseVisualStyleBackColor = true;
            this.ckb_Bold.CheckedChanged += new System.EventHandler(this.ckb_Bold_CheckedChanged);
            // 
            // btn_Hide
            // 
            this.btn_Hide.Location = new System.Drawing.Point(18, 16);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(89, 23);
            this.btn_Hide.TabIndex = 4;
            this.btn_Hide.Text = "Ocultar texto";
            this.btn_Hide.UseVisualStyleBackColor = true;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(134, 16);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(87, 23);
            this.btn_Show.TabIndex = 5;
            this.btn_Show.Text = "Mostrar texto";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(250, 16);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(90, 23);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbox_Fuentes
            // 
            this.lbox_Fuentes.FormattingEnabled = true;
            this.lbox_Fuentes.ItemHeight = 15;
            this.lbox_Fuentes.Location = new System.Drawing.Point(400, 14);
            this.lbox_Fuentes.Name = "lbox_Fuentes";
            this.lbox_Fuentes.Size = new System.Drawing.Size(183, 394);
            this.lbox_Fuentes.TabIndex = 3;
            this.lbox_Fuentes.SelectedIndexChanged += new System.EventHandler(this.lbox_Fuentes_SelectedIndexChanged);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Location = new System.Drawing.Point(245, 214);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(40, 15);
            this.lbl_Texto.TabIndex = 4;
            this.lbl_Texto.Text = "TEXTO";
            this.lbl_Texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 536);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.lbox_Fuentes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(900, 775);
            this.MinimumSize = new System.Drawing.Size(616, 475);
            this.Name = "Form1";
            this.Text = "Formatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_TextSize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Reduce;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbox_Fuentes;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_Blue;
        private System.Windows.Forms.Button btn_Green;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1_TextSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_Underline;
        private System.Windows.Forms.CheckBox ckb_Cursive;
        private System.Windows.Forms.CheckBox ckb_Bold;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Redtxt;
        private System.Windows.Forms.Button btn_Greentxt;
        private System.Windows.Forms.Button btn_Bluetxt;
    }
}

