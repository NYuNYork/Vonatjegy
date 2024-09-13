namespace Vonatjegy
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
            label1 = new Label();
            label2 = new Label();
            lbkiiras = new Label();
            txkm = new TextBox();
            btszamol = new Button();
            btkilepes = new Button();
            groupBox1 = new GroupBox();
            rbkilencven = new RadioButton();
            rbotven = new RadioButton();
            rbteljes = new RadioButton();
            groupBox2 = new GroupBox();
            rbnem = new RadioButton();
            rbigen = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 70);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "menetjegy ára 1km 25ft";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 109);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 1;
            label2.Text = "adja meg a km-t egész számként";
            // 
            // lbkiiras
            // 
            lbkiiras.AutoSize = true;
            lbkiiras.ForeColor = Color.Red;
            lbkiiras.Location = new Point(33, 426);
            lbkiiras.Name = "lbkiiras";
            lbkiiras.Size = new Size(38, 15);
            lbkiiras.TabIndex = 2;
            lbkiiras.Text = "label3";
            // 
            // txkm
            // 
            txkm.Location = new Point(198, 106);
            txkm.Name = "txkm";
            txkm.Size = new Size(100, 23);
            txkm.TabIndex = 3;
            // 
            // btszamol
            // 
            btszamol.Location = new Point(368, 106);
            btszamol.Name = "btszamol";
            btszamol.Size = new Size(135, 44);
            btszamol.TabIndex = 4;
            btszamol.Text = "számol";
            btszamol.UseVisualStyleBackColor = true;
            btszamol.Click += btszamol_Click;
            // 
            // btkilepes
            // 
            btkilepes.Location = new Point(368, 184);
            btkilepes.Name = "btkilepes";
            btkilepes.Size = new Size(135, 44);
            btkilepes.TabIndex = 5;
            btkilepes.Text = "kilépés";
            btkilepes.UseVisualStyleBackColor = true;
            btkilepes.Click += btkilepes_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbkilencven);
            groupBox1.Controls.Add(rbotven);
            groupBox1.Controls.Add(rbteljes);
            groupBox1.Location = new Point(33, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 105);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "menetjegy típusa";
            // 
            // rbkilencven
            // 
            rbkilencven.AutoSize = true;
            rbkilencven.Location = new Point(6, 68);
            rbkilencven.Name = "rbkilencven";
            rbkilencven.Size = new Size(64, 19);
            rbkilencven.TabIndex = 2;
            rbkilencven.TabStop = true;
            rbkilencven.Text = "90%-os";
            rbkilencven.UseVisualStyleBackColor = true;
            rbkilencven.CheckedChanged += rbkilencven_CheckedChanged;
            // 
            // rbotven
            // 
            rbotven.AutoSize = true;
            rbotven.Location = new Point(6, 43);
            rbotven.Name = "rbotven";
            rbotven.Size = new Size(64, 19);
            rbotven.TabIndex = 1;
            rbotven.TabStop = true;
            rbotven.Text = "50%-os";
            rbotven.UseVisualStyleBackColor = true;
            rbotven.CheckedChanged += rbotven_CheckedChanged;
            // 
            // rbteljes
            // 
            rbteljes.AutoSize = true;
            rbteljes.Location = new Point(6, 18);
            rbteljes.Name = "rbteljes";
            rbteljes.Size = new Size(72, 19);
            rbteljes.TabIndex = 0;
            rbteljes.TabStop = true;
            rbteljes.Text = "teljes árú";
            rbteljes.UseVisualStyleBackColor = true;
            rbteljes.CheckedChanged += rbteljes_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbnem);
            groupBox2.Controls.Add(rbigen);
            groupBox2.Location = new Point(33, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 105);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "kiegészítő jegy";
            // 
            // rbnem
            // 
            rbnem.AutoSize = true;
            rbnem.Location = new Point(6, 22);
            rbnem.Name = "rbnem";
            rbnem.Size = new Size(49, 19);
            rbnem.TabIndex = 1;
            rbnem.TabStop = true;
            rbnem.Text = "nem";
            rbnem.UseVisualStyleBackColor = true;
            rbnem.CheckedChanged += rbnem_CheckedChanged;
            // 
            // rbigen
            // 
            rbigen.AutoSize = true;
            rbigen.Location = new Point(6, 45);
            rbigen.Name = "rbigen";
            rbigen.Size = new Size(48, 19);
            rbigen.TabIndex = 0;
            rbigen.TabStop = true;
            rbigen.Text = "igen";
            rbigen.UseVisualStyleBackColor = true;
            rbigen.CheckedChanged += rbigen_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btkilepes);
            Controls.Add(btszamol);
            Controls.Add(txkm);
            Controls.Add(lbkiiras);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbkiiras;
        private TextBox txkm;
        private Button btszamol;
        private Button btkilepes;
        private GroupBox groupBox1;
        private RadioButton rbkilencven;
        private RadioButton rbotven;
        private RadioButton rbteljes;
        private GroupBox groupBox2;
        private RadioButton rbnem;
        private RadioButton rbigen;
    }
}
