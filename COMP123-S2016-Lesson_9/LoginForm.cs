using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace COMP123_S2016_Lesson_9
{
    public partial class LoginForm : Form
    {
        /**
         * <summary>
         * This is the default constructor 
         * </summary>
         * 
         * @constructor LoginForm
        */
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void _clearForm()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
        }

        /**
         * <summary>
         * This is the LoginButton Click event handler 
         * </summary>
         * 
         * @private
         * @method button1_Click
         * @param {object} sender
         * @param
        */
        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Username"+UsernameTextBox.Text);
            Debug.WriteLine("Password" + PasswordTextBox.Text);
            this._clearForm();
        }
    }
}
