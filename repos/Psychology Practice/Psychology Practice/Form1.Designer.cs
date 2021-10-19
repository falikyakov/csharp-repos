namespace Psychology_Practice
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.telText = new System.Windows.Forms.TextBox();
            this.cellText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.curPsychText = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.TelLabel = new System.Windows.Forms.Label();
            this.CellLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CurPsychLabel = new System.Windows.Forms.Label();
            this.DoBText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.patientListLabel = new System.Windows.Forms.Label();
            this.patientListButton = new System.Windows.Forms.Button();
            this.specificPatientInfoLabel = new System.Windows.Forms.Label();
            this.specificPatientNameTextBox = new System.Windows.Forms.TextBox();
            this.specificPatientInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(133, 415);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(125, 29);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(158, 28);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(131, 20);
            this.firstNameText.TabIndex = 1;
            this.firstNameText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(158, 78);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(131, 20);
            this.lastNameText.TabIndex = 2;
            // 
            // telText
            // 
            this.telText.Location = new System.Drawing.Point(158, 169);
            this.telText.Name = "telText";
            this.telText.Size = new System.Drawing.Size(131, 20);
            this.telText.TabIndex = 3;
            // 
            // cellText
            // 
            this.cellText.Location = new System.Drawing.Point(158, 217);
            this.cellText.Name = "cellText";
            this.cellText.Size = new System.Drawing.Size(131, 20);
            this.cellText.TabIndex = 4;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(158, 265);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(131, 20);
            this.addressText.TabIndex = 5;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(158, 313);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(131, 20);
            this.emailText.TabIndex = 6;
            // 
            // curPsychText
            // 
            this.curPsychText.Location = new System.Drawing.Point(158, 368);
            this.curPsychText.Name = "curPsychText";
            this.curPsychText.Size = new System.Drawing.Size(131, 20);
            this.curPsychText.TabIndex = 7;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(59, 31);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(57, 13);
            this.firstName.TabIndex = 8;
            this.firstName.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(59, 81);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(58, 13);
            this.lastName.TabIndex = 9;
            this.lastName.Text = "Last Name";
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(58, 172);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(25, 13);
            this.TelLabel.TabIndex = 10;
            this.TelLabel.Text = "Tel.";
            // 
            // CellLabel
            // 
            this.CellLabel.AutoSize = true;
            this.CellLabel.Location = new System.Drawing.Point(59, 220);
            this.CellLabel.Name = "CellLabel";
            this.CellLabel.Size = new System.Drawing.Size(24, 13);
            this.CellLabel.TabIndex = 11;
            this.CellLabel.Text = "Cell";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(59, 268);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "Address";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(59, 316);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 13;
            this.EmailLabel.Text = "Email";
            // 
            // CurPsychLabel
            // 
            this.CurPsychLabel.AutoSize = true;
            this.CurPsychLabel.Location = new System.Drawing.Point(57, 371);
            this.CurPsychLabel.Name = "CurPsychLabel";
            this.CurPsychLabel.Size = new System.Drawing.Size(97, 13);
            this.CurPsychLabel.TabIndex = 14;
            this.CurPsychLabel.Text = "Current Psychiatrist";
            // 
            // DoBText
            // 
            this.DoBText.AutoSize = true;
            this.DoBText.Location = new System.Drawing.Point(59, 124);
            this.DoBText.Name = "DoBText";
            this.DoBText.Size = new System.Drawing.Size(68, 13);
            this.DoBText.TabIndex = 15;
            this.DoBText.Text = "Date Of Birth";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 16;
            // 
            // patientListLabel
            // 
            this.patientListLabel.AutoSize = true;
            this.patientListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientListLabel.Location = new System.Drawing.Point(355, 51);
            this.patientListLabel.Name = "patientListLabel";
            this.patientListLabel.Size = new System.Drawing.Size(210, 18);
            this.patientListLabel.TabIndex = 17;
            this.patientListLabel.Text = "To view all patient information: ";
            // 
            // patientListButton
            // 
            this.patientListButton.Location = new System.Drawing.Point(571, 50);
            this.patientListButton.Name = "patientListButton";
            this.patientListButton.Size = new System.Drawing.Size(118, 23);
            this.patientListButton.TabIndex = 18;
            this.patientListButton.Text = "Patient List";
            this.patientListButton.UseVisualStyleBackColor = true;
            this.patientListButton.Click += new System.EventHandler(this.PatientListButton_Click);
            // 
            // specificPatientInfoLabel
            // 
            this.specificPatientInfoLabel.AutoSize = true;
            this.specificPatientInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificPatientInfoLabel.Location = new System.Drawing.Point(355, 110);
            this.specificPatientInfoLabel.Name = "specificPatientInfoLabel";
            this.specificPatientInfoLabel.Size = new System.Drawing.Size(406, 18);
            this.specificPatientInfoLabel.TabIndex = 19;
            this.specificPatientInfoLabel.Text = "To view specific patient info, please enter patient\'s last name:";
            // 
            // specificPatientNameTextBox
            // 
            this.specificPatientNameTextBox.Location = new System.Drawing.Point(358, 134);
            this.specificPatientNameTextBox.Name = "specificPatientNameTextBox";
            this.specificPatientNameTextBox.Size = new System.Drawing.Size(207, 20);
            this.specificPatientNameTextBox.TabIndex = 20;
            // 
            // specificPatientInfoButton
            // 
            this.specificPatientInfoButton.Location = new System.Drawing.Point(614, 132);
            this.specificPatientInfoButton.Name = "specificPatientInfoButton";
            this.specificPatientInfoButton.Size = new System.Drawing.Size(113, 23);
            this.specificPatientInfoButton.TabIndex = 21;
            this.specificPatientInfoButton.Text = "ENTER";
            this.specificPatientInfoButton.UseVisualStyleBackColor = true;
            this.specificPatientInfoButton.Click += new System.EventHandler(this.SpecificPatientInfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.specificPatientInfoButton);
            this.Controls.Add(this.specificPatientNameTextBox);
            this.Controls.Add(this.specificPatientInfoLabel);
            this.Controls.Add(this.patientListButton);
            this.Controls.Add(this.patientListLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DoBText);
            this.Controls.Add(this.CurPsychLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.CellLabel);
            this.Controls.Add(this.TelLabel);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.curPsychText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.cellText);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.SubmitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox telText;
        private System.Windows.Forms.TextBox cellText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox curPsychText;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label CellLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CurPsychLabel;
        private System.Windows.Forms.Label DoBText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label patientListLabel;
        private System.Windows.Forms.Button patientListButton;
        private System.Windows.Forms.Label specificPatientInfoLabel;
        private System.Windows.Forms.TextBox specificPatientNameTextBox;
        private System.Windows.Forms.Button specificPatientInfoButton;
    }
}

