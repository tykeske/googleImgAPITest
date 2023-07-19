namespace codeTest
{
    partial class powerPointHelper
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.slideTextBox = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.boldButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.optionThreePicture = new System.Windows.Forms.PictureBox();
            this.optionTwoPicture = new System.Windows.Forms.PictureBox();
            this.optionOnePicture = new System.Windows.Forms.PictureBox();
            this.optionOneCheckBox = new System.Windows.Forms.CheckBox();
            this.optionTwoCheckBox = new System.Windows.Forms.CheckBox();
            this.optionThreeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionThreePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionTwoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionOnePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PowerPoint Helper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Slide Text:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(88, 19);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(351, 20);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            this.titleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.titleTextBox_KeyPress);
            this.titleTextBox.Validated += new System.EventHandler(this.titleTextBox_Validated);
            // 
            // slideTextBox
            // 
            this.slideTextBox.Location = new System.Drawing.Point(88, 54);
            this.slideTextBox.Name = "slideTextBox";
            this.slideTextBox.Size = new System.Drawing.Size(351, 89);
            this.slideTextBox.TabIndex = 4;
            this.slideTextBox.Text = "";
            this.slideTextBox.TextChanged += new System.EventHandler(this.slideTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(364, 149);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Controls.Add(this.boldButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.slideTextBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slide Content";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(88, 175);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(351, 20);
            this.searchBox.TabIndex = 13;
            // 
            // boldButton
            // 
            this.boldButton.Location = new System.Drawing.Point(7, 75);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(75, 52);
            this.boldButton.TabIndex = 11;
            this.boldButton.Text = "&Bold Highlighted Text";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(475, 75);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(178, 39);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(475, 133);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(178, 39);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(475, 19);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(178, 39);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "&Create Slide";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // optionThreePicture
            // 
            this.optionThreePicture.Location = new System.Drawing.Point(487, 267);
            this.optionThreePicture.Name = "optionThreePicture";
            this.optionThreePicture.Size = new System.Drawing.Size(210, 137);
            this.optionThreePicture.TabIndex = 7;
            this.optionThreePicture.TabStop = false;
            // 
            // optionTwoPicture
            // 
            this.optionTwoPicture.Location = new System.Drawing.Point(257, 267);
            this.optionTwoPicture.Name = "optionTwoPicture";
            this.optionTwoPicture.Size = new System.Drawing.Size(210, 137);
            this.optionTwoPicture.TabIndex = 8;
            this.optionTwoPicture.TabStop = false;
            // 
            // optionOnePicture
            // 
            this.optionOnePicture.Location = new System.Drawing.Point(12, 267);
            this.optionOnePicture.Name = "optionOnePicture";
            this.optionOnePicture.Size = new System.Drawing.Size(210, 137);
            this.optionOnePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.optionOnePicture.TabIndex = 9;
            this.optionOnePicture.TabStop = false;
            // 
            // optionOneCheckBox
            // 
            this.optionOneCheckBox.AutoSize = true;
            this.optionOneCheckBox.Location = new System.Drawing.Point(72, 418);
            this.optionOneCheckBox.Name = "optionOneCheckBox";
            this.optionOneCheckBox.Size = new System.Drawing.Size(80, 17);
            this.optionOneCheckBox.TabIndex = 10;
            this.optionOneCheckBox.Text = "Option One";
            this.optionOneCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionTwoCheckBox
            // 
            this.optionTwoCheckBox.AutoSize = true;
            this.optionTwoCheckBox.Location = new System.Drawing.Point(321, 418);
            this.optionTwoCheckBox.Name = "optionTwoCheckBox";
            this.optionTwoCheckBox.Size = new System.Drawing.Size(81, 17);
            this.optionTwoCheckBox.TabIndex = 11;
            this.optionTwoCheckBox.Text = "Option Two";
            this.optionTwoCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionThreeCheckBox
            // 
            this.optionThreeCheckBox.AutoSize = true;
            this.optionThreeCheckBox.Location = new System.Drawing.Point(557, 418);
            this.optionThreeCheckBox.Name = "optionThreeCheckBox";
            this.optionThreeCheckBox.Size = new System.Drawing.Size(88, 17);
            this.optionThreeCheckBox.TabIndex = 12;
            this.optionThreeCheckBox.Text = "Option Three";
            this.optionThreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // powerPointHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(709, 452);
            this.Controls.Add(this.optionThreeCheckBox);
            this.Controls.Add(this.optionTwoCheckBox);
            this.Controls.Add(this.optionOneCheckBox);
            this.Controls.Add(this.optionOnePicture);
            this.Controls.Add(this.optionTwoPicture);
            this.Controls.Add(this.optionThreePicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "powerPointHelper";
            this.Text = "PowerPoint Helper";
            this.Load += new System.EventHandler(this.powerPointHelper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionThreePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionTwoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionOnePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RichTextBox slideTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox optionThreeCheckBox;
        private System.Windows.Forms.CheckBox optionTwoCheckBox;
        private System.Windows.Forms.CheckBox optionOneCheckBox;
        private System.Windows.Forms.PictureBox optionOnePicture;
        private System.Windows.Forms.PictureBox optionTwoPicture;
        private System.Windows.Forms.PictureBox optionThreePicture;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

