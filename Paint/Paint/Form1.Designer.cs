
namespace Paint
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
            this.btn_line = new System.Windows.Forms.Button();
            this.pnl_drawing = new System.Windows.Forms.Panel();
            this.btn_rectangle = new System.Windows.Forms.Button();
            this.rbtn_Line = new System.Windows.Forms.RadioButton();
            this.rbtn_rectangle = new System.Windows.Forms.RadioButton();
            this.rbtn_elipse = new System.Windows.Forms.RadioButton();
            this.rbtn_house = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_line
            // 
            this.btn_line.Font = new System.Drawing.Font("Sitka Banner", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_line.Location = new System.Drawing.Point(673, 20);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(110, 30);
            this.btn_line.TabIndex = 0;
            this.btn_line.Text = "Line";
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // pnl_drawing
            // 
            this.pnl_drawing.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnl_drawing.Location = new System.Drawing.Point(12, 12);
            this.pnl_drawing.Name = "pnl_drawing";
            this.pnl_drawing.Size = new System.Drawing.Size(622, 414);
            this.pnl_drawing.TabIndex = 1;
            // 
            // btn_rectangle
            // 
            this.btn_rectangle.Location = new System.Drawing.Point(676, 56);
            this.btn_rectangle.Name = "btn_rectangle";
            this.btn_rectangle.Size = new System.Drawing.Size(106, 27);
            this.btn_rectangle.TabIndex = 2;
            this.btn_rectangle.Text = "Rectangle";
            this.btn_rectangle.UseVisualStyleBackColor = true;
            this.btn_rectangle.Click += new System.EventHandler(this.btn_rectangle_Click);
            // 
            // rbtn_Line
            // 
            this.rbtn_Line.AutoSize = true;
            this.rbtn_Line.Location = new System.Drawing.Point(676, 155);
            this.rbtn_Line.Name = "rbtn_Line";
            this.rbtn_Line.Size = new System.Drawing.Size(57, 24);
            this.rbtn_Line.TabIndex = 3;
            this.rbtn_Line.TabStop = true;
            this.rbtn_Line.Text = "Line";
            this.rbtn_Line.UseVisualStyleBackColor = true;

            // 
            // rbtn_rectangle
            // 
            this.rbtn_rectangle.AutoSize = true;
            this.rbtn_rectangle.Location = new System.Drawing.Point(673, 198);
            this.rbtn_rectangle.Name = "rbtn_rectangle";
            this.rbtn_rectangle.Size = new System.Drawing.Size(96, 24);
            this.rbtn_rectangle.TabIndex = 4;
            this.rbtn_rectangle.TabStop = true;
            this.rbtn_rectangle.Text = "Rectangle";
            this.rbtn_rectangle.UseVisualStyleBackColor = true;
            this.rbtn_rectangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtn_rectangle_MouseDown);
            this.rbtn_rectangle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rbtn_rectangle_MouseUp);
            // 
            // rbtn_elipse
            // 
            this.rbtn_elipse.AutoSize = true;
            this.rbtn_elipse.Location = new System.Drawing.Point(673, 244);
            this.rbtn_elipse.Name = "rbtn_elipse";
            this.rbtn_elipse.Size = new System.Drawing.Size(69, 24);
            this.rbtn_elipse.TabIndex = 5;
            this.rbtn_elipse.TabStop = true;
            this.rbtn_elipse.Text = "Elipse";
            this.rbtn_elipse.UseVisualStyleBackColor = true;
            // 
            // rbtn_house
            // 
            this.rbtn_house.AutoSize = true;
            this.rbtn_house.Location = new System.Drawing.Point(673, 289);
            this.rbtn_house.Name = "rbtn_house";
            this.rbtn_house.Size = new System.Drawing.Size(72, 24);
            this.rbtn_house.TabIndex = 6;
            this.rbtn_house.TabStop = true;
            this.rbtn_house.Text = "House";
            this.rbtn_house.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtn_house);
            this.Controls.Add(this.rbtn_elipse);
            this.Controls.Add(this.rbtn_rectangle);
            this.Controls.Add(this.rbtn_Line);
            this.Controls.Add(this.btn_rectangle);
            this.Controls.Add(this.pnl_drawing);
            this.Controls.Add(this.btn_line);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Panel pnl_drawing;
        private System.Windows.Forms.Button btn_rectangle;
        private System.Windows.Forms.RadioButton rbtn_Line;
        private System.Windows.Forms.RadioButton rbtn_rectangle;
        private System.Windows.Forms.RadioButton rbtn_elipse;
        private System.Windows.Forms.RadioButton rbtn_house;
    }
}

