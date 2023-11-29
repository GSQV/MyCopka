using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stalcartefactManual
{
    public partial class FormAdd : Form
    {
        DataBase dataBase= new DataBase();

        public FormAdd()
        {
            InitializeComponent();
            StartPosition= FormStartPosition.CenterScreen;
            textBoxDebuff1.Text="null";
            textBoxDebuff2.Text = "null";
            textBoxDebuff3.Text = "null";
            textBoxBuff1.Text = "null";
            textBoxBuff2.Text = "null";
            textBoxBuff3.Text = "null";
            textBoxBuff4.Text = "null";
            textBoxBuff5.Text = "null";
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Equals("")) || (textBoxAnomaly.Text.Equals("")))
            {
                MessageBox.Show("Все поля должны быть заполнены!!");
            }
            else
            {
                dataBase.openConnection();

                var name = textBoxName.Text;
                var anomaly = textBoxAnomaly.Text;
                var debuff1 = textBoxDebuff1.Text;
                var debuff2 = textBoxDebuff2.Text;
                var debuff3 = textBoxDebuff3.Text;
                var buff1 = textBoxBuff1.Text;
                var buff2 = textBoxBuff2.Text;
                var buff3 = textBoxBuff3.Text;
                var buff4 = textBoxBuff4.Text;
                var buff5 = textBoxBuff5.Text;

                var addQuery = $"insert into stalcartefact_db (name_art, name_anomaly, debuff_1, debuff_2, debuff_3, buff_1, buff_2, buff_3, buff_4, buff_5) values ('{name}','{anomaly}','{debuff1}','{debuff2}','{debuff3}','{buff1}','{buff2}','{buff3}','{buff4}','{buff5}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Артефакт и его свойства успешно добавлены!");
            }
            Close();
        }
    }
}
