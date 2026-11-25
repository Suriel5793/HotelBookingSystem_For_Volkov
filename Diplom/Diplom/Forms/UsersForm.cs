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
    }
}