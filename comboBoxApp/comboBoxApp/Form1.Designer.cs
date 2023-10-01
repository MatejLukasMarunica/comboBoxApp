namespace comboBoxApp
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
            this.dorucak = new System.Windows.Forms.CheckBox();
            this.rucak = new System.Windows.Forms.CheckBox();
            this.vecera = new System.Windows.Forms.CheckBox();
            this.sakrij = new System.Windows.Forms.CheckBox();
            this.posalji = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dorucak
            // 
            this.dorucak.AutoSize = true;
            this.dorucak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dorucak.Location = new System.Drawing.Point(41, 44);
            this.dorucak.Name = "dorucak";
            this.dorucak.Size = new System.Drawing.Size(88, 24);
            this.dorucak.TabIndex = 0;
            this.dorucak.Text = "Doručak";
            this.dorucak.UseVisualStyleBackColor = true;
            // 
            // rucak
            // 
            this.rucak.AutoSize = true;
            this.rucak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rucak.Location = new System.Drawing.Point(41, 131);
            this.rucak.Name = "rucak";
            this.rucak.Size = new System.Drawing.Size(74, 24);
            this.rucak.TabIndex = 1;
            this.rucak.Text = "Ručak";
            this.rucak.UseVisualStyleBackColor = true;
            // 
            // vecera
            // 
            this.vecera.AutoSize = true;
            this.vecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vecera.Location = new System.Drawing.Point(41, 224);
            this.vecera.Name = "vecera";
            this.vecera.Size = new System.Drawing.Size(79, 24);
            this.vecera.TabIndex = 2;
            this.vecera.Text = "Većera";
            this.vecera.UseVisualStyleBackColor = true;
            // 
            // sakrij
            // 
            this.sakrij.AutoSize = true;
            this.sakrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sakrij.Location = new System.Drawing.Point(329, 324);
            this.sakrij.Name = "sakrij";
            this.sakrij.Size = new System.Drawing.Size(128, 24);
            this.sakrij.TabIndex = 3;
            this.sakrij.Text = "Šalji narudžbu";
            this.sakrij.UseVisualStyleBackColor = true;
            this.sakrij.CheckedChanged += new System.EventHandler(this.sakrij_CheckedChanged);
            // 
            // posalji
            // 
            this.posalji.AutoSize = true;
            this.posalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.posalji.Location = new System.Drawing.Point(41, 303);
            this.posalji.Name = "posalji";
            this.posalji.Size = new System.Drawing.Size(204, 66);
            this.posalji.TabIndex = 4;
            this.posalji.Text = "Pošalji";
            this.posalji.UseVisualStyleBackColor = true;
            this.posalji.Click += new System.EventHandler(this.posalji_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 142);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.posalji);
            this.Controls.Add(this.sakrij);
            this.Controls.Add(this.vecera);
            this.Controls.Add(this.rucak);
            this.Controls.Add(this.dorucak);
            this.Name = "Form1";
            this.Text = "comboBoxApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dorucak;
        private System.Windows.Forms.CheckBox rucak;
        private System.Windows.Forms.CheckBox vecera;
        private System.Windows.Forms.CheckBox sakrij;
        private System.Windows.Forms.Button posalji;
        private System.Windows.Forms.TextBox textBox1;
    }
}

