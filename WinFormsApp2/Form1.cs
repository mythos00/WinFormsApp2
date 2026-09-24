namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;

            // 1-ci ədədi yoxlayırıq
            if (!double.TryParse(textBox1.Text, out num1))
            {
                MessageBox.Show("NUM 1 düzgün daxil edilməyib!");
                return;
            }

            // 2-ci ədədi yoxlayırıq
            if (!double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("NUM 2 düzgün daxil edilməyib!");
                return;
            }

            // Əməliyyat seçilib?
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Əməliyyat seçin!");
                return;
            }

            string command = comboBox1.SelectedItem.ToString();

            double result = 0;

            switch (command)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;

                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("0-a bölmək olmaz!");
                        return;
                    }

                    result = num1 / num2;
                    break;
            }

            // Nəticəni label6-da göstər
            label6.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            comboBox1.SelectedIndex = -1;

            label6.Text = "0";
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '-' && textBox1.SelectionStart == 0 && !textBox1.Text.Contains("-"))
            {
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                !textBox1.Text.Contains(".") &&
                !textBox1.Text.Contains(","))
            {
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '-' && textBox2.SelectionStart == 0 && !textBox2.Text.Contains("-"))
            {
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') &&
                !textBox2.Text.Contains(".") &&
                !textBox2.Text.Contains(","))
            {
                return;
            }
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
