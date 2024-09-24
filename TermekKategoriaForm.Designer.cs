namespace elsogyak
{
    partial class TermekKategoriaForm
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
            treeViewkategoria = new TreeView();
            textBoxKategoriaNev = new TextBox();
            textBoxleiras = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // treeViewkategoria
            // 
            treeViewkategoria.Location = new Point(31, 31);
            treeViewkategoria.Name = "treeViewkategoria";
            treeViewkategoria.Size = new Size(359, 390);
            treeViewkategoria.TabIndex = 0;
            // 
            // textBoxKategoriaNev
            // 
            textBoxKategoriaNev.Location = new Point(499, 31);
            textBoxKategoriaNev.Name = "textBoxKategoriaNev";
            textBoxKategoriaNev.Size = new Size(304, 23);
            textBoxKategoriaNev.TabIndex = 1;
            // 
            // textBoxleiras
            // 
            textBoxleiras.Location = new Point(499, 126);
            textBoxleiras.Multiline = true;
            textBoxleiras.Name = "textBoxleiras";
            textBoxleiras.Size = new Size(304, 195);
            textBoxleiras.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(409, 353);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 3;
            button1.Text = "Új testvér kat.";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(520, 353);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 4;
            button2.Text = "Új gyermek kat.";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(649, 353);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Mentés";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(752, 353);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Törlés";
            button4.UseVisualStyleBackColor = true;
            // 
            // TermekKategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 524);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxleiras);
            Controls.Add(textBoxKategoriaNev);
            Controls.Add(treeViewkategoria);
            Name = "TermekKategoriaForm";
            Text = "TermekKategoriaForm";
            Load += TermekKategoriaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewkategoria;
        private TextBox textBoxKategoriaNev;
        private TextBox textBoxleiras;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}