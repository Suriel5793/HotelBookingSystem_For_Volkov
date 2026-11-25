using System;
using System.Windows.Forms;
using Diplom.Models;

namespace Diplom.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void расчётПоказателейToolStripMenuItem_Click(object sender, EventArgs e) => new ModelInputForm().ShowDialog();
        private void управлениеНомерамиToolStripMenuItem_Click(object sender, EventArgs e) => new RoomsForm().ShowDialog();
        private void управлениеБронированиямиToolStripMenuItem_Click(object sender, EventArgs e) => new BookingsForm().ShowDialog();
        private void графикиToolStripMenuItem_Click(object sender, EventArgs e) => new ChartsForm().ShowDialog();
        private void рекомендацииToolStripMenuItem_Click(object sender, EventArgs e) => new ForecastForm().ShowDialog();
        private void управлениеФакторамиToolStripMenuItem_Click(object sender, EventArgs e) => new ExternalFactorsForm().ShowDialog();
        private void управлениеПользователямиToolStripMenuItem_Click(object sender, EventArgs e) => new UsersForm().ShowDialog();
    }
}