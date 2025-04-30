
namespace maridoces
{
    partial class NovoProduto
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
            btn_salvar = new Button();
            lbl_nome = new Label();
            txt_nomeProduto = new TextBox();
            rtb_descricaoProduto = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btn_imagem = new Button();
            btn_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salvar.AutoEllipsis = true;
            btn_salvar.FlatAppearance.BorderSize = 0;
            btn_salvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_salvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btn_salvar.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salvar.Location = new Point(344, 686);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(73, 24);
            btn_salvar.TabIndex = 0;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nome.Location = new Point(88, 290);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(123, 19);
            lbl_nome.TabIndex = 1;
            lbl_nome.Text = "Nome do Produto :";
            // 
            // txt_nomeProduto
            // 
            txt_nomeProduto.BackColor = SystemColors.Info;
            txt_nomeProduto.Location = new Point(88, 312);
            txt_nomeProduto.Name = "txt_nomeProduto";
            txt_nomeProduto.Size = new Size(329, 23);
            txt_nomeProduto.TabIndex = 2;
            // 
            // rtb_descricaoProduto
            // 
            rtb_descricaoProduto.BackColor = SystemColors.Info;
            rtb_descricaoProduto.Location = new Point(88, 382);
            rtb_descricaoProduto.Name = "rtb_descricaoProduto";
            rtb_descricaoProduto.Size = new Size(329, 122);
            rtb_descricaoProduto.TabIndex = 3;
            rtb_descricaoProduto.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 360);
            label1.Name = "label1";
            label1.Size = new Size(150, 19);
            label1.TabIndex = 4;
            label1.Text = "Descrição do Produto :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 544);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 5;
            label2.Text = "Valor do Produto :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(230, 544);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSalmon;
            pictureBox1.Location = new Point(88, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 218);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 31);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 8;
            label3.Text = "Foto do Produto :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(90, 584);
            label4.Name = "label4";
            label4.Size = new Size(149, 19);
            label4.TabIndex = 9;
            label4.Text = "Categoria do Produto :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(90, 623);
            label5.Name = "label5";
            label5.Size = new Size(125, 19);
            label5.TabIndex = 10;
            label5.Text = "Sabor do Produto :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(257, 585);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(257, 624);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(137, 23);
            comboBox2.TabIndex = 12;
            // 
            // btn_imagem
            // 
            btn_imagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_imagem.AutoEllipsis = true;
            btn_imagem.FlatAppearance.BorderSize = 0;
            btn_imagem.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_imagem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btn_imagem.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_imagem.Location = new Point(312, 277);
            btn_imagem.Name = "btn_imagem";
            btn_imagem.Size = new Size(105, 24);
            btn_imagem.TabIndex = 13;
            btn_imagem.Text = "Salvar imagem";
            btn_imagem.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cancelar.AutoEllipsis = true;
            btn_cancelar.FlatAppearance.BorderSize = 0;
            btn_cancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            btn_cancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btn_cancelar.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.Location = new Point(265, 686);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(73, 24);
            btn_cancelar.TabIndex = 14;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // NovoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            Controls.Add(btn_cancelar);
            Controls.Add(btn_imagem);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtb_descricaoProduto);
            Controls.Add(txt_nomeProduto);
            Controls.Add(lbl_nome);
            Controls.Add(btn_salvar);
            Name = "NovoProduto";
            Size = new Size(504, 731);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private Label lbl_nome;
        private TextBox txt_nomeProduto;
        private RichTextBox rtb_descricaoProduto;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private EventHandler NovoProduto_Load;
        private readonly EventHandler lbl_nome_Click;
        private readonly EventHandler label1_Click;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btn_imagem;
        private Button btn_cancelar;

        public EventHandler txt_nomeProduto_TextChanged { get; private set; }
        public EventHandler rtb_descricaoProduto_TextChanged { get; private set; }
        public EventHandler textBox1_TextChanged { get; private set; }
    }
}
