namespace BMI2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            lblResult = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(443, 9);
            label1.Name = "label1";
            label1.Size = new Size(512, 48);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวนค่าดัชนีมวลกาย - BMI";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(1334, 95);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(443, 152);
            label3.Name = "label3";
            label3.Size = new Size(512, 48);
            label3.TabIndex = 2;
            label3.Text = "ใส่ค่าน้ำหนัก - ส่วนสูงของคุณ";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(354, 247);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(132, 27);
            txtWeight.TabIndex = 3;
            txtWeight.TextChanged += textBox1_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(911, 247);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(132, 27);
            txtHeight.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 215);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 5;
            label4.Text = "ใส่น้ำหนัก";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(911, 215);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 6;
            label5.Text = "ใส่ส่วนสูง";
            // 
            // button1
            // 
            button1.Location = new Point(666, 290);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "ตกลง";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(460, 344);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(495, 101);
            lblResult.TabIndex = 8;
            lblResult.Text = "แสดงค่าBMI";
            lblResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 464);
            label6.Name = "label6";
            label6.Size = new Size(1334, 353);
            label6.TabIndex = 9;
            label6.Text = resources.GetString("label6.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 826);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label lblResult;
        private Label label6;
    }
}
