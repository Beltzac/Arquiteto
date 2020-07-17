namespace Beltzac.Arquiteto.Desktop
{
    partial class Barracao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barracao));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pilaresBaseReforcada = new System.Windows.Forms.Label();
            this.qtdBasesReforcadas = new System.Windows.Forms.Label();
            this.distanciaPilares = new System.Windows.Forms.Label();
            this.qtdPilares = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade Pilares:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distancia Reta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distância Entre Pilares:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade Bases Reforçadas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pilares Base Reforçada:";
            // 
            // pilaresBaseReforcada
            // 
            this.pilaresBaseReforcada.AutoSize = true;
            this.pilaresBaseReforcada.Location = new System.Drawing.Point(145, 127);
            this.pilaresBaseReforcada.Name = "pilaresBaseReforcada";
            this.pilaresBaseReforcada.Size = new System.Drawing.Size(38, 15);
            this.pilaresBaseReforcada.TabIndex = 6;
            this.pilaresBaseReforcada.Text = "label6";
            // 
            // qtdBasesReforcadas
            // 
            this.qtdBasesReforcadas.AutoSize = true;
            this.qtdBasesReforcadas.Location = new System.Drawing.Point(183, 112);
            this.qtdBasesReforcadas.Name = "qtdBasesReforcadas";
            this.qtdBasesReforcadas.Size = new System.Drawing.Size(38, 15);
            this.qtdBasesReforcadas.TabIndex = 7;
            this.qtdBasesReforcadas.Text = "label7";
            // 
            // distanciaPilares
            // 
            this.distanciaPilares.AutoSize = true;
            this.distanciaPilares.Location = new System.Drawing.Point(143, 97);
            this.distanciaPilares.Name = "distanciaPilares";
            this.distanciaPilares.Size = new System.Drawing.Size(38, 15);
            this.distanciaPilares.TabIndex = 8;
            this.distanciaPilares.Text = "label8";
            // 
            // qtdPilares
            // 
            this.qtdPilares.AutoSize = true;
            this.qtdPilares.Location = new System.Drawing.Point(127, 82);
            this.qtdPilares.Name = "qtdPilares";
            this.qtdPilares.Size = new System.Drawing.Size(38, 15);
            this.qtdPilares.TabIndex = 9;
            this.qtdPilares.Text = "label9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.ImageKey = "cog.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(277, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cog.png");
            // 
            // Barracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 151);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.qtdPilares);
            this.Controls.Add(this.distanciaPilares);
            this.Controls.Add(this.qtdBasesReforcadas);
            this.Controls.Add(this.pilaresBaseReforcada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Barracao";
            this.Text = "Calculo Vão Entre Pilares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pilaresBaseReforcada;
        private System.Windows.Forms.Label qtdBasesReforcadas;
        private System.Windows.Forms.Label distanciaPilares;
        private System.Windows.Forms.Label qtdPilares;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}

