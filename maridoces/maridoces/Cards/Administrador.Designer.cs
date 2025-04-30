namespace maridoces
{
    partial class Administrador
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            flp_adm = new FlowLayoutPanel();
            btn_atualizar = new Button();
            btn_NovoProduto = new Button();
            lbl_adm = new Label();
            SuspendLayout();
            // 
            // flp_adm
            // 
            flp_adm.BackColor = Color.Tan;
            flp_adm.Dock = DockStyle.Bottom;
            flp_adm.Location = new Point(0, 66);
            flp_adm.Name = "flp_adm";
            flp_adm.Size = new Size(504, 665);
            flp_adm.TabIndex = 0;
            // 
            // btn_atualizar
            // 
            btn_atualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_atualizar.BackColor = SystemColors.Info;
            btn_atualizar.FlatAppearance.MouseDownBackColor = Color.Tan;
            btn_atualizar.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_atualizar.FlatStyle = FlatStyle.Popup;
            btn_atualizar.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_atualizar.Location = new Point(326, 13);
            btn_atualizar.Name = "btn_atualizar";
            btn_atualizar.Size = new Size(70, 23);
            btn_atualizar.TabIndex = 1;
            btn_atualizar.Text = "Atualizar";
            btn_atualizar.UseVisualStyleBackColor = false;
            // 
            // btn_NovoProduto
            // 
            btn_NovoProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_NovoProduto.BackColor = SystemColors.Info;
            btn_NovoProduto.FlatAppearance.MouseDownBackColor = Color.Tan;
            btn_NovoProduto.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_NovoProduto.FlatStyle = FlatStyle.Popup;
            btn_NovoProduto.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NovoProduto.Location = new Point(402, 13);
            btn_NovoProduto.Name = "btn_NovoProduto";
            btn_NovoProduto.Size = new Size(99, 23);
            btn_NovoProduto.TabIndex = 2;
            btn_NovoProduto.Text = "Novo Produto";
            btn_NovoProduto.UseVisualStyleBackColor = false;
            // 
            // lbl_adm
            // 
            lbl_adm.AutoSize = true;
            lbl_adm.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_adm.Location = new Point(3, 8);
            lbl_adm.Name = "lbl_adm";
            lbl_adm.Size = new Size(171, 25);
            lbl_adm.TabIndex = 3;
            lbl_adm.Text = "Gestão de Produtos";
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            Controls.Add(lbl_adm);
            Controls.Add(btn_NovoProduto);
            Controls.Add(btn_atualizar);
            Controls.Add(flp_adm);
            Name = "Administrador";
            Size = new Size(504, 731);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flp_adm;
        private Button btn_atualizar;
        private Button btn_NovoProduto;
        private Label lbl_adm;
    }
}
