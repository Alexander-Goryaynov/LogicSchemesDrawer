using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicSchemesDrawer
{
    public partial class FormScheme : Form
    {
        private bool isDarkTheme = false;
        public FormScheme()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        var number = Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value);
                        if ((number != 0) && (number != 1) && (number != -1))
                        {
                            MessageBox.Show("Введённые коэффициенты некорректны \n Прочтите раздел \"Помощь\"",
                                "Ошибка", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private int GetInputRows()
        {
            int result = dataGridView.Rows.Count;
            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (dataGridView.Rows[i].Cells[0].Value != null)
                {
                    break;
                }
                else
                {
                    result--;
                }
            }
            return result;
        }

        private int GetInputColumns()
        {
            int result = dataGridView.Columns.Count;
            for (int i = dataGridView.Columns.Count - 1; i >= 0; i--)
            {
                if (dataGridView.Rows[0].Cells[i].Value != null)
                {
                    break;
                }
                else
                {
                    result--;
                }
            }
            return result;
        }

        private bool IsDataGridEmpty()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        return false;
                    }
                }
            }
            MessageBox.Show("Ни одного коэффициента не указано \n Прочтите раздел \"Помощь\"",
                "Ошибка", MessageBoxButtons.OK);
            return true;
        }

        private int[,] GetInputData(int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value == null)
                        throw new Exception("Input error in dataGrid");
                    result[i, j] = Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value);
                }
            }
            return result;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            picBoxScheme.Image = null;
            if (IsDataGridEmpty())
                return;
            if (!CheckInput())
                return;
            int rows = GetInputRows();
            int cols = GetInputColumns();
            int[,] input;
            try
            {
                input = GetInputData(rows, cols);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введённые данные и \n прочтите раздел \"Помощь\"",
                    "Ошибка", MessageBoxButtons.OK);
                return;
            }
            Draw(input);
            panel.Focus();
        }

        private void Draw(int[,] minForm)
        {
            SchemeDrawer drawer = new SchemeDrawer();
            Bitmap bmp = new Bitmap(picBoxScheme.Width, picBoxScheme.Height);
            Graphics gr = Graphics.FromImage(bmp);
            drawer.DrawScheme(gr, minForm, picBoxScheme.Width, picBoxScheme.Height);
            picBoxScheme.Image = bmp;
        }

        private void ChangeDesignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isDarkTheme)
            {
                BackColor = Color.FromArgb(64, 64, 64);
                isDarkTheme = true;
            }
            else
            {
                BackColor = SystemColors.Control;
                isDarkTheme = false;
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormHelp(isDarkTheme);
            form.ShowDialog();
        }

        private void SaveSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picBoxScheme.Image == null)
            {
                MessageBox.Show("Сначала постройте схему", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            using (SaveFileDialog dialog = new SaveFileDialog { Filter = "jpeg|*.jpeg" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picBoxScheme.Image.Save(dialog.FileName);
                        MessageBox.Show("Схема сохранена", "Готово", MessageBoxButtons.OK);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка при сохранении", "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void ConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormConverter();
            form.ShowDialog();
        }
    }
}
