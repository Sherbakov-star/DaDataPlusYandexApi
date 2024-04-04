namespace WinFormsTest2Programm
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
            textBox = new TextBox();
            RecognizeBtn = new Button();
            FindAdress = new Button();
            coordinates = new Label();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(243, 230);
            textBox.Name = "textBox";
            textBox.Size = new Size(320, 27);
            textBox.TabIndex = 0;
            // 
            // RecognizeBtn
            // 
            RecognizeBtn.Location = new Point(243, 268);
            RecognizeBtn.Name = "RecognizeBtn";
            RecognizeBtn.Size = new Size(320, 29);
            RecognizeBtn.TabIndex = 1;
            RecognizeBtn.Text = "Распознать";
            RecognizeBtn.UseVisualStyleBackColor = true;
            RecognizeBtn.Click += Recognize;
            // 
            // FindAdress
            // 
            FindAdress.Location = new Point(243, 303);
            FindAdress.Name = "FindAdress";
            FindAdress.Size = new Size(320, 29);
            FindAdress.TabIndex = 2;
            FindAdress.Text = "Найти на карте";
            FindAdress.UseVisualStyleBackColor = true;
            FindAdress.Click += FindOnMap;
            // 
            // coordinates
            // 
            coordinates.AutoSize = true;
            coordinates.Location = new Point(247, 198);
            coordinates.Name = "coordinates";
            coordinates.Size = new Size(0, 20);
            coordinates.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(coordinates);
            Controls.Add(FindAdress);
            Controls.Add(RecognizeBtn);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button RecognizeBtn;
        private Button FindAdress;
        private Label coordinates;
    }
}
