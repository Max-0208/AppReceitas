namespace AppReceitas
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
            lblReceita = new Label();
            lblIngr = new Label();
            btnAdd = new Button();
            txtReceita = new TextBox();
            txtIngr = new TextBox();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // lblReceita
            // 
            lblReceita.AutoSize = true;
            lblReceita.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReceita.Location = new Point(39, 115);
            lblReceita.Name = "lblReceita";
            lblReceita.Size = new Size(58, 20);
            lblReceita.TabIndex = 0;
            lblReceita.Text = "Receita";
            // 
            // lblIngr
            // 
            lblIngr.AutoSize = true;
            lblIngr.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngr.Location = new Point(12, 174);
            lblIngr.Name = "lblIngr";
            lblIngr.Size = new Size(91, 20);
            lblIngr.TabIndex = 1;
            lblIngr.Text = "Ingredientes";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(254, 243);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 44);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtReceita
            // 
            txtReceita.Location = new Point(109, 116);
            txtReceita.MaxLength = 50;
            txtReceita.Name = "txtReceita";
            txtReceita.Size = new Size(496, 23);
            txtReceita.TabIndex = 1;
            // 
            // txtIngr
            // 
            txtIngr.Location = new Point(109, 175);
            txtIngr.MaxLength = 150;
            txtIngr.Name = "txtIngr";
            txtIngr.Size = new Size(496, 23);
            txtIngr.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(22, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 25);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Adicionar Receita";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 358);
            Controls.Add(lblTitulo);
            Controls.Add(txtIngr);
            Controls.Add(txtReceita);
            Controls.Add(btnAdd);
            Controls.Add(lblIngr);
            Controls.Add(lblReceita);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receitas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReceita;
        private Label lblIngr;
        private Button btnAdd;
        private TextBox txtReceita;
        private TextBox txtIngr;
        private Label lblTitulo;
    }
}
