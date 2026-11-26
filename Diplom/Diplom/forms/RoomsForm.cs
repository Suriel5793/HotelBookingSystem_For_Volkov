using System;
using System.Linq;
using System.Windows.Forms;
using Diplom.Models;
using Diplom.Services;

namespace Diplom.Forms
{
    public partial class RoomsForm : Form
    {
        private DatabaseService _db;
        private bool _isEditing = false;
        private int _currentEditId = -1;

        public RoomsForm()
        {
            InitializeComponent();
            _db = new DatabaseService();
            LoadData();
            SetEditMode(false);
        }

        private void LoadData()
        {
            dgvRooms.DataSource = null;
            dgvRooms.DataSource = DataStore.Rooms.Select(r => new
            {
                r.RoomId,
                r.RoomNumber,
                r.Category,
                r.BasePricePerNight,
                r.MaintenanceCost,
                r.Capacity,
                r.Status
            }).ToList();

            if (dgvRooms.Columns.Count > 0)
            {
                dgvRooms.Columns["RoomId"].HeaderText = "ID";
                dgvRooms.Columns["RoomNumber"].HeaderText = "Номер";
                dgvRooms.Columns["Category"].HeaderText = "Категория";
                dgvRooms.Columns["BasePricePerNight"].HeaderText = "Цена за ночь, руб.";
                dgvRooms.Columns["MaintenanceCost"].HeaderText = "Затраты в сутки, руб.";
                dgvRooms.Columns["Capacity"].HeaderText = "Вместимость";
                dgvRooms.Columns["Status"].HeaderText = "Статус";
            }

            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpdateStatusLabel();
        }

        private void UpdateStatusLabel()
        {
            lblStatus.Text = $"Всего номеров: {DataStore.Rooms.Count}";
        }

        private void SetEditMode(bool enable)
        {
            grpEdit.Enabled = enable;
            txtRoomNumber.Enabled = enable;
            txtCategory.Enabled = enable;
            txtPrice.Enabled = enable;
            txtCapacity.Enabled = enable;
            txtMaintenanceCost.Enabled = enable;
            cmbStatus.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
            btnAdd.Enabled = !enable;
            btnEdit.Enabled = !enable;
            btnDelete.Enabled = !enable;
        }
    }
}