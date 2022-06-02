namespace HojasDeVida.Formularios
{
    partial class Inicio
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
            this.NewHoja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewHoja
            // 
            this.NewHoja.BackColor = System.Drawing.Color.Aqua;
            this.NewHoja.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewHoja.Location = new System.Drawing.Point(651, 12);
            this.NewHoja.Name = "NewHoja";
            this.NewHoja.Size = new System.Drawing.Size(234, 43);
            this.NewHoja.TabIndex = 0;
            this.NewHoja.Text = "Nueva hoja de vida";
            this.NewHoja.UseVisualStyleBackColor = false;
            this.NewHoja.Click += new System.EventHandler(this.NewHoja_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.NewHoja);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private Button NewHoja;
    }
}