﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Марафон
{
    public partial class FormLogIn : Form
    {
        /// <summary>
        /// Строка подключения.
        /// </summary>
        public const string TxtCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\u37_1.mdf;Integrated Security=True;Connect Timeout=30";

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u37_1DataSet1.Begun' table. You can move, or remove it, as needed.
            this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Sponsor' table. You can move, or remove it, as needed.
            this.sponsorTableAdapter.Fill(this.u37_1DataSet1.Sponsor);
            // TODO: This line of code loads data into the 'u37_1DataSet1.Zritels' table. You can move, or remove it, as needed.
            this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);
            CbxTypeUser.SelectedIndex = 0;
        }

        private void CbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            TbxPass.UseSystemPasswordChar = !CbxShowPas.Checked;
            CbxShowPas.Text = CbxShowPas.Checked ? "Скрыть пароль" : "Показать пароль";
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            String txtFilter = $"Login = '{TbxLogin.Text}' and Password = '{TbxPass.Text}'";

            //Зритель
            if(CbxTypeUser.SelectedIndex == 0)
            {
                BsZritel.Filter = txtFilter;
                
                if(BsZritel.Count != 0)
                {
                    FormZritel zritel = new FormZritel();
                    this.Visible = false;
                    zritel.BsZritel.Filter = $"Login = '{TbxLogin.Text}'";
                    zritel.ShowDialog();
                    this.Visible = true;
                    this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);
                    TbxLogin.Clear();
                    TbxPass.Clear();
                    TbxLogin.Focus();

                }
                else
                {
                    MessageBox.Show("Нет пользователя с введеным логином и паролем","Ошибка входа",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    TbxLogin.Focus();
                    TbxPass.Clear();
                    return;
                }
            }
            else
            //Бегун
            if(CbxTypeUser.SelectedIndex == 1)
            {
                BsBegun.Filter = txtFilter;

                if (BsBegun.Count != 0)
                {
                    FormBegun begun = new FormBegun();
                    this.Visible = false;
                    begun.BsBegun.Filter = $"Login = '{TbxLogin.Text}'";
                    begun.ShowDialog();
                    this.Visible = true;
                    this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);
                    TbxLogin.Clear();
                    TbxPass.Clear();
                    TbxLogin.Focus();

                }
                else
                {
                    MessageBox.Show("Нет пользователя с введеным логином и паролем", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbxLogin.Focus();
                    TbxPass.Clear();
                    return;
                }
            }
            else
            //Спонсор
            if (CbxTypeUser.SelectedIndex == 2)
            {
                BsSponsor.Filter = txtFilter;

                if (BsSponsor.Count != 0)
                {
                    FormSponsor sponsor = new FormSponsor();
                    this.Visible = false;
                    sponsor.BsSponsor.Filter = $"Login = '{TbxLogin.Text}'";
                    sponsor.ShowDialog();
                    this.Visible = true;
                    this.sponsorTableAdapter.Fill(this.u37_1DataSet1.Sponsor);
                    TbxLogin.Clear();
                    TbxPass.Clear();
                    TbxLogin.Focus();

                }
                else
                {
                    MessageBox.Show("Нет пользователя с введеным логином и паролем", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbxLogin.Focus();
                    TbxPass.Clear();
                    return;
                }
            }

        }

        private void LblRegestry_Click(object sender, EventArgs e)
        {
            FormRegestry regestry = new FormRegestry();
            this.Visible = false;
            regestry.ShowDialog();
            this.Visible = true;

            this.zritelsTableAdapter.Fill(this.u37_1DataSet1.Zritels);
            this.begunTableAdapter.Fill(this.u37_1DataSet1.Begun);
            this.sponsorTableAdapter.Fill(this.u37_1DataSet1.Sponsor);
        }
    }
}
