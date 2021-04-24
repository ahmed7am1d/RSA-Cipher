
namespace RSA_Cipher
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
            this.btnDecrypte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateRandomKeys = new System.Windows.Forms.Button();
            this.TextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxKeyResult = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClearField = new System.Windows.Forms.Button();
            this.TextBoxKeyN = new System.Windows.Forms.RichTextBox();
            this.TextBoxKeyE = new System.Windows.Forms.RichTextBox();
            this.TextBoxKeyD = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnEncrypte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxDecryptedText = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxMessageToDecrypte = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDecrypte
            // 
            this.btnDecrypte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(121)))), ((int)(((byte)(62)))));
            this.btnDecrypte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypte.Font = new System.Drawing.Font("Impact", 11.25F);
            this.btnDecrypte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecrypte.Location = new System.Drawing.Point(125, 278);
            this.btnDecrypte.Name = "btnDecrypte";
            this.btnDecrypte.Size = new System.Drawing.Size(154, 63);
            this.btnDecrypte.TabIndex = 2;
            this.btnDecrypte.Text = "Decrypte";
            this.btnDecrypte.UseVisualStyleBackColor = false;
            this.btnDecrypte.Click += new System.EventHandler(this.btnDecrypte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(588, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "RSA Cipher";
            // 
            // btnGenerateRandomKeys
            // 
            this.btnGenerateRandomKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(121)))), ((int)(((byte)(62)))));
            this.btnGenerateRandomKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateRandomKeys.Font = new System.Drawing.Font("Impact", 11.25F);
            this.btnGenerateRandomKeys.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGenerateRandomKeys.Location = new System.Drawing.Point(683, 355);
            this.btnGenerateRandomKeys.Name = "btnGenerateRandomKeys";
            this.btnGenerateRandomKeys.Size = new System.Drawing.Size(261, 115);
            this.btnGenerateRandomKeys.TabIndex = 1;
            this.btnGenerateRandomKeys.Text = "Genrate Random Keys";
            this.btnGenerateRandomKeys.UseVisualStyleBackColor = false;
            this.btnGenerateRandomKeys.Click += new System.EventHandler(this.btnGenerateRandomKeys_Click);
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxMessage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMessage.Location = new System.Drawing.Point(125, 57);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(382, 82);
            this.TextBoxMessage.TabIndex = 5;
            this.TextBoxMessage.Text = "";
            this.TextBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMessage_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "OpenText:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(532, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key [n]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(532, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Key [e]:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(532, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Key [d]:";
            // 
            // TextBoxKeyResult
            // 
            this.TextBoxKeyResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxKeyResult.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.TextBoxKeyResult.Location = new System.Drawing.Point(118, 375);
            this.TextBoxKeyResult.Name = "TextBoxKeyResult";
            this.TextBoxKeyResult.ReadOnly = true;
            this.TextBoxKeyResult.Size = new System.Drawing.Size(382, 191);
            this.TextBoxKeyResult.TabIndex = 13;
            this.TextBoxKeyResult.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(119, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Result Cipher:";
            // 
            // btnClearField
            // 
            this.btnClearField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(121)))), ((int)(((byte)(62)))));
            this.btnClearField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearField.Font = new System.Drawing.Font("Impact", 11.25F);
            this.btnClearField.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearField.Location = new System.Drawing.Point(683, 496);
            this.btnClearField.Name = "btnClearField";
            this.btnClearField.Size = new System.Drawing.Size(261, 115);
            this.btnClearField.TabIndex = 15;
            this.btnClearField.Text = "Clear Fields";
            this.btnClearField.UseVisualStyleBackColor = false;
            this.btnClearField.Click += new System.EventHandler(this.btnClearField_Click);
            // 
            // TextBoxKeyN
            // 
            this.TextBoxKeyN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxKeyN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxKeyN.Location = new System.Drawing.Point(644, 124);
            this.TextBoxKeyN.Name = "TextBoxKeyN";
            this.TextBoxKeyN.Size = new System.Drawing.Size(382, 32);
            this.TextBoxKeyN.TabIndex = 16;
            this.TextBoxKeyN.Text = "0";
            this.TextBoxKeyN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyN_KeyPress);
            // 
            // TextBoxKeyE
            // 
            this.TextBoxKeyE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxKeyE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxKeyE.Location = new System.Drawing.Point(644, 190);
            this.TextBoxKeyE.Name = "TextBoxKeyE";
            this.TextBoxKeyE.Size = new System.Drawing.Size(382, 32);
            this.TextBoxKeyE.TabIndex = 17;
            this.TextBoxKeyE.Text = "0";
            this.TextBoxKeyE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyE_KeyPress);
            // 
            // TextBoxKeyD
            // 
            this.TextBoxKeyD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxKeyD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TextBoxKeyD.Location = new System.Drawing.Point(644, 255);
            this.TextBoxKeyD.Name = "TextBoxKeyD";
            this.TextBoxKeyD.Size = new System.Drawing.Size(382, 32);
            this.TextBoxKeyD.TabIndex = 18;
            this.TextBoxKeyD.Text = "0";
            this.TextBoxKeyD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyD_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(119, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "OpenText in Numeric Form(Decimal):";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.Location = new System.Drawing.Point(125, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(382, 78);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // btnEncrypte
            // 
            this.btnEncrypte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(121)))), ((int)(((byte)(62)))));
            this.btnEncrypte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypte.Font = new System.Drawing.Font("Impact", 11.25F);
            this.btnEncrypte.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEncrypte.Location = new System.Drawing.Point(125, 274);
            this.btnEncrypte.Name = "btnEncrypte";
            this.btnEncrypte.Size = new System.Drawing.Size(158, 63);
            this.btnEncrypte.TabIndex = 0;
            this.btnEncrypte.Text = "Encrypte";
            this.btnEncrypte.UseVisualStyleBackColor = false;
            this.btnEncrypte.Click += new System.EventHandler(this.btnEncrypte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(121)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(728, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convertor/Generator";
            // 
            // TextBoxDecryptedText
            // 
            this.TextBoxDecryptedText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxDecryptedText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.TextBoxDecryptedText.Location = new System.Drawing.Point(125, 383);
            this.TextBoxDecryptedText.Name = "TextBoxDecryptedText";
            this.TextBoxDecryptedText.ReadOnly = true;
            this.TextBoxDecryptedText.Size = new System.Drawing.Size(382, 183);
            this.TextBoxDecryptedText.TabIndex = 19;
            this.TextBoxDecryptedText.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(155, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Result OpenText(Decryption):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.richTextBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TextBoxMessageToDecrypte);
            this.groupBox1.Controls.Add(this.TextBoxDecryptedText);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnDecrypte);
            this.groupBox1.Font = new System.Drawing.Font("Urdu Typesetting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(1051, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 586);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decryption Process";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(119, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(352, 32);
            this.label11.TabIndex = 24;
            this.label11.Text = "Result in Numeric Form(Decimal):";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.richTextBox3.Location = new System.Drawing.Point(125, 170);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(382, 86);
            this.richTextBox3.TabIndex = 23;
            this.richTextBox3.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(21, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "Cipher:";
            // 
            // TextBoxMessageToDecrypte
            // 
            this.TextBoxMessageToDecrypte.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBoxMessageToDecrypte.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.TextBoxMessageToDecrypte.Location = new System.Drawing.Point(125, 46);
            this.TextBoxMessageToDecrypte.Name = "TextBoxMessageToDecrypte";
            this.TextBoxMessageToDecrypte.Size = new System.Drawing.Size(382, 82);
            this.TextBoxMessageToDecrypte.TabIndex = 21;
            this.TextBoxMessageToDecrypte.Text = "";
            this.TextBoxMessageToDecrypte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMessageToDecrypte_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBoxMessage);
            this.groupBox2.Controls.Add(this.btnEncrypte);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.TextBoxKeyResult);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Urdu Typesetting", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Snow;
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 586);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption Process";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RSA_Cipher.Properties.Resources.wave;
            this.pictureBox1.Location = new System.Drawing.Point(-188, 682);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1913, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1706, 790);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxKeyD);
            this.Controls.Add(this.TextBoxKeyE);
            this.Controls.Add(this.TextBoxKeyN);
            this.Controls.Add(this.btnClearField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateRandomKeys);
            this.Name = "Form1";
            this.Text = "RSA Cipher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDecrypte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateRandomKeys;
        private System.Windows.Forms.RichTextBox TextBoxMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TextBoxKeyResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearField;
        private System.Windows.Forms.RichTextBox TextBoxKeyN;
        private System.Windows.Forms.RichTextBox TextBoxKeyE;
        private System.Windows.Forms.RichTextBox TextBoxKeyD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnEncrypte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TextBoxDecryptedText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox TextBoxMessageToDecrypte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

