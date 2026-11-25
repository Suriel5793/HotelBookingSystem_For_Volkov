using System;
using System.Linq;
using System.Windows.Forms;
using Diplom.Services;

namespace Diplom.Forms
{
    public partial class UsersForm : Form
    {
        private DatabaseService _db;

        public UsersForm()
        {
            InitializeComponent();
            _db = new DatabaseService();
            LoadData();
        }

        private void LoadData()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _db.GetAllUsers().Select(u => new
            {
                u.UserId,
                Логин = u.Login,
                Роль = u.Role,
                Создан = u.CreatedAt.ToShortDateString()
            }).ToList();

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Выберите роль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _db.AddUser(txtLogin.Text.Trim(), txtPassword.Text, cmbRole.SelectedItem.ToString());
                MessageBox.Show("Пользователь добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                txtLogin.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}