namespace AppReceitas
{
    partial class TelaInicial
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
            btnAdd = new Button();
            lblTitulo = new Label();
            btnAddIngr = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(406, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adicionar Receita";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(22, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(82, 25);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Receitas";
            // 
            // btnAddIngr
            // 
            btnAddIngr.Location = new Point(237, 18);
            btnAddIngr.Name = "btnAddIngr";
            btnAddIngr.Size = new Size(139, 32);
            btnAddIngr.TabIndex = 15;
            btnAddIngr.Text = "Adicionar Ingrediente";
            btnAddIngr.UseVisualStyleBackColor = true;
            btnAddIngr.Click += btnAddIngr_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(553, 316);
            dataGridView1.TabIndex = 16;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 400);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddIngr);
            Controls.Add(lblTitulo);
            Controls.Add(btnAdd);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receitas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Label lblTitulo;
        private Button btnAddIngr;
        private DataGridView dataGridView1;
    }
}
