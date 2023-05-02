using System;
using System.Windows.Forms;

namespace Lab_4_1
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
            this.salesDateMaskedTextbox = new System.Windows.Forms.MaskedTextBox();
            this.propertyTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.commercialRadioButton = new System.Windows.Forms.RadioButton();
            this.residentialRadioButton = new System.Windows.Forms.RadioButton();
            this.countyGroupBox = new System.Windows.Forms.GroupBox();
            this.polkRadioButton = new System.Windows.Forms.RadioButton();
            this.pascoRadioButton = new System.Windows.Forms.RadioButton();
            this.hillsboroughRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.propertyPriceTextbox = new System.Windows.Forms.TextBox();
            this.updatePropertyPriceButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stateTaxOutputLabel = new System.Windows.Forms.Label();
            this.countyTaxOutputLabel = new System.Windows.Forms.Label();
            this.commissionOutputLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalPriceOutputLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.propertyTypeGroupBox.SuspendLayout();
            this.countyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Date:";
            // 
            // salesDateMaskedTextbox
            // 
            this.salesDateMaskedTextbox.Location = new System.Drawing.Point(369, 48);
            this.salesDateMaskedTextbox.Mask = "00/00/0000";
            this.salesDateMaskedTextbox.Name = "salesDateMaskedTextbox";
            this.salesDateMaskedTextbox.Size = new System.Drawing.Size(73, 22);
            this.salesDateMaskedTextbox.TabIndex = 1;
            this.salesDateMaskedTextbox.ValidatingType = typeof(System.DateTime);
            this.salesDateMaskedTextbox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.salesDateMaskedTextbox_MaskInputRejected);
            // 
            // propertyTypeGroupBox
            // 
            this.propertyTypeGroupBox.Controls.Add(this.commercialRadioButton);
            this.propertyTypeGroupBox.Controls.Add(this.residentialRadioButton);
            this.propertyTypeGroupBox.Location = new System.Drawing.Point(285, 99);
            this.propertyTypeGroupBox.Name = "propertyTypeGroupBox";
            this.propertyTypeGroupBox.Size = new System.Drawing.Size(157, 100);
            this.propertyTypeGroupBox.TabIndex = 2;
            this.propertyTypeGroupBox.TabStop = false;
            this.propertyTypeGroupBox.Text = "Property Type";
            // 
            // commercialRadioButton
            // 
            this.commercialRadioButton.AutoSize = true;
            this.commercialRadioButton.Location = new System.Drawing.Point(25, 62);
            this.commercialRadioButton.Name = "commercialRadioButton";
            this.commercialRadioButton.Size = new System.Drawing.Size(102, 21);
            this.commercialRadioButton.TabIndex = 1;
            this.commercialRadioButton.Text = "Commercial";
            this.commercialRadioButton.UseVisualStyleBackColor = true;
            // 
            // residentialRadioButton
            // 
            this.residentialRadioButton.AutoSize = true;
            this.residentialRadioButton.Checked = true;
            this.residentialRadioButton.Location = new System.Drawing.Point(25, 35);
            this.residentialRadioButton.Name = "residentialRadioButton";
            this.residentialRadioButton.Size = new System.Drawing.Size(99, 21);
            this.residentialRadioButton.TabIndex = 0;
            this.residentialRadioButton.TabStop = true;
            this.residentialRadioButton.Text = "Residential";
            this.residentialRadioButton.UseVisualStyleBackColor = true;
            // 
            // countyGroupBox
            // 
            this.countyGroupBox.Controls.Add(this.polkRadioButton);
            this.countyGroupBox.Controls.Add(this.pascoRadioButton);
            this.countyGroupBox.Controls.Add(this.hillsboroughRadioButton);
            this.countyGroupBox.Location = new System.Drawing.Point(285, 233);
            this.countyGroupBox.Name = "countyGroupBox";
            this.countyGroupBox.Size = new System.Drawing.Size(157, 109);
            this.countyGroupBox.TabIndex = 3;
            this.countyGroupBox.TabStop = false;
            this.countyGroupBox.Text = "County";
            this.countyGroupBox.Enter += new System.EventHandler(this.countyGroupBox_Enter);
            // 
            // polkRadioButton
            // 
            this.polkRadioButton.AutoSize = true;
            this.polkRadioButton.Location = new System.Drawing.Point(26, 77);
            this.polkRadioButton.Name = "polkRadioButton";
            this.polkRadioButton.Size = new System.Drawing.Size(56, 21);
            this.polkRadioButton.TabIndex = 2;
            this.polkRadioButton.Text = "Polk";
            this.polkRadioButton.UseVisualStyleBackColor = true;
            // 
            // pascoRadioButton
            // 
            this.pascoRadioButton.AutoSize = true;
            this.pascoRadioButton.Location = new System.Drawing.Point(26, 50);
            this.pascoRadioButton.Name = "pascoRadioButton";
            this.pascoRadioButton.Size = new System.Drawing.Size(68, 21);
            this.pascoRadioButton.TabIndex = 1;
            this.pascoRadioButton.Text = "Pasco";
            this.pascoRadioButton.UseVisualStyleBackColor = true;
            // 
            // hillsboroughRadioButton
            // 
            this.hillsboroughRadioButton.AutoSize = true;
            this.hillsboroughRadioButton.Checked = true;
            this.hillsboroughRadioButton.Location = new System.Drawing.Point(25, 23);
            this.hillsboroughRadioButton.Name = "hillsboroughRadioButton";
            this.hillsboroughRadioButton.Size = new System.Drawing.Size(108, 21);
            this.hillsboroughRadioButton.TabIndex = 0;
            this.hillsboroughRadioButton.TabStop = true;
            this.hillsboroughRadioButton.Text = "Hillsborough";
            this.hillsboroughRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Property Price:";
            // 
            // propertyPriceTextbox
            // 
            this.propertyPriceTextbox.Location = new System.Drawing.Point(382, 369);
            this.propertyPriceTextbox.Name = "propertyPriceTextbox";
            this.propertyPriceTextbox.Size = new System.Drawing.Size(85, 22);
            this.propertyPriceTextbox.TabIndex = 5;
            this.propertyPriceTextbox.Text = "0.00";
            this.propertyPriceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.propertyPriceTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // updatePropertyPriceButton
            // 
            this.updatePropertyPriceButton.Location = new System.Drawing.Point(285, 417);
            this.updatePropertyPriceButton.Name = "updatePropertyPriceButton";
            this.updatePropertyPriceButton.Size = new System.Drawing.Size(159, 31);
            this.updatePropertyPriceButton.TabIndex = 6;
            this.updatePropertyPriceButton.Text = "&Update Property Price";
            this.updatePropertyPriceButton.UseVisualStyleBackColor = true;
            this.updatePropertyPriceButton.Click += new System.EventHandler(this.updatePropertyPriceButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "State Sales Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "County Sales Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Commission:";
            // 
            // stateTaxOutputLabel
            // 
            this.stateTaxOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateTaxOutputLabel.Location = new System.Drawing.Point(369, 476);
            this.stateTaxOutputLabel.Name = "stateTaxOutputLabel";
            this.stateTaxOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.stateTaxOutputLabel.TabIndex = 10;
            this.stateTaxOutputLabel.Text = "$0.00";
            this.stateTaxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stateTaxOutputLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // countyTaxOutputLabel
            // 
            this.countyTaxOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countyTaxOutputLabel.Location = new System.Drawing.Point(369, 511);
            this.countyTaxOutputLabel.Name = "countyTaxOutputLabel";
            this.countyTaxOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.countyTaxOutputLabel.TabIndex = 11;
            this.countyTaxOutputLabel.Text = "$0.00";
            this.countyTaxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // commissionOutputLabel
            // 
            this.commissionOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commissionOutputLabel.Location = new System.Drawing.Point(369, 545);
            this.commissionOutputLabel.Name = "commissionOutputLabel";
            this.commissionOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.commissionOutputLabel.TabIndex = 12;
            this.commissionOutputLabel.Text = "$0.00";
            this.commissionOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(344, 594);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 3);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Price:";
            // 
            // totalPriceOutputLabel
            // 
            this.totalPriceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOutputLabel.Location = new System.Drawing.Point(369, 612);
            this.totalPriceOutputLabel.Name = "totalPriceOutputLabel";
            this.totalPriceOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalPriceOutputLabel.TabIndex = 15;
            this.totalPriceOutputLabel.Text = "$0.00";
            this.totalPriceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(208, 656);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 31);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(320, 656);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 31);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(429, 656);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 32);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 746);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.totalPriceOutputLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.commissionOutputLabel);
            this.Controls.Add(this.countyTaxOutputLabel);
            this.Controls.Add(this.stateTaxOutputLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updatePropertyPriceButton);
            this.Controls.Add(this.propertyPriceTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countyGroupBox);
            this.Controls.Add(this.propertyTypeGroupBox);
            this.Controls.Add(this.salesDateMaskedTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.propertyTypeGroupBox.ResumeLayout(false);
            this.propertyTypeGroupBox.PerformLayout();
            this.countyGroupBox.ResumeLayout(false);
            this.countyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void countyGroupBox_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void salesDateMaskedTextbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox salesDateMaskedTextbox;
        private System.Windows.Forms.GroupBox propertyTypeGroupBox;
        private System.Windows.Forms.RadioButton commercialRadioButton;
        private System.Windows.Forms.RadioButton residentialRadioButton;
        private System.Windows.Forms.GroupBox countyGroupBox;
        private System.Windows.Forms.RadioButton polkRadioButton;
        private System.Windows.Forms.RadioButton pascoRadioButton;
        private System.Windows.Forms.RadioButton hillsboroughRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox propertyPriceTextbox;
        private System.Windows.Forms.Button updatePropertyPriceButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stateTaxOutputLabel;
        private System.Windows.Forms.Label countyTaxOutputLabel;
        private System.Windows.Forms.Label commissionOutputLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalPriceOutputLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

