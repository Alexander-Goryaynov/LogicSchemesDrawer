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
    public partial class FormConverter : Form
    {
        private MyConverter converter;
        public FormConverter()
        {
            converter = new MyConverter();
            InitializeComponent();
        }

        private void ButtonSwap_Click(object sender, EventArgs e)
        {
            var temp = textBoxFrom.Text;
            textBoxFrom.Text = textBoxTo.Text;
            textBoxTo.Text = temp;
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxInput.Text) ||
                        string.IsNullOrEmpty(textBoxFrom.Text) ||
                        string.IsNullOrEmpty(textBoxTo.Text))
                {
                    MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
                var from = Convert.ToInt32(textBoxFrom.Text);
                var to = Convert.ToInt32(textBoxTo.Text);
                var input = textBoxInput.Text;
                if (input.Contains("-"))
                {
                    MessageBox.Show("Исходное число должно быть положительным", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
                if (from == to)
                {
                    textBoxResult.Text = input;
                    return;
                }
                if ((from > 16) || (to > 16) || (from < 2) || (to) < 2)
                {
                    MessageBox.Show("с.с. должна быть в диапазоне 2-16", "Ошибка", MessageBoxButtons.OK);
                    return;
                }
                if (from == 10)
                {
                    textBoxResult.Text = converter.DecimalToXSystem(Convert.ToInt32(input), to);
                    return;
                }
                if (to == 10)
                {
                    textBoxResult.Text = converter.ToDecimalSystem(input, from).ToString();
                    return;
                }
                var decimalResult = converter.ToDecimalSystem(input, from);
                textBoxResult.Text = converter.DecimalToXSystem(decimalResult, to);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте исходные данные", "Неизвестная ошибка", MessageBoxButtons.OK);
                return;
            }
        }

        private void ButtonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxResult.Text))
            {
                return;
            }
            Clipboard.SetText(textBoxResult.Text);
        }
    }
}
