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
    }
}