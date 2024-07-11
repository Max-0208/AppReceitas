namespace AppReceitas
{
    partial class AddIngrediente
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
            txtQtd = new TextBox();
            txtValor = new TextBox();
            txtMaterial = new TextBox();
            lblQtdIngr = new Label();
            lblValor = new Label();
            lblMaterial = new Label();
            lblAddIngr = new Label();
            bntAddIngr = new Button();
            bntVoltarMenu = new Button();
            SuspendLayout();
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(150, 173);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(301, 23);
            txtQtd.TabIndex = 3;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(150, 134);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(301, 23);
            txtValor.TabIndex = 2;
            // 
            // txtMaterial
            // 
            txtMaterial.Location = new Point(150, 97);
            txtMaterial.MaxLength = 50;
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(301, 23);
            txtMaterial.TabIndex = 1;
            // 
            // lblQtdIngr
            // 
            lblQtdIngr.AutoSize = true;
            lblQtdIngr.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQtdIngr.Location = new Point(23, 172);
            lblQtdIngr.Name = "lblQtdIngr";
            lblQtdIngr.Size = new Size(121, 20);
            lblQtdIngr.TabIndex = 18;
            lblQtdIngr.Text = "Gramas/Unidade";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(101, 133);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(43, 20);
            lblValor.TabIndex = 17;
            lblValor.Text = "Valor";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaterial.Location = new Point(80, 96);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(64, 20);
            lblMaterial.TabIndex = 16;
            lblMaterial.Text = "Material";
            // 
            // lblAddIngr
            // 
            lblAddIngr.AutoSize = true;
            lblAddIngr.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddIngr.Location = new Point(12, 9);
            lblAddIngr.Name = "lblAddIngr";
            lblAddIngr.Size = new Size(207, 25);
            lblAddIngr.TabIndex = 15;
            lblAddIngr.Text = "Adicionar Ingrediente";
            // 
            // bntAddIngr
            // 
            bntAddIngr.Location = new Point(182, 234);
            bntAddIngr.Name = "bntAddIngr";
            bntAddIngr.Size = new Size(124, 51);
            bntAddIngr.TabIndex = 4;
            bntAddIngr.Text = "Adicionar";
            bntAddIngr.UseVisualStyleBackColor = true;
            bntAddIngr.Click += bntAddIngr_Click;
            // 
            // bntVoltarMenu
            // 
            bntVoltarMenu.Location = new Point(411, 9);
            bntVoltarMenu.Name = "bntVoltarMenu";
            bntVoltarMenu.Size = new Size(75, 23);
            bntVoltarMenu.TabIndex = 23;
            bntVoltarMenu.Text = "Voltar";
            bntVoltarMenu.UseVisualStyleBackColor = true;
            bntVoltarMenu.Click += bntVoltarMenu_Click;
            // 
            // AddIngrediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 317);
            Controls.Add(bntVoltarMenu);
            Controls.Add(bntAddIngr);
            Controls.Add(txtQtd);
            Controls.Add(txtValor);
            Controls.Add(txtMaterial);
            Controls.Add(lblQtdIngr);
            Controls.Add(lblValor);
            Controls.Add(lblMaterial);
            Controls.Add(lblAddIngr);
            Name = "AddIngrediente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddIngrediente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQtd;
        private TextBox txtValor;
        private TextBox txtMaterial;
        private Label lblQtdIngr;
        private Label lblValor;
        private Label lblMaterial;
        private Label lblAddIngr;
        private Button bntAddIngr;
        private Button bntVoltarMenu;
    }
}