namespace LogiSwitch
{
    partial class TestBed
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
            btnM1 = new Button();
            btnM2 = new Button();
            btnM3 = new Button();
            btnK1 = new Button();
            btnK2 = new Button();
            btnK3 = new Button();
            SuspendLayout();
            // 
            // btnM1
            // 
            btnM1.Location = new Point(28, 22);
            btnM1.Name = "btnM1";
            btnM1.Size = new Size(75, 23);
            btnM1.TabIndex = 0;
            btnM1.Text = "Mouse1";
            btnM1.UseVisualStyleBackColor = true;
            btnM1.Click += ButtonPush;
            // 
            // btnM2
            // 
            btnM2.Location = new Point(132, 22);
            btnM2.Name = "btnM2";
            btnM2.Size = new Size(75, 23);
            btnM2.TabIndex = 0;
            btnM2.Text = "Mouse 2";
            btnM2.UseVisualStyleBackColor = true;
            btnM2.Click += ButtonPush;
            // 
            // btnM3
            // 
            btnM3.Location = new Point(236, 22);
            btnM3.Name = "btnM3";
            btnM3.Size = new Size(75, 23);
            btnM3.TabIndex = 0;
            btnM3.Text = "Mouse 3";
            btnM3.UseVisualStyleBackColor = true;
            btnM3.Click += ButtonPush;
            // 
            // btnK1
            // 
            btnK1.Location = new Point(28, 73);
            btnK1.Name = "btnK1";
            btnK1.Size = new Size(75, 23);
            btnK1.TabIndex = 0;
            btnK1.Text = "Keyboard1";
            btnK1.UseVisualStyleBackColor = true;
            btnK1.Click += ButtonPush;
            // 
            // btnK2
            // 
            btnK2.Location = new Point(132, 73);
            btnK2.Name = "btnK2";
            btnK2.Size = new Size(75, 23);
            btnK2.TabIndex = 0;
            btnK2.Text = "Keyboard2";
            btnK2.UseVisualStyleBackColor = true;
            btnK2.Click += ButtonPush;
            // 
            // btnK3
            // 
            btnK3.Location = new Point(236, 73);
            btnK3.Name = "btnK3";
            btnK3.Size = new Size(75, 23);
            btnK3.TabIndex = 0;
            btnK3.Text = "Keyboard3";
            btnK3.UseVisualStyleBackColor = true;
            btnK3.Click += ButtonPush;
            // 
            // TestBed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 123);
            Controls.Add(btnK3);
            Controls.Add(btnK2);
            Controls.Add(btnM3);
            Controls.Add(btnK1);
            Controls.Add(btnM2);
            Controls.Add(btnM1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TestBed";
            Text = "TestBed";
            Load += TestBed_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnM1;
        private Button btnM2;
        private Button btnM3;
        private Button btnK1;
        private Button btnK2;
        private Button btnK3;
    }
}