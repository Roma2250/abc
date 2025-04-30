using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maridoces
{
    [DefaultEvent("Click")] //Defone o evento padrão como "CLICK"
    public partial class lojaProfessor : UserControl
    {

        [Category("# Opção do Card")]
        public string nomeCard
        {
            get { return lbl_nome.Text; }
            set { lbl_nome.Text = value; }

        }
        [Category("# Opção do Card")]
        public string descricaoCard
        {
            get { return lbl_descricao.Text; }
            set { lbl_descricao.Text = value; }

        }
        [Category("# Opção do Card")]
        public string valorCard
        {
            get { return lbl_valor.Text; }
            set { lbl_valor.Text = value; }

        }
        [Category("# Opção do Card")]
        public string categoriaCard
        {
            get { return lbl_categoria.Text; }
            set { lbl_categoria.Text = value; }

        }
        [Category("# Opção do Card")]
        public string urlDaImagemCard
        {
            get { return img_produto.ImageLocation; }
            set { img_produto.ImageLocation = value; }

        }
        [Category("# Opção do Card")]
        public Image blobDaImagemCard
        {
            get { return img_produto.Image; }
            set { img_produto.Image = value; }

        }
        [Category("# Opção do Card")]
        public Color corCard
        {
            get { return pnl_header.BackColor; }
            set { pnl_header.BackColor = value; }

        }




        public lojaProfessor()
        {
            InitializeComponent();
        }


    }
}
