using JewelryStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryStore.Forms
{
    /// <summary>
    /// форма для авторизации
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// авторизация пользователя по введенным данным
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var context = new ApplicationDbContext();
            //TODO проверка введенных данныъ
            var user = context.Users.Where(x => x.Login == Login.Text && x.Password == Password.Text).FirstOrDefault();
            Cursor.Current = Cursors.Default;
            if (user != null){
                DialogResult = DialogResult.OK;
                Program.User = user;
            }
            else
            {
                MessageBox.Show("Логин и пароль не совпадают", "Ошибка");
            }
        }
    }
}
