namespace Practica1._2
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
            buttonAgregarP = new Button();
            buttonEliminarP = new Button();
            listBoxDisponibles = new ListBox();
            listBoxRetirados = new ListBox();
            textBoxId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonAgregarP
            // 
            buttonAgregarP.Location = new Point(59, 53);
            buttonAgregarP.Name = "buttonAgregarP";
            buttonAgregarP.Size = new Size(199, 53);
            buttonAgregarP.TabIndex = 0;
            buttonAgregarP.Text = "Agregar Producto";
            buttonAgregarP.UseVisualStyleBackColor = true;
            buttonAgregarP.Click += buttonAgregarP_Click;
            // 
            // buttonEliminarP
            // 
            buttonEliminarP.Location = new Point(304, 53);
            buttonEliminarP.Name = "buttonEliminarP";
            buttonEliminarP.Size = new Size(192, 53);
            buttonEliminarP.TabIndex = 1;
            buttonEliminarP.Text = "Retirar Producto";
            buttonEliminarP.UseVisualStyleBackColor = true;
            buttonEliminarP.Click += buttonEliminarP_Click;
            // 
            // listBoxDisponibles
            // 
            listBoxDisponibles.FormattingEnabled = true;
            listBoxDisponibles.ItemHeight = 20;
            listBoxDisponibles.Location = new Point(59, 185);
            listBoxDisponibles.Name = "listBoxDisponibles";
            listBoxDisponibles.Size = new Size(323, 204);
            listBoxDisponibles.TabIndex = 3;
            // 
            // listBoxRetirados
            // 
            listBoxRetirados.FormattingEnabled = true;
            listBoxRetirados.ItemHeight = 20;
            listBoxRetirados.Location = new Point(399, 185);
            listBoxRetirados.Name = "listBoxRetirados";
            listBoxRetirados.Size = new Size(331, 204);
            listBoxRetirados.TabIndex = 4;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(304, 132);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(91, 27);
            textBoxId.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 162);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 6;
            label1.Text = "Productos Disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 162);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 7;
            label2.Text = "Productos Retirados";
            // 
            // button1
            // 
            button1.Location = new Point(543, 53);
            button1.Name = "button1";
            button1.Size = new Size(187, 53);
            button1.TabIndex = 8;
            button1.Text = "Quitar todo el producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(413, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(605, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 109);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(413, 109);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 12;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(605, 109);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 13;
            label5.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(listBoxRetirados);
            Controls.Add(listBoxDisponibles);
            Controls.Add(buttonEliminarP);
            Controls.Add(buttonAgregarP);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregarP;
        private Button buttonEliminarP;
        private ListBox listBoxDisponibles;
        private ListBox listBoxRetirados;
        private TextBox textBoxId;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}