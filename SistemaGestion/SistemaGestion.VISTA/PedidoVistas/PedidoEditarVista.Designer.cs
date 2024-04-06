namespace SistemaGestion.VISTA.PedidoVistas
{
    partial class PedidoEditarVista
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 181);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 37;
            label3.Text = "TOTAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 139);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 36;
            label2.Text = "FECHA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 95);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 35;
            label1.Text = "IDCLIENTE";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 215);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 27);
            textBox3.TabIndex = 40;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 85);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 27);
            textBox1.TabIndex = 38;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(263, 260);
            button2.Name = "button2";
            button2.Size = new Size(130, 45);
            button2.TabIndex = 43;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(91, 260);
            button1.Name = "button1";
            button1.Size = new Size(130, 45);
            button1.TabIndex = 42;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Wide Latin", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(179, 12);
            label6.Name = "label6";
            label6.Size = new Size(226, 33);
            label6.TabIndex = 44;
            label6.Text = "EDITAR";
            // 
            // button3
            // 
            button3.Location = new Point(413, 87);
            button3.Name = "button3";
            button3.Size = new Size(126, 29);
            button3.TabIndex = 45;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(101, 129);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 27);
            dateTimePicker1.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 224);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 59;
            label4.Text = "ESTADO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 172);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 27);
            textBox2.TabIndex = 58;
            // 
            // PedidoEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(590, 320);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PedidoEditarVista";
            Text = "PedidoEditarVista";
            Load += PedidoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label6;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox2;
    }
}