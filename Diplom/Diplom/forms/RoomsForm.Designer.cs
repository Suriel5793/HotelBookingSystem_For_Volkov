namespace Diplom.Forms
{
    partial class RoomsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblMaintenanceCost;
        private System.Windows.Forms.TextBox txtMaintenanceCost;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblStatusRoom;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblMaintenanceCost = new System.Windows.Forms.Label();
            this.txtMaintenanceCost = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblStatusRoom = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.grpEdit.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(20, 65);
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(620, 400);

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(660, 65);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Text = "➕ Добавить";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(660, 110);
            this.btnEdit.Size = new System.Drawing.Size(120, 35);
            this.btnEdit.Text = "✏ Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(660, 155);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Text = "🗑 Удалить";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.grpEdit.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.grpEdit.Controls.Add(this.lblRoomNumber);
            this.grpEdit.Controls.Add(this.txtRoomNumber);
            this.grpEdit.Controls.Add(this.lblCategory);
            this.grpEdit.Controls.Add(this.txtCategory);
            this.grpEdit.Controls.Add(this.lblPrice);
            this.grpEdit.Controls.Add(this.txtPrice);
            this.grpEdit.Controls.Add(this.lblMaintenanceCost);
            this.grpEdit.Controls.Add(this.txtMaintenanceCost);
            this.grpEdit.Controls.Add(this.lblCapacity);
            this.grpEdit.Controls.Add(this.txtCapacity);
            this.grpEdit.Controls.Add(this.lblStatusRoom);
            this.grpEdit.Controls.Add(this.cmbStatus);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Controls.Add(this.btnCancel);
            this.grpEdit.Enabled = false;
            this.grpEdit.Location = new System.Drawing.Point(660, 210);
            this.grpEdit.Size = new System.Drawing.Size(260, 380);

            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(15, 30);
            this.lblRoomNumber.Text = "Номер комнаты:";

            this.txtRoomNumber.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomNumber.Location = new System.Drawing.Point(15, 48);
            this.txtRoomNumber.Size = new System.Drawing.Size(230, 23);

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 78);
            this.lblCategory.Text = "Категория:";

            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategory.Location = new System.Drawing.Point(15, 96);
            this.txtCategory.Size = new System.Drawing.Size(230, 23);

            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(15, 126);
            this.lblPrice.Text = "Цена за ночь, руб.:";

            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(15, 144);
            this.txtPrice.Size = new System.Drawing.Size(230, 23);

            this.lblMaintenanceCost.AutoSize = true;
            this.lblMaintenanceCost.Location = new System.Drawing.Point(15, 174);
            this.lblMaintenanceCost.Text = "Затраты в сутки, руб.:";

            this.txtMaintenanceCost.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.txtMaintenanceCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaintenanceCost.Location = new System.Drawing.Point(15, 192);
            this.txtMaintenanceCost.Size = new System.Drawing.Size(230, 23);

            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(15, 222);
            this.lblCapacity.Text = "Вместимость:";

            this.txtCapacity.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.txtCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacity.Location = new System.Drawing.Point(15, 240);
            this.txtCapacity.Size = new System.Drawing.Size(230, 23);

            this.lblStatusRoom.AutoSize = true;
            this.lblStatusRoom.Location = new System.Drawing.Point(15, 270);
            this.lblStatusRoom.Text = "Статус:";

            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(255, 248, 225);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Items.AddRange(new object[] { "свободен", "занят", "ремонт", "забронирован" });
            this.cmbStatus.Location = new System.Drawing.Point(15, 288);
            this.cmbStatus.Size = new System.Drawing.Size(230, 23);

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(32, 330);
            this.btnSave.Size = new System.Drawing.Size(98, 30);
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(140, 330);
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.Text = "❌ Отмена";
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 480);
            this.lblStatus.Text = "Всего номеров: 0";

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(805, 520);
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(210, 180, 140);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(933, 50);

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(62, 44, 28);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 12);
            this.lblFormTitle.Text = "Управление гостиничными номерами";

            this.BackColor = System.Drawing.Color.FromArgb(253, 245, 230);
            this.ClientSize = new System.Drawing.Size(933, 565);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Управление номерами";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.grpEdit.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}