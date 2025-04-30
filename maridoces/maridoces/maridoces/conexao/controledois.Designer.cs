namespace maridoces.conexao
{
    partial class controledois
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
            btn_zero = new Button();
            carddois1 = new Cards.carddois();
            SuspendLayout();
            // 
            // btn_Todos
            // 
            btn_Todos.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_Todos.Location = new Point(3, 3);
            btn_Todos.Name = "btn_Todos";
            btn_Todos.Size = new Size(81, 33);
            btn_Todos.TabIndex = 1;
            btn_Todos.Text = "Todos";
            btn_Todos.UseVisualStyleBackColor = true;
            // 
            // btn_zero
            // 
            btn_zero.Font = new Font("Berlin Sans FB", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_zero.Location = new Point(90, 3);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(81, 33);
            btn_zero.TabIndex = 3;
            btn_zero.Text = "Low carb";
            btn_zero.UseVisualStyleBackColor = true;
            // 
            // carddois1
            // 
            carddois1.ImagemDaEtiqueta = Properties.Resources.Group_25;
            carddois1.ImagemDeFundo = Properties.Resources.Frame_9__1_;
            carddois1.linkImagem = null;
            carddois1.Location = new Point(12, 69);
            carddois1.Name = "carddois1";
            carddois1.nomeproduto = "Prestigío";
            carddois1.Size = new Size(150, 150);
            carddois1.TabIndex = 4;
            // 
            // controledois
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(carddois1);
            Controls.Add(btn_zero);
            Controls.Add(btn_Todos);
            Name = "controledois";
            Size = new Size(802, 504);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Todos;
        private Button btn_zero;
        private Cards.carddois carddois1;
    }
}
