namespace HelloApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ex1 = new System.Windows.Forms.Panel();
            this.TextB = new System.Windows.Forms.Label();
            this.TextA = new System.Windows.Forms.Label();
            this.TextInputX = new System.Windows.Forms.Label();
            this.InputX = new System.Windows.Forms.TextBox();
            this.TextInputY = new System.Windows.Forms.Label();
            this.InputY = new System.Windows.Forms.TextBox();
            this.TextInputZ = new System.Windows.Forms.Label();
            this.InputZ = new System.Windows.Forms.TextBox();
            this.CalculateAB = new System.Windows.Forms.Button();
            this.Ex2 = new System.Windows.Forms.Panel();
            this.volume = new System.Windows.Forms.Label();
            this.calculation = new System.Windows.Forms.Button();
            this.footing = new System.Windows.Forms.TextBox();
            this.Text4 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.Text3 = new System.Windows.Forms.Label();
            this.square = new System.Windows.Forms.Label();
            this.Ex3 = new System.Windows.Forms.Panel();
            this.TextInputA = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.TextBox();
            this.TextInputB = new System.Windows.Forms.Label();
            this.InputB = new System.Windows.Forms.TextBox();
            this.TextInputC = new System.Windows.Forms.Label();
            this.InputC = new System.Windows.Forms.TextBox();
            this.calculate3 = new System.Windows.Forms.Button();
            this.TextMin = new System.Windows.Forms.Label();
            this.TextWane = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ex1.SuspendLayout();
            this.Ex2.SuspendLayout();
            this.Ex3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ex1
            // 
            this.Ex1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ex1.Controls.Add(this.TextB);
            this.Ex1.Controls.Add(this.TextA);
            this.Ex1.Controls.Add(this.TextInputX);
            this.Ex1.Location = new System.Drawing.Point(3, 4);
            this.Ex1.Name = "Ex1";
            this.Ex1.Size = new System.Drawing.Size(147, 169);
            this.Ex1.TabIndex = 7;
            // 
            // TextB
            // 
            this.TextB.AutoSize = true;
            this.TextB.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.TextB.Location = new System.Drawing.Point(12, 140);
            this.TextB.Name = "TextB";
            this.TextB.Size = new System.Drawing.Size(34, 18);
            this.TextB.TabIndex = 1;
            this.TextB.Text = "b = ";
            // 
            // TextA
            // 
            this.TextA.AutoSize = true;
            this.TextA.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.TextA.Location = new System.Drawing.Point(12, 122);
            this.TextA.Name = "TextA";
            this.TextA.Size = new System.Drawing.Size(33, 18);
            this.TextA.TabIndex = 0;
            this.TextA.Text = "a = ";
            // 
            // TextInputX
            // 
            this.TextInputX.AutoSize = true;
            this.TextInputX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextInputX.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInputX.Location = new System.Drawing.Point(7, 11);
            this.TextInputX.Name = "TextInputX";
            this.TextInputX.Size = new System.Drawing.Size(70, 16);
            this.TextInputX.TabIndex = 1;
            this.TextInputX.Text = "Введите X:";
            // 
            // InputX
            // 
            this.InputX.Location = new System.Drawing.Point(80, 13);
            this.InputX.Name = "InputX";
            this.InputX.Size = new System.Drawing.Size(62, 20);
            this.InputX.TabIndex = 0;
            // 
            // TextInputY
            // 
            this.TextInputY.AutoSize = true;
            this.TextInputY.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextInputY.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.TextInputY.Location = new System.Drawing.Point(10, 43);
            this.TextInputY.Name = "TextInputY";
            this.TextInputY.Size = new System.Drawing.Size(70, 16);
            this.TextInputY.TabIndex = 3;
            this.TextInputY.Text = "Введите Y:";
            // 
            // InputY
            // 
            this.InputY.Location = new System.Drawing.Point(80, 40);
            this.InputY.Name = "InputY";
            this.InputY.Size = new System.Drawing.Size(62, 20);
            this.InputY.TabIndex = 2;
            // 
            // TextInputZ
            // 
            this.TextInputZ.AutoSize = true;
            this.TextInputZ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextInputZ.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.TextInputZ.Location = new System.Drawing.Point(10, 70);
            this.TextInputZ.Name = "TextInputZ";
            this.TextInputZ.Size = new System.Drawing.Size(70, 16);
            this.TextInputZ.TabIndex = 5;
            this.TextInputZ.Text = "Введите Z:";
            // 
            // InputZ
            // 
            this.InputZ.Location = new System.Drawing.Point(80, 68);
            this.InputZ.Name = "InputZ";
            this.InputZ.Size = new System.Drawing.Size(62, 20);
            this.InputZ.TabIndex = 4;
            // 
            // CalculateAB
            // 
            this.CalculateAB.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.CalculateAB.Location = new System.Drawing.Point(13, 96);
            this.CalculateAB.Name = "CalculateAB";
            this.CalculateAB.Size = new System.Drawing.Size(129, 27);
            this.CalculateAB.TabIndex = 6;
            this.CalculateAB.Text = "Вычислить";
            this.CalculateAB.UseVisualStyleBackColor = true;
            this.CalculateAB.Click += new System.EventHandler(this.First_Click);
            // 
            // Ex2
            // 
            this.Ex2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ex2.Controls.Add(this.volume);
            this.Ex2.Controls.Add(this.calculation);
            this.Ex2.Controls.Add(this.footing);
            this.Ex2.Controls.Add(this.Text4);
            this.Ex2.Controls.Add(this.height);
            this.Ex2.Controls.Add(this.Text3);
            this.Ex2.Controls.Add(this.square);
            this.Ex2.Location = new System.Drawing.Point(156, 4);
            this.Ex2.Name = "Ex2";
            this.Ex2.Size = new System.Drawing.Size(192, 169);
            this.Ex2.TabIndex = 8;
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.volume.Location = new System.Drawing.Point(13, 140);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(31, 18);
            this.volume.TabIndex = 0;
            this.volume.Text = "V =";
            // 
            // calculation
            // 
            this.calculation.BackColor = System.Drawing.SystemColors.Control;
            this.calculation.Font = new System.Drawing.Font("Microsoft Tai Le", 8F);
            this.calculation.Location = new System.Drawing.Point(6, 92);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(179, 27);
            this.calculation.TabIndex = 9;
            this.calculation.Text = "Найти площадь и объем фигуры";
            this.calculation.UseVisualStyleBackColor = false;
            this.calculation.Click += new System.EventHandler(this.Second_Click);
            // 
            // footing
            // 
            this.footing.Location = new System.Drawing.Point(135, 56);
            this.footing.MaximumSize = new System.Drawing.Size(50, 40);
            this.footing.MinimumSize = new System.Drawing.Size(50, 35);
            this.footing.Name = "footing";
            this.footing.Size = new System.Drawing.Size(50, 20);
            this.footing.TabIndex = 11;
            // 
            // Text4
            // 
            this.Text4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.Text4.Location = new System.Drawing.Point(3, 53);
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(131, 40);
            this.Text4.TabIndex = 10;
            this.Text4.Text = "Введите длину основания:";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(135, 11);
            this.height.MaximumSize = new System.Drawing.Size(50, 40);
            this.height.MinimumSize = new System.Drawing.Size(50, 35);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(50, 20);
            this.height.TabIndex = 9;
            // 
            // Text3
            // 
            this.Text3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.Text3.Location = new System.Drawing.Point(3, 11);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(131, 40);
            this.Text3.TabIndex = 0;
            this.Text3.Text = "Введите высоту:";
            // 
            // square
            // 
            this.square.AutoSize = true;
            this.square.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.square.Location = new System.Drawing.Point(13, 122);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(29, 18);
            this.square.TabIndex = 1;
            this.square.Text = "S =";
            // 
            // Ex3
            // 
            this.Ex3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Ex3.Controls.Add(this.TextInputA);
            this.Ex3.Controls.Add(this.InputA);
            this.Ex3.Controls.Add(this.TextInputB);
            this.Ex3.Controls.Add(this.InputB);
            this.Ex3.Controls.Add(this.TextInputC);
            this.Ex3.Controls.Add(this.InputC);
            this.Ex3.Controls.Add(this.calculate3);
            this.Ex3.Controls.Add(this.TextMin);
            this.Ex3.Controls.Add(this.TextWane);
            this.Ex3.Location = new System.Drawing.Point(354, 4);
            this.Ex3.Name = "Ex3";
            this.Ex3.Size = new System.Drawing.Size(147, 169);
            this.Ex3.TabIndex = 9;
            // 
            // TextInputA
            // 
            this.TextInputA.AutoSize = true;
            this.TextInputA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextInputA.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInputA.Location = new System.Drawing.Point(7, 9);
            this.TextInputA.Name = "TextInputA";
            this.TextInputA.Size = new System.Drawing.Size(71, 16);
            this.TextInputA.TabIndex = 1;
            this.TextInputA.Text = "Введите A:";
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(80, 5);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(59, 20);
            this.InputA.TabIndex = 0;
            // 
            // TextInputB
            // 
            this.TextInputB.AutoSize = true;
            this.TextInputB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextInputB.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.TextInputB.Location = new System.Drawing.Point(8, 35);
            this.TextInputB.Name = "TextInputB";
            this.TextInputB.Size = new System.Drawing.Size(70, 16);
            this.TextInputB.TabIndex = 2;
            this.TextInputB.Text = "Введите B:";
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(80, 33);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(59, 20);
            this.InputB.TabIndex = 4;
            // 
            // TextInputC
            // 
            this.TextInputC.AutoSize = true;
            this.TextInputC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextInputC.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.TextInputC.Location = new System.Drawing.Point(7, 60);
            this.TextInputC.Name = "TextInputC";
            this.TextInputC.Size = new System.Drawing.Size(71, 16);
            this.TextInputC.TabIndex = 3;
            this.TextInputC.Text = "Введите С:";
            // 
            // InputC
            // 
            this.InputC.Location = new System.Drawing.Point(80, 59);
            this.InputC.Name = "InputC";
            this.InputC.Size = new System.Drawing.Size(59, 20);
            this.InputC.TabIndex = 5;
            // 
            // calculate3
            // 
            this.calculate3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.calculate3.Location = new System.Drawing.Point(10, 85);
            this.calculate3.Name = "calculate3";
            this.calculate3.Size = new System.Drawing.Size(129, 27);
            this.calculate3.TabIndex = 10;
            this.calculate3.Text = "Вычислить";
            this.calculate3.UseVisualStyleBackColor = true;
            this.calculate3.Click += new System.EventHandler(this.Third_Click);
            // 
            // TextMin
            // 
            this.TextMin.AutoSize = true;
            this.TextMin.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.TextMin.Location = new System.Drawing.Point(9, 115);
            this.TextMin.Name = "TextMin";
            this.TextMin.Size = new System.Drawing.Size(50, 18);
            this.TextMin.TabIndex = 2;
            this.TextMin.Text = "Min = ";
            // 
            // TextWane
            // 
            this.TextWane.AutoSize = true;
            this.TextWane.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.TextWane.Location = new System.Drawing.Point(9, 140);
            this.TextWane.Name = "TextWane";
            this.TextWane.Size = new System.Drawing.Size(61, 18);
            this.TextWane.TabIndex = 11;
            this.TextWane.Text = "Wane = ";
            // 
            // 
            // 
            // 
            // 
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(156, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 169);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 72);
            this.button1.TabIndex = 10;
            this.button1.Text = "Задание 1.4, 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(550, 381);
            this.Controls.Add(this.Ex3);
            this.Controls.Add(this.Ex2);
            this.Controls.Add(this.CalculateAB);
            this.Controls.Add(this.TextInputZ);
            this.Controls.Add(this.InputZ);
            this.Controls.Add(this.TextInputY);
            this.Controls.Add(this.InputY);
            this.Controls.Add(this.InputX);
            this.Controls.Add(this.Ex1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(566, 420);
            this.MinimumSize = new System.Drawing.Size(566, 420);
            this.Name = "Form1";
            this.Ex1.ResumeLayout(false);
            this.Ex1.PerformLayout();
            this.Ex2.ResumeLayout(false);
            this.Ex2.PerformLayout();
            this.Ex3.ResumeLayout(false);
            this.Ex3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Ex1;
        private System.Windows.Forms.TextBox InputX;
        private System.Windows.Forms.Label TextInputX;
        private System.Windows.Forms.Label TextInputY;
        private System.Windows.Forms.TextBox InputY;
        private System.Windows.Forms.Label TextInputZ;
        private System.Windows.Forms.TextBox InputZ;
        private System.Windows.Forms.Button CalculateAB;
        private System.Windows.Forms.Label TextB;
        private System.Windows.Forms.Label TextA;
        private System.Windows.Forms.Panel Ex2;
        private System.Windows.Forms.Label square;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Button calculation;
        private System.Windows.Forms.TextBox footing;
        private System.Windows.Forms.Label Text4;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label Text3;
        private System.Windows.Forms.Panel Ex3;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.Label TextInputA;
        private System.Windows.Forms.Label TextInputB;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.Label TextInputC;
        private System.Windows.Forms.TextBox InputC;
        private System.Windows.Forms.Button calculate3;
        private System.Windows.Forms.Label TextWane;
        private System.Windows.Forms.Label TextMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}