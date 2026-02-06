namespace CaculadoraApp
{
    partial class CalculadoraApp
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
            labVariableA = new Label();
            textVariableA = new TextBox();
            labVariableB = new Label();
            textVariableB = new TextBox();
            botonCalcular = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labVariableA
            // 
            labVariableA.AutoSize = true;
            labVariableA.Location = new Point(45, 34);
            labVariableA.Name = "labVariableA";
            labVariableA.Size = new Size(96, 25);
            labVariableA.TabIndex = 0;
            labVariableA.Text = "Variable A ";
            // 
            // textVariableA
            // 
            textVariableA.Location = new Point(45, 71);
            textVariableA.Name = "textVariableA";
            textVariableA.Size = new Size(150, 31);
            textVariableA.TabIndex = 1;
            // 
            // labVariableB
            // 
            labVariableB.AutoSize = true;
            labVariableB.Location = new Point(45, 140);
            labVariableB.Name = "labVariableB";
            labVariableB.Size = new Size(94, 25);
            labVariableB.TabIndex = 2;
            labVariableB.Text = "Variable B ";
            // 
            // textVariableB
            // 
            textVariableB.Location = new Point(45, 183);
            textVariableB.Name = "textVariableB";
            textVariableB.Size = new Size(150, 31);
            textVariableB.TabIndex = 3;
            // 
            // botonCalcular
            // 
            botonCalcular.Location = new Point(649, 71);
            botonCalcular.Name = "botonCalcular";
            botonCalcular.Size = new Size(112, 34);
            botonCalcular.TabIndex = 4;
            botonCalcular.Text = " Calcular ";
            botonCalcular.UseVisualStyleBackColor = true;
            botonCalcular.Click += botonCalcular_Click;
            // 
            // button1
            // 
            button1.Location = new Point(649, 135);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Restablecer";
            button1.UseVisualStyleBackColor = true;
            // 
            // CalculadoraApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(botonCalcular);
            Controls.Add(textVariableB);
            Controls.Add(labVariableB);
            Controls.Add(textVariableA);
            Controls.Add(labVariableA);
            Name = "CalculadoraApp";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labVariableA;
        private TextBox textVariableA;
        private Label labVariableB;
        private TextBox textVariableB;
        private Button botonCalcular;
        private Button button1;
    }
}
