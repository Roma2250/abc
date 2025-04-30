namespace maridoces
{
    partial class lojaProfessor
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
            pnl_header = new Panel();
            lbl_categoria = new Label();
            lbl_nome = new Label();
            img_produto = new PictureBox();
            lbl_valor = new Label();
            lbl_descricao = new Label();
            pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_produto).BeginInit();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.BackColor = SystemColors.AppWorkspace;
            pnl_header.Controls.Add(lbl_categoria);
            pnl_header.Controls.Add(lbl_nome);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(298, 52);
            pnl_header.TabIndex = 0;
            // 
            // lbl_categoria
            // 
            lbl_categoria.Location = new Point(237, 6);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(61, 29);
            lbl_categoria.TabIndex = 1;
            lbl_categoria.Text = "categoria";
            // 
            // lbl_nome
            // 
            lbl_nome.Location = new Point(3, 6);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(102, 29);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "nome";
            // 
            // img_produto
            // 
            img_produto.BackColor = SystemColors.ControlDarkDark;
            img_produto.Dock = DockStyle.Top;
            img_produto.Location = new Point(0, 52);
            img_produto.Name = "img_produto";
            img_produto.Size = new Size(298, 188);
            img_produto.TabIndex = 1;
            img_produto.TabStop = false;
            // 
            // lbl_valor
            // 
            lbl_valor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_valor.AutoEllipsis = true;
            lbl_valor.Location = new Point(246, 267);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(49, 17);
            lbl_valor.TabIndex = 1;
            lbl_valor.Text = "0,00";
            // 
            // lbl_descricao
            // 
            lbl_descricao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbl_descricao.Location = new Point(3, 243);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(237, 66);
            lbl_descricao.TabIndex = 1;
            lbl_descricao.Text = "...";
            // 
            // lojaProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_descricao);
            Controls.Add(lbl_valor);
            Controls.Add(img_produto);
            Controls.Add(pnl_header);
            Name = "lojaProfessor";
            Size = new Size(298, 309);
            pnl_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)img_produto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_header;
        private PictureBox img_produto;
        private Label lbl_nome;
        private Label lbl_valor;
        private Label lbl_descricao;
        private Label lbl_categoria;
    }
}
