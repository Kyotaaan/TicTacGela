namespace Tic_Tac_Toe_Magbanua
{
    public partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            b7 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            b4 = new Button();
            b8 = new Button();
            b9 = new Button();
            b5 = new Button();
            b6 = new Button();
            label1 = new Label();
            label2 = new Label();
            button10 = new Button();
            button11 = new Button();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.the_little_mermaid_wallpapers_30062_602784;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.Controls.Add(b7, 0, 2);
            tableLayoutPanel1.Controls.Add(b3, 2, 0);
            tableLayoutPanel1.Controls.Add(b2, 1, 0);
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b8, 1, 2);
            tableLayoutPanel1.Controls.Add(b9, 2, 2);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Location = new Point(36, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel1.Size = new Size(409, 436);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // b7
            // 
            b7.BackColor = Color.LightBlue;
            b7.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b7.ForeColor = Color.Gold;
            b7.Location = new Point(3, 293);
            b7.Name = "b7";
            b7.Size = new Size(130, 140);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.LightBlue;
            b3.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b3.ForeColor = Color.Gold;
            b3.Location = new Point(275, 3);
            b3.Name = "b3";
            b3.Size = new Size(131, 139);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.LightBlue;
            b2.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b2.ForeColor = Color.Gold;
            b2.Location = new Point(139, 3);
            b2.Name = "b2";
            b2.Size = new Size(130, 139);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // b1
            // 
            b1.BackColor = Color.LightBlue;
            b1.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b1.ForeColor = Color.Gold;
            b1.Location = new Point(3, 3);
            b1.Name = "b1";
            b1.Size = new Size(130, 139);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.LightBlue;
            b4.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b4.ForeColor = Color.Gold;
            b4.Location = new Point(3, 148);
            b4.Name = "b4";
            b4.Size = new Size(130, 139);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = false;
            b4.Click += b4_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.LightBlue;
            b8.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b8.ForeColor = Color.Gold;
            b8.Location = new Point(139, 293);
            b8.Name = "b8";
            b8.Size = new Size(130, 140);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = false;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.LightBlue;
            b9.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b9.ForeColor = Color.Gold;
            b9.Location = new Point(275, 293);
            b9.Name = "b9";
            b9.Size = new Size(131, 140);
            b9.TabIndex = 7;
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.LightBlue;
            b5.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b5.ForeColor = Color.Gold;
            b5.Location = new Point(139, 148);
            b5.Name = "b5";
            b5.Size = new Size(130, 139);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.LightBlue;
            b6.Font = new Font("Segoe Print", 48F, FontStyle.Bold);
            b6.ForeColor = Color.Gold;
            b6.Location = new Point(275, 148);
            b6.Name = "b6";
            b6.Size = new Size(131, 139);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label1.Location = new Point(500, 98);
            label1.Name = "label1";
            label1.Size = new Size(131, 28);
            label1.TabIndex = 1;
            label1.Text = "PLAYER 1 = X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            label2.Location = new Point(500, 139);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 2;
            label2.Text = "PLAYER 2 = O";
            // 
            // button10
            // 
            button10.BackColor = Color.Transparent;
            button10.BackgroundImage = Properties.Resources.the_little_mermaid_wallpapers_30062_602784;
            button10.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(470, 442);
            button10.Name = "button10";
            button10.Size = new Size(123, 53);
            button10.TabIndex = 3;
            button10.Text = "NEW GAME";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackgroundImage = Properties.Resources.the_little_mermaid_wallpapers_30062_602784;
            button11.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(620, 442);
            button11.Name = "button11";
            button11.Size = new Size(119, 53);
            button11.TabIndex = 4;
            button11.Text = "EXIT";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft YaHei", 25.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 8);
            label3.Name = "label3";
            label3.Size = new Size(239, 46);
            label3.TabIndex = 5;
            label3.Text = "TIC-TAC-TOE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(535, 295);
            label4.Name = "label4";
            label4.Size = new Size(0, 37);
            label4.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.the_little_mermaid_wallpapers_30062_602784;
            ClientSize = new Size(750, 582);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

