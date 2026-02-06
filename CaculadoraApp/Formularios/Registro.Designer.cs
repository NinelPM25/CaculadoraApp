namespace CaculadoraApp.Formularios
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabRegistro = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            butRegistrar = new Button();
            dTFecha = new DateTimePicker();
            label3 = new Label();
            textApellido = new TextBox();
            textNombre = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvPersona = new DataGridView();
            tabRegistro.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersona).BeginInit();
            SuspendLayout();
            // 
            // tabRegistro
            // 
            tabRegistro.Controls.Add(tabPage1);
            tabRegistro.Controls.Add(tabPage2);
            tabRegistro.Location = new Point(12, 12);
            tabRegistro.Name = "tabRegistro";
            tabRegistro.SelectedIndex = 0;
            tabRegistro.Size = new Size(742, 358);
            tabRegistro.TabIndex = 0;
            tabRegistro.SelectedIndexChanged += tabRegistro_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(butRegistrar);
            tabPage1.Controls.Add(dTFecha);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textApellido);
            tabPage1.Controls.Add(textNombre);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(734, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 124);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 7;
            label4.Text = "Apellido ";
            // 
            // butRegistrar
            // 
            butRegistrar.Location = new Point(461, 143);
            butRegistrar.Name = "butRegistrar";
            butRegistrar.Size = new Size(112, 34);
            butRegistrar.TabIndex = 6;
            butRegistrar.Text = "Resgistrar ";
            butRegistrar.UseVisualStyleBackColor = true;
            butRegistrar.Click += butRegistrar_Click;
            // 
            // dTFecha
            // 
            dTFecha.Location = new Point(376, 56);
            dTFecha.Name = "dTFecha";
            dTFecha.Size = new Size(300, 31);
            dTFecha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 18);
            label3.Name = "label3";
            label3.Size = new Size(179, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha de nacimiento ";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(22, 160);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(150, 31);
            textApellido.TabIndex = 3;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(22, 56);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(150, 31);
            textNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPersona);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(734, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPersona
            // 
            dgvPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersona.Location = new Point(153, 32);
            dgvPersona.Name = "dgvPersona";
            dgvPersona.RowHeadersWidth = 62;
            dgvPersona.Size = new Size(360, 225);
            dgvPersona.TabIndex = 0;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabRegistro);
            Name = "Registro";
            Text = "Form1";
            Load += Form1_Load;
            tabRegistro.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersona).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabRegistro;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dTFecha;
        private Label label3;
        private TextBox textApellido;
        private Label label2;
        private TextBox textNombre;
        private Label label1;
        private Button butRegistrar;
        private Label label4;
        private DataGridView dgvPersona;
    }
}