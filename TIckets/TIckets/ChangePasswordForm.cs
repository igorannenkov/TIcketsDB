﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TIckets.Users;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TIckets
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserPassword FROM Users WHERE UserLogin = @currentLogin", connection);
                cmd.Parameters.AddWithValue("@currentLogin", Account.currentUserLogin);
                string currentPwdHashMd5 = (string)cmd.ExecuteScalar();

                if (currentPwdHashMd5 != HashGenerator.GetMD5(oldPwdTb.Text))
                {
                    MessageBox.Show("Введен неверный пароль. Убедитесь в правильности и повторите ввод.",
                        "Ошибка смены пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newPwdTb.Text != confirmPwdTb.Text)
                {
                    MessageBox.Show("Пароль и его подтверждение не совпадают. Повторите ввод.",
                       "Ошибка смены пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmd = new SqlCommand("UPDATE Users SET " +
                                        "UserPassword = @userPassword " +
                                        "WHERE UserLogin = @userLogin", connection);

                cmd.Parameters.AddWithValue("@userPassword", HashGenerator.GetMD5(newPwdTb.Text));
                cmd.Parameters.AddWithValue("@userLogin", Account.currentUserLogin);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Пароль успешно изменен.", "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newPwdTb_TextChanged(object sender, EventArgs e)
        {
            PasswordStrengthLbl.Text = newPwdTb.Text.GetPasswordStrength(out Color color);
            PasswordStrengthLbl.ForeColor = color;    
        }

        private void ShowCurrentPwdBtn_MouseDown(object sender, MouseEventArgs e)
        {
            oldPwdTb.PasswordChar = '\0';
        }

        private void ShowCurrentPwdBtn_MouseUp(object sender, MouseEventArgs e)
        {
            oldPwdTb.PasswordChar = '*';
        }

        private void ShowNewPwdBtn_MouseDown(object sender, MouseEventArgs e)
        {
            newPwdTb.PasswordChar = '\0';
        }

        private void ShowNewPwdBtn_MouseUp(object sender, MouseEventArgs e)
        {

            newPwdTb.PasswordChar = '*';
        } 

        private void ShowConfirmPwdBtn_MouseDown(object sender, MouseEventArgs e)
        {        
            confirmPwdTb.PasswordChar = '\0';
        }

        private void ShowConfirmPwdBtn_MouseUp(object sender, MouseEventArgs e)
        {
            confirmPwdTb.PasswordChar = '*';
        }
    }
}