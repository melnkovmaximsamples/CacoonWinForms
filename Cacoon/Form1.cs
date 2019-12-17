using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cacoon
{
    public partial class Cacoon : Form
    {
        private struct Tactics
        {
            public string Method { get; private set; }
            public string Coefficient { get; private set; }
            public string Chance { get; private set; }
            public string Efficiency { get; private set; }
            public string UpOrDown { get; private set; }
            public string Info { get; private set; }

            public Tactics(string Method, string Coefficient, string Chance, string Efficiency, string UpOrDown, string Info)
            {
                this.Method = Method;
                this.Coefficient = Coefficient;
                this.Chance = Chance;
                this.Efficiency = Efficiency;
                this.UpOrDown = UpOrDown;
                this.Info = Info;
            }
        }

        public Cacoon()
        {
            InitializeComponent();
            pictureBox1.Image = System.Drawing.SystemIcons.Information.ToBitmap();
            ReadAndWriteTactics();
        }

        void ReadAndWriteTactics()
        {
            try
            {
                var query = from line in File.ReadAllLines("tactics.txt")
                            let sector = line.Split(';')
                            select new Tactics(sector[0], sector[1], sector[2], sector[3], sector[4], sector[5]);

                foreach (var item in query)
                {
                    Bitmap image = null;
                    switch (item.UpOrDown.Trim())
                    {
                        case "arrowup":
                            image = Properties.Resources.arrowup;
                            break;
                        case "arrowdown":
                            image = Properties.Resources.arrowdown;
                            break;
                    }

                    tMethod.Rows.Add(item.Method, item.Coefficient, item.Chance, item.Efficiency, image, item.Info);
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SumTotal.Text == "" || SumCurr.Text == "")
            {
                MessageBox.Show("Общая сумма/сумма ставки отсутствует", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (int.Parse(SumTotal.Text) < int.Parse(SumCurr.Text))
            {
                MessageBox.Show("Сумма ставки не может быть больше общей суммы", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string text_in_selected_coefficient = tMethod.SelectedRows[0].Cells[1].Value.ToString();
                var numbers = Regex.Matches(text_in_selected_coefficient, @"\d+");
                try
                {
                    if (MessageBox.Show("Ставка сыграла?", "Ставка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SumTotal.Text = (int.Parse(SumTotal.Text) + ((int.Parse(SumCurr.Text) * int.Parse(numbers[1].Value)))).ToString(); 
                    }
                    else
                    {
                        SumTotal.Text = (int.Parse(SumTotal.Text) - ((int.Parse(SumCurr.Text) * int.Parse(numbers[0].Value)))).ToString();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Regex.Replace(tMethod.SelectedRows[0].Cells[5].Value?.ToString(), @"^\s*[^\S]", ""), tMethod.SelectedRows[0].Cells[0].Value?.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
