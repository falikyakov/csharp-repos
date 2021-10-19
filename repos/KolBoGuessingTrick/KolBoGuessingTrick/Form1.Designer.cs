namespace KolBoGuessingTrick
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
            this.label1 = new System.Windows.Forms.Label();
            this.modular7label = new System.Windows.Forms.Label();
            this.modular5label = new System.Windows.Forms.Label();
            this.modular3label = new System.Windows.Forms.Label();
            this.modular5box = new System.Windows.Forms.TextBox();
            this.modular7box = new System.Windows.Forms.TextBox();
            this.modular3box = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a Number between 7 and 104";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // modular7label
            // 
            this.modular7label.AutoSize = true;
            this.modular7label.Location = new System.Drawing.Point(97, 66);
            this.modular7label.Name = "modular7label";
            this.modular7label.Size = new System.Drawing.Size(111, 13);
            this.modular7label.TabIndex = 1;
            this.modular7label.Text = "Enter the modular of 7";
            // 
            // modular5label
            // 
            this.modular5label.AutoSize = true;
            this.modular5label.Location = new System.Drawing.Point(-1, 148);
            this.modular5label.Name = "modular5label";
            this.modular5label.Size = new System.Drawing.Size(324, 13);
            this.modular5label.TabIndex = 2;
            this.modular5label.Text = "Now divide your original number by 5 and enter the modular number";
            // 
            // modular3label
            // 
            this.modular3label.AutoSize = true;
            this.modular3label.Location = new System.Drawing.Point(84, 224);
            this.modular3label.Name = "modular3label";
            this.modular3label.Size = new System.Drawing.Size(135, 13);
            this.modular3label.TabIndex = 3;
            this.modular3label.Text = "Now enter the modular of 3";
            // 
            // modular5box
            // 
            this.modular5box.Location = new System.Drawing.Point(100, 182);
            this.modular5box.Name = "modular5box";
            this.modular5box.Size = new System.Drawing.Size(100, 20);
            this.modular5box.TabIndex = 5;
            // 
            // modular7box
            // 
            this.modular7box.Location = new System.Drawing.Point(100, 106);
            this.modular7box.Name = "modular7box";
            this.modular7box.Size = new System.Drawing.Size(100, 20);
            this.modular7box.TabIndex = 6;
            // 
            // modular3box
            // 
            this.modular3box.Location = new System.Drawing.Point(100, 260);
            this.modular3box.Name = "modular3box";
            this.modular3box.Size = new System.Drawing.Size(100, 20);
            this.modular3box.TabIndex = 7;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(115, 309);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 8;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(319, 375);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.modular3box);
            this.Controls.Add(this.modular7box);
            this.Controls.Add(this.modular5box);
            this.Controls.Add(this.modular3label);
            this.Controls.Add(this.modular5label);
            this.Controls.Add(this.modular7label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modular7label;
        private System.Windows.Forms.Label modular5label;
        private System.Windows.Forms.Label modular3label;
        private System.Windows.Forms.TextBox modular5box;
        private System.Windows.Forms.TextBox modular7box;
        private System.Windows.Forms.TextBox modular3box;
        private System.Windows.Forms.Button enterButton;
    }
}

