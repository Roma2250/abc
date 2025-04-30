namespace maridoces.conexao
{
    partial class controletres
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
            btn_escpecial = new Button();
            btn_aniversario = new Button();
            SuspendLayout();
            // 
            // btn_Todos
            // 
            btn_Todos.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_Todos.Location = new Point(3, 3);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(81, 33);
            btn_Todos.TabIndex = 2;
            btn_Todos.Text = "Todos";
            btn_Todos.UseVisualStyleBackColor = true;
            // 
            // btn_escpecial
            // 
            btn_escpecial.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_escpecial.Location = new Point(90, 3);
            btn_escpecial.Name = "btn_escpecial";
            btn_escpecial.Size = new Size(132, 33);
            btn_escpecial.TabIndex = 3;
            btn_escpecial.Text = "Especial páscoa";
            btn_escpecial.UseVisualStyleBackColor = true;
            // 
            // btn_aniversario
            // 
            btn_aniversario.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_aniversario.Location = new Point(228, 3);
            btn_aniversario.Name = "btn_aniversario";
            btn_aniversario.Size = new Size(109, 33);
            btn_aniversario.TabIndex = 4;
            btn_aniversario.Text = "Aniversário";
            btn_aniversario.UseVisualStyleBackColor = true;
            // 
            // controletres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_aniversario);
            Controls.Add(btn_escpecial);
            Controls.Add(btn_Todos);
            Name = "controletres";
            Size = new Size(712, 491);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Todos;
        private Button btn_escpecial;
        private Button btn_aniversario;
    }
}
