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
            this.tableData = new System.Windows.Forms.DataGridView();
            this.searchName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tfName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tfYears = new System.Windows.Forms.TextBox();
            this.searchYearsOld = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tfExp = new System.Windows.Forms.TextBox();
            this.searchExp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.SuspendLayout();
            // 
            // NewHoja
            // 
            this.NewHoja.BackColor = System.Drawing.Color.Aqua;
            this.NewHoja.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewHoja.Location = new System.Drawing.Point(732, 12);
            this.NewHoja.Name = "NewHoja";
            this.NewHoja.Size = new System.Drawing.Size(234, 43);
            this.NewHoja.TabIndex = 0;
            this.NewHoja.Text = "Nueva hoja de vida";
            this.NewHoja.UseVisualStyleBackColor = false;
            this.NewHoja.Click += new System.EventHandler(this.NewHoja_Click);
            // 
            // tableData
            // 
            this.tableData.AllowUserToAddRows = false;
            this.tableData.AllowUserToDeleteRows = false;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData.Location = new System.Drawing.Point(12, 126);
            this.tableData.Name = "tableData";
            this.tableData.ReadOnly = true;
            this.tableData.RowHeadersWidth = 51;
            this.tableData.RowTemplate.Height = 29;
            this.tableData.Size = new System.Drawing.Size(617, 370);
            this.tableData.TabIndex = 1;
            // 
            // searchName
            // 
            this.searchName.BackColor = System.Drawing.Color.NavajoWhite;
            this.searchName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchName.Location = new System.Drawing.Point(782, 162);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(94, 29);
            this.searchName.TabIndex = 2;
            this.searchName.Text = "Buscar";
            this.searchName.UseVisualStyleBackColor = false;
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hojas de vida";
            // 
            // tfName
            // 
            this.tfName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tfName.Location = new System.Drawing.Point(651, 162);
            this.tfName.Name = "tfName";
            this.tfName.Size = new System.Drawing.Size(125, 31);
            this.tfName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(651, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar por nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(651, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar por edad";
            // 
            // tfYears
            // 
            this.tfYears.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tfYears.Location = new System.Drawing.Point(651, 293);
            this.tfYears.Name = "tfYears";
            this.tfYears.Size = new System.Drawing.Size(125, 31);
            this.tfYears.TabIndex = 7;
            // 
            // searchYearsOld
            // 
            this.searchYearsOld.BackColor = System.Drawing.Color.NavajoWhite;
            this.searchYearsOld.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchYearsOld.Location = new System.Drawing.Point(782, 293);
            this.searchYearsOld.Name = "searchYearsOld";
            this.searchYearsOld.Size = new System.Drawing.Size(94, 29);
            this.searchYearsOld.TabIndex = 6;
            this.searchYearsOld.Text = "Buscar";
            this.searchYearsOld.UseVisualStyleBackColor = false;
            this.searchYearsOld.Click += new System.EventHandler(this.searchYearsOld_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(651, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buscar por años de experiencia";
            // 
            // tfExp
            // 
            this.tfExp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tfExp.Location = new System.Drawing.Point(651, 419);
            this.tfExp.Name = "tfExp";
            this.tfExp.Size = new System.Drawing.Size(125, 31);
            this.tfExp.TabIndex = 10;
            this.tfExp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // searchExp
            // 
            this.searchExp.BackColor = System.Drawing.Color.NavajoWhite;
            this.searchExp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchExp.Location = new System.Drawing.Point(782, 419);
            this.searchExp.Name = "searchExp";
            this.searchExp.Size = new System.Drawing.Size(94, 29);
            this.searchExp.TabIndex = 9;
            this.searchExp.Text = "Buscar";
            this.searchExp.UseVisualStyleBackColor = false;
            this.searchExp.Click += new System.EventHandler(this.searchExp_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tfExp);
            this.Controls.Add(this.searchExp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tfYears);
            this.Controls.Add(this.searchYearsOld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tfName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.NewHoja);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NewHoja;
        private DataGridView tableData;
        private Button searchName;
        private Label label1;
        private TextBox tfName;
        private Label label2;
        private Label label3;
        private TextBox tfYears;
        private Button searchYearsOld;
        private Label label4;
        private TextBox tfExp;
        private Button searchExp;
    }
}