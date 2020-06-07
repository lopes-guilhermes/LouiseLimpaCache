using System;
using System.Windows.Forms;

namespace LouiseLimpaCache
{
    public partial class LimpaCache : Form
    {
        public LimpaCache()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (LimparCacheIE.Limpar())
                {
                    var confirm = MessageBox.Show("Eai, deu certo?", "", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                        LimpoComSucesso();
                    else
                        DevDeMerda();
                }
            }
            catch (Exception)
            {
                this.DevDeMerda();
            }
        }

        private void LimpoComSucesso()
        {
            using (Tenkis form = new Tenkis() {
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = false,
                MaximizeBox = false,
                MinimizeBox = false
            })
            {
                form.ShowDialog();
            }

        }

        private void DevDeMerda()
        {
            using (DevDeMerda form = new DevDeMerda()
            {
                StartPosition = FormStartPosition.CenterScreen,
                ShowIcon = false,
                MaximizeBox = false,
                MinimizeBox = false
            })
            {
                form.ShowDialog();
            }
        }
    }
}
