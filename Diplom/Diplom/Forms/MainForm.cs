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

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (DataStore.CurrentUser != null)
            {
                if (DataStore.CurrentUser.Role == "manager")
                {
                    this.номераToolStripMenuItem.Enabled = false;
                    this.управлениеПользователямиToolStripMenuItem.Enabled = false;
                    this.Text = $"Отель: Управление (Менеджер: {DataStore.CurrentUser.Login})";
                }
                else
                {
                    this.Text = $"Отель: Управление (Администратор: {DataStore.CurrentUser.Login})";
                }
            }
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Смена пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataStore.CurrentUser = null;
                Application.Restart();
            }
        }
    }
}