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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }


    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();

        int selectedRow;


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name_art", "Название");
            dataGridView1.Columns.Add("name_anomaly", "Аномалия");
            dataGridView1.Columns.Add("debuff_1", "Дебаф 1");
            dataGridView1.Columns.Add("debuff_2", "Дебаф 2");
            dataGridView1.Columns.Add("debuff_3", "Дебаф 3");
            dataGridView1.Columns.Add("buff_1", "Баф 1");
            dataGridView1.Columns.Add("buff_2", "Баф 2");
            dataGridView1.Columns.Add("buff_3", "Баф 3");
            dataGridView1.Columns.Add("buff_4", "Баф 4");
            dataGridView1.Columns.Add("buff_5", "Баф 5");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetString(7), record.GetString(8), record.GetString(9), record.GetString(10), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from stalcartefact_db";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader); 
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow= e.RowIndex;
            
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[selectedRow];

                    textBoxID.Text = row.Cells[0].Value.ToString();
                    textBoxName.Text = row.Cells[1].Value.ToString();
                    textBoxAnomaly.Text = row.Cells[2].Value.ToString();
                    textBoxDebuff1.Text = row.Cells[3].Value.ToString();
                    textBoxDebuff2.Text = row.Cells[4].Value.ToString();
                    textBoxDebuff3.Text = row.Cells[5].Value.ToString();
                    textBoxBuff1.Text = row.Cells[6].Value.ToString();
                    textBoxBuff2.Text = row.Cells[7].Value.ToString();
                    textBoxBuff3.Text = row.Cells[8].Value.ToString();
                    textBoxBuff4.Text = row.Cells[9].Value.ToString();
                    textBoxBuff5.Text = row.Cells[10].Value.ToString();

                }
        }

        private void buttonAddArt_Click(object sender, EventArgs e)
        {
            FormAdd addForm = new FormAdd();
            addForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
        private void deleteRow()
        {
            dataBase.openConnection();
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[index].Visible = false;
                var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                var deleteQuery = $"delete from stalcartefact_db where id={id}";

                var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                if (!dataGridView1.Rows[index].Cells[0].Displayed)
                {
                    dataGridView1.Rows[index].Cells[10].Value = RowState.Deleted;
                    return;
                }
                dataBase.closeConnection();
            }
        }

        private void Change1()
        {
            dataBase.openConnection();
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                var anomaly = dataGridView1.Rows[index].Cells[2].Value.ToString();
                var debuff1 = dataGridView1.Rows[index].Cells[3].Value.ToString();
                var debuff2 = dataGridView1.Rows[index].Cells[4].Value.ToString();
                var debuff3 = dataGridView1.Rows[index].Cells[5].Value.ToString();
                var buff1 = dataGridView1.Rows[index].Cells[6].Value.ToString();
                var buff2 = dataGridView1.Rows[index].Cells[7].Value.ToString();
                var buff3 = dataGridView1.Rows[index].Cells[8].Value.ToString();
                var buff4 = dataGridView1.Rows[index].Cells[9].Value.ToString();
                var buff5 = dataGridView1.Rows[index].Cells[10].Value.ToString();

                var changeQuery = $"update stalcartefact_db set name_art ='{name}',name_anomaly='{anomaly}, debuff_1='{debuff1}', debuff_2='{debuff2}', debuff_3='{debuff3}', buff_1='{buff1}', buff_5='{buff5}', buff_2='{buff2}', buff_3='{buff3}', buff_4='{buff4}' where id='{id}'";
                var command = new SqlCommand(changeQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
            }
            dataBase.closeConnection();
        }
                
        private void buttonDelArt_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Update12()
        {
            dataBase.openConnection();
            try
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[12].Value;
                    if (rowState == RowState.Existed)
                        continue;
                    if (rowState == RowState.Modified)
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var anomaly = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        var debuff1 = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var debuff2 = dataGridView1.Rows[index].Cells[4].Value.ToString();
                        var debuff3 = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        var buff1 = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        var buff2 = dataGridView1.Rows[index].Cells[7].Value.ToString();
                        var buff3 = dataGridView1.Rows[index].Cells[8].Value.ToString();
                        var buff4 = dataGridView1.Rows[index].Cells[9].Value.ToString();
                        var buff5 = dataGridView1.Rows[index].Cells[10].Value.ToString();

                        var changeQuery = $"update stalcartefact_db set name_art ='{name}',name_anomaly='{anomaly}, debuff_1='{debuff1}', debuff_2='{debuff2}', debuff_3='{debuff3}', buff_1='{buff1}', buff_5='{buff5}', buff_2='{buff2}', buff_3='{buff3}', buff_4='{buff4}' where id='{id}'";
                        var command =new SqlCommand(changeQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Успешно");
            }
            dataBase.closeConnection();
        }

        private void Change()
        {
            try
            {
                dataBase.openConnection();
                var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                var id = textBoxID.Text;
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
                if (dataGridView1.Rows[selectedRow].Cells[0].ToString() != string.Empty)
                {
                    dataGridView1.Rows[selectedRow].SetValues(name, anomaly, debuff1, debuff2, debuff3, buff1, buff2, buff3, buff4, buff5);
                    dataGridView1.Rows[selectedRow].Cells[11].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Ошибка 001!");
                }
                var changeQuery = $"update stalcartefact_db set name_art ='{name}',name_anomaly='{anomaly}, debuff_1='{debuff1}', debuff_2='{debuff2}', debuff_3='{debuff3}', buff_1='{buff1}', buff_5='{buff5}', buff_2='{buff2}', buff_3='{buff3}', buff_4='{buff4}' where id='{id}'";
                var command = new SqlCommand(changeQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                dataBase.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Изменено!");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Change1();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Change();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
