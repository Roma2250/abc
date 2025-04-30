namespace maridoces.componentes
{
    partial class controle
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
            btn_Todos = new Button();
            btn_chocolate = new Button();
            btn_Branca = new Button();
            btn_zero = new Button();
            SuspendLayout();
            // 
            // btn_Todos
            // 
            btn_Todos.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_Todos.Location = new Point(20, 19);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(81, 33);
            btn_Todos.TabIndex = 0;
            btn_Todos.Text = "Todos";
            btn_Todos.UseVisualStyleBackColor = true;
            // 
            // btn_chocolate
            // 
            btn_chocolate.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_chocolate.Location = new Point(230, 19);
            btn_chocolate.Name = "btn_chocolate";
            btn_chocolate.Size = new Size(147, 33);
            btn_chocolate.TabIndex = 2;
            btn_chocolate.Text = "Massa de chocolate";
            btn_chocolate.UseVisualStyleBackColor = true;
            // 
            // btn_Branca
            // 
            btn_Branca.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_Branca.Location = new Point(107, 19);
            btn_Branca.Name = "btn_Branca";
            btn_Branca.Size = new Size(117, 33);
            btn_Branca.TabIndex = 3;
            btn_Branca.Text = "Massa Branca";
            btn_Branca.UseVisualStyleBackColor = true;
            // 
            // btn_zero
            // 
            btn_zero.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_zero.Location = new Point(383, 19);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(96, 33);
            btn_zero.TabIndex = 4;
            btn_zero.Text = "Zero açucar";
            btn_zero.UseVisualStyleBackColor = true;
            // 
            // controle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btn_zero);
            Controls.Add(btn_Branca);
            Controls.Add(btn_chocolate);
            Controls.Add(btn_Todos);
            Name = "controle";
            Size = new Size(727, 536);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Todos;
        private Button btn_chocolate;
        private Button btn_Branca;
        private Button btn_zero;
    }
}
