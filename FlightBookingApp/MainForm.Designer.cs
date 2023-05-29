
namespace FlightBookingApp
{
    partial class MainForm
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
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseDatesMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idCardRadioButton = new System.Windows.Forms.RadioButton();
            this.passportRadioButton = new System.Windows.Forms.RadioButton();
            this.travelDocNumberLabel = new System.Windows.Forms.Label();
            this.docNumberTextBox = new System.Windows.Forms.TextBox();
            this.docIssueDateLabel = new System.Windows.Forms.Label();
            this.issueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.docExpiryDateLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.baggageWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baggageWeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "To";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(179, 26);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(220, 38);
            this.toTextBox.TabIndex = 1;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(563, 26);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(222, 38);
            this.fromTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose your dates";
            // 
            // chooseDatesMonthCalendar
            // 
            this.chooseDatesMonthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.chooseDatesMonthCalendar.Location = new System.Drawing.Point(136, 116);
            this.chooseDatesMonthCalendar.MaxDate = new System.DateTime(2923, 12, 31, 0, 0, 0, 0);
            this.chooseDatesMonthCalendar.MaxSelectionCount = 100;
            this.chooseDatesMonthCalendar.MinDate = new System.DateTime(2023, 5, 26, 0, 0, 0, 0);
            this.chooseDatesMonthCalendar.Name = "chooseDatesMonthCalendar";
            this.chooseDatesMonthCalendar.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(770, 341);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(222, 38);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(322, 341);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(220, 38);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 403);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Travel Document:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idCardRadioButton);
            this.groupBox1.Controls.Add(this.passportRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(409, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 48);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // idCardRadioButton
            // 
            this.idCardRadioButton.AutoSize = true;
            this.idCardRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCardRadioButton.Location = new System.Drawing.Point(143, 16);
            this.idCardRadioButton.Name = "idCardRadioButton";
            this.idCardRadioButton.Size = new System.Drawing.Size(142, 21);
            this.idCardRadioButton.TabIndex = 1;
            this.idCardRadioButton.TabStop = true;
            this.idCardRadioButton.Text = "Identification Card";
            this.idCardRadioButton.UseVisualStyleBackColor = true;
            this.idCardRadioButton.CheckedChanged += new System.EventHandler(this.passportRadioButton_CheckedChanged);
            // 
            // passportRadioButton
            // 
            this.passportRadioButton.AutoSize = true;
            this.passportRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passportRadioButton.Location = new System.Drawing.Point(6, 16);
            this.passportRadioButton.Name = "passportRadioButton";
            this.passportRadioButton.Size = new System.Drawing.Size(85, 21);
            this.passportRadioButton.TabIndex = 0;
            this.passportRadioButton.Text = "Passport";
            this.passportRadioButton.UseVisualStyleBackColor = true;
            this.passportRadioButton.CheckedChanged += new System.EventHandler(this.passportRadioButton_CheckedChanged);
            // 
            // travelDocNumberLabel
            // 
            this.travelDocNumberLabel.AutoSize = true;
            this.travelDocNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelDocNumberLabel.Location = new System.Drawing.Point(721, 397);
            this.travelDocNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.travelDocNumberLabel.Name = "travelDocNumberLabel";
            this.travelDocNumberLabel.Size = new System.Drawing.Size(216, 32);
            this.travelDocNumberLabel.TabIndex = 12;
            this.travelDocNumberLabel.Text = "Document No.:";
            // 
            // docNumberTextBox
            // 
            this.docNumberTextBox.Location = new System.Drawing.Point(935, 394);
            this.docNumberTextBox.Name = "docNumberTextBox";
            this.docNumberTextBox.Size = new System.Drawing.Size(222, 38);
            this.docNumberTextBox.TabIndex = 13;
            // 
            // docIssueDateLabel
            // 
            this.docIssueDateLabel.AutoSize = true;
            this.docIssueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docIssueDateLabel.Location = new System.Drawing.Point(148, 460);
            this.docIssueDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.docIssueDateLabel.Name = "docIssueDateLabel";
            this.docIssueDateLabel.Size = new System.Drawing.Size(313, 32);
            this.docIssueDateLabel.TabIndex = 14;
            this.docIssueDateLabel.Text = "Document Issue Date:";
            // 
            // issueDateTimePicker
            // 
            this.issueDateTimePicker.Location = new System.Drawing.Point(461, 454);
            this.issueDateTimePicker.Name = "issueDateTimePicker";
            this.issueDateTimePicker.Size = new System.Drawing.Size(446, 38);
            this.issueDateTimePicker.TabIndex = 15;
            this.issueDateTimePicker.ValueChanged += new System.EventHandler(this.issueDateTimePicker_ValueChanged);
            // 
            // expiryDateTimePicker
            // 
            this.expiryDateTimePicker.Location = new System.Drawing.Point(472, 501);
            this.expiryDateTimePicker.Name = "expiryDateTimePicker";
            this.expiryDateTimePicker.Size = new System.Drawing.Size(446, 38);
            this.expiryDateTimePicker.TabIndex = 17;
            // 
            // docExpiryDateLabel
            // 
            this.docExpiryDateLabel.AutoSize = true;
            this.docExpiryDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docExpiryDateLabel.Location = new System.Drawing.Point(148, 507);
            this.docExpiryDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.docExpiryDateLabel.Name = "docExpiryDateLabel";
            this.docExpiryDateLabel.Size = new System.Drawing.Size(326, 32);
            this.docExpiryDateLabel.TabIndex = 16;
            this.docExpiryDateLabel.Text = "Document Expiry Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 584);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(441, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Baggage (provide an estimate):";
            // 
            // baggageWeightNumericUpDown
            // 
            this.baggageWeightNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.baggageWeightNumericUpDown.Location = new System.Drawing.Point(592, 582);
            this.baggageWeightNumericUpDown.Name = "baggageWeightNumericUpDown";
            this.baggageWeightNumericUpDown.Size = new System.Drawing.Size(120, 38);
            this.baggageWeightNumericUpDown.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(721, 584);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "kgs";
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.Aquamarine;
            this.bookButton.Location = new System.Drawing.Point(12, 624);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(1219, 43);
            this.bookButton.TabIndex = 21;
            this.bookButton.Text = "Book (without paying)";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 673);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.baggageWeightNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expiryDateTimePicker);
            this.Controls.Add(this.docExpiryDateLabel);
            this.Controls.Add(this.issueDateTimePicker);
            this.Controls.Add(this.docIssueDateLabel);
            this.Controls.Add(this.docNumberTextBox);
            this.Controls.Add(this.travelDocNumberLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chooseDatesMonthCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Flight Booking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baggageWeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar chooseDatesMonthCalendar;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton idCardRadioButton;
        private System.Windows.Forms.RadioButton passportRadioButton;
        private System.Windows.Forms.Label travelDocNumberLabel;
        private System.Windows.Forms.TextBox docNumberTextBox;
        private System.Windows.Forms.Label docIssueDateLabel;
        private System.Windows.Forms.DateTimePicker issueDateTimePicker;
        private System.Windows.Forms.DateTimePicker expiryDateTimePicker;
        private System.Windows.Forms.Label docExpiryDateLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown baggageWeightNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bookButton;
    }
}

