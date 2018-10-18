namespace Draw_Patterns_WinForm
{
    partial class Form1
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
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linestxt = new System.Windows.Forms.TextBox();
            this.angletxt = new System.Windows.Forms.TextBox();
            this.lengthtxt = new System.Windows.Forms.TextBox();
            this.incrementtxt = new System.Windows.Forms.TextBox();
            this.Drawbtn = new System.Windows.Forms.Button();
            this.CommandPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.CanvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CanvasPanel.Location = new System.Drawing.Point(0, 0);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(800, 450);
            this.CanvasPanel.TabIndex = 0;
            this.CanvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPanel_Paint);
            // 
            // CommandPanel
            // 
            this.CommandPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CommandPanel.Controls.Add(this.Drawbtn);
            this.CommandPanel.Controls.Add(this.incrementtxt);
            this.CommandPanel.Controls.Add(this.lengthtxt);
            this.CommandPanel.Controls.Add(this.angletxt);
            this.CommandPanel.Controls.Add(this.linestxt);
            this.CommandPanel.Controls.Add(this.label3);
            this.CommandPanel.Controls.Add(this.label4);
            this.CommandPanel.Controls.Add(this.label2);
            this.CommandPanel.Controls.Add(this.label1);
            this.CommandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CommandPanel.Location = new System.Drawing.Point(0, 0);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(800, 24);
            this.CommandPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Increment";
            // 
            // linestxt
            // 
            this.linestxt.Location = new System.Drawing.Point(118, 1);
            this.linestxt.Name = "linestxt";
            this.linestxt.Size = new System.Drawing.Size(75, 20);
            this.linestxt.TabIndex = 3;
            this.linestxt.Text = "25";
            this.linestxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // angletxt
            // 
            this.angletxt.Location = new System.Drawing.Point(264, 3);
            this.angletxt.Name = "angletxt";
            this.angletxt.Size = new System.Drawing.Size(75, 20);
            this.angletxt.TabIndex = 4;
            this.angletxt.Text = "100";
            this.angletxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lengthtxt
            // 
            this.lengthtxt.Location = new System.Drawing.Point(416, 2);
            this.lengthtxt.Name = "lengthtxt";
            this.lengthtxt.Size = new System.Drawing.Size(75, 20);
            this.lengthtxt.TabIndex = 4;
            this.lengthtxt.Text = "50";
            this.lengthtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // incrementtxt
            // 
            this.incrementtxt.Location = new System.Drawing.Point(593, 2);
            this.incrementtxt.Name = "incrementtxt";
            this.incrementtxt.Size = new System.Drawing.Size(75, 20);
            this.incrementtxt.TabIndex = 4;
            this.incrementtxt.Text = "1";
            this.incrementtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Drawbtn
            // 
            this.Drawbtn.Location = new System.Drawing.Point(686, 2);
            this.Drawbtn.Name = "Drawbtn";
            this.Drawbtn.Size = new System.Drawing.Size(75, 23);
            this.Drawbtn.TabIndex = 5;
            this.Drawbtn.Text = "Draw";
            this.Drawbtn.UseVisualStyleBackColor = true;
            this.Drawbtn.Click += new System.EventHandler(this.Drawbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommandPanel);
            this.Controls.Add(this.CanvasPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.CommandPanel.ResumeLayout(false);
            this.CommandPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Panel CommandPanel;
        private System.Windows.Forms.Button Drawbtn;
        private System.Windows.Forms.TextBox incrementtxt;
        private System.Windows.Forms.TextBox lengthtxt;
        private System.Windows.Forms.TextBox angletxt;
        private System.Windows.Forms.TextBox linestxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

