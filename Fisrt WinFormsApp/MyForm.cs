namespace Fisrt_WinFormsApp
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, my first form!", "My First Message Box",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You clicked the button!", "Button Clicked",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
            ++count;
            //lblCount.Text = $"You clicked the button {count} times!";
            lblCount.Text = $"{count}";
        }

        // обробник події Click для кнопки btnHello
        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello, {tbName.Text}!", "Greeting",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = double.Parse(tbFirstNum.Text); // перетворення тексту з tbFirstNum у число з плаваючою комою
                double number2 = double.Parse(tbSecondNum.Text); // перетворення тексту з tbSecondNum у число з плаваючою комою
                double result = number1 + number2; // обчислення суми
                lblResult.Text = result.ToString(); // відображення результату
                lblResult.ForeColor = Color.Green; // встановлення кольору тексту результату
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integers in both number fields.", "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                lblResult.Text = "Error data";
                lblResult.ForeColor = Color.Red; // встановлення кольору тексту результату на червоний у випадку помилки
            }
        }

        private void btnGetDate_Click(object sender, EventArgs e)
        {
                lblDate.Text = $"Selected date: {dateTimePicker1.Value.ToShortDateString()} {maskedTextBox1.Text}";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.Text = $"Selected date: {dateTimePicker1.Value.ToShortDateString()}";
        }
    }
}
