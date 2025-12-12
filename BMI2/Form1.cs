namespace BMI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double weight = double.Parse(txtWeight.Text);
            double heightCm = double.Parse(txtHeight.Text);

            double heightM = heightCm / 100;

            double bmi = weight / (heightM * heightM);

            string resultText = "";
            if (bmi < 18)
            {
                resultText = "¼ÍÁà¡Ô¹ä»";
            }
            else if (bmi >= 18.5 && bmi <= 24)
            {
                resultText = "¹éÓË¹Ñ¡»¡µÔ àËÁÒÐÊÁ";
            }
            else if (bmi >= 24.1 && bmi <= 29.9)
            {
                resultText = "ÍéÇ¹";
            }
            else 
            {
                resultText = "ÍéÇ¹ÁÒ¡";
            }
            
            lblResult.Text = $"¤èÒ BMI: {bmi:F2}\n¼ÅÅÑ¾¸ì: {resultText}";
        }
    }
}
