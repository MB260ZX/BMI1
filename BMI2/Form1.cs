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
                resultText = "ผอมเกินไป";
            }
            else if (bmi >= 18.5 && bmi <= 24)
            {
                resultText = "น้ำหนักปกติ เหมาะสม";
            }
            else if (bmi >= 25.0 && bmi <= 29.9)
            {
                resultText = "อ้วน";
            }
            else 
            {
                resultText = "อ้วนมาก";
            }
            
            lblResult.Text = $"ค่า BMI: {bmi:F2}\nผลลัพธ์: {resultText}";
        }
    }
}
