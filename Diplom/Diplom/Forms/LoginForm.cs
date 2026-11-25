using System;
using System.Windows.Forms;
using Diplom.Services;
using Diplom.Models;

namespace Diplom.Forms
{
    public partial class LoginForm : Form
    {
        private DatabaseService _db;

        public LoginForm()
        {
            InitializeComponent();
            _db = new DatabaseService();
        }
    }
}