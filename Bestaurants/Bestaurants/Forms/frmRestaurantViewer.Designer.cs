namespace Bestaurants.Forms
{
    partial class frmRestaurantViewer
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdRest = new System.Windows.Forms.Button();
            this.cmdBars = new System.Windows.Forms.Button();
            this.cmdLounges = new System.Windows.Forms.Button();
            this.cmdDiners = new System.Windows.Forms.Button();
            this.cmdCafe = new System.Windows.Forms.Button();
            this.venuescomboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categorycomboBox2 = new System.Windows.Forms.ComboBox();
            this.descriptionlabel4 = new System.Windows.Forms.Label();
            this.websitelabel5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.searchtextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchbutton5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 313);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Layers:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdRest
            // 
            this.cmdRest.Location = new System.Drawing.Point(29, 19);
            this.cmdRest.Name = "cmdRest";
            this.cmdRest.Size = new System.Drawing.Size(72, 23);
            this.cmdRest.TabIndex = 4;
            this.cmdRest.Tag = "1";
            this.cmdRest.Text = "Restaurants";
            this.cmdRest.UseVisualStyleBackColor = true;
            this.cmdRest.Click += new System.EventHandler(this.cmdClick_Click);
            // 
            // cmdBars
            // 
            this.cmdBars.Location = new System.Drawing.Point(107, 19);
            this.cmdBars.Name = "cmdBars";
            this.cmdBars.Size = new System.Drawing.Size(42, 23);
            this.cmdBars.TabIndex = 5;
            this.cmdBars.Tag = "3";
            this.cmdBars.Text = "Bars";
            this.cmdBars.UseVisualStyleBackColor = true;
            this.cmdBars.Click += new System.EventHandler(this.cmdClick_Click);
            // 
            // cmdLounges
            // 
            this.cmdLounges.Location = new System.Drawing.Point(155, 19);
            this.cmdLounges.Name = "cmdLounges";
            this.cmdLounges.Size = new System.Drawing.Size(61, 23);
            this.cmdLounges.TabIndex = 6;
            this.cmdLounges.Tag = "4";
            this.cmdLounges.Text = "Lounges";
            this.cmdLounges.UseVisualStyleBackColor = true;
            this.cmdLounges.Click += new System.EventHandler(this.cmdClick_Click);
            // 
            // cmdDiners
            // 
            this.cmdDiners.Location = new System.Drawing.Point(222, 19);
            this.cmdDiners.Name = "cmdDiners";
            this.cmdDiners.Size = new System.Drawing.Size(72, 23);
            this.cmdDiners.TabIndex = 7;
            this.cmdDiners.Tag = "0";
            this.cmdDiners.Text = "Diners";
            this.cmdDiners.UseVisualStyleBackColor = true;
            this.cmdDiners.Click += new System.EventHandler(this.cmdClick_Click);
            // 
            // cmdCafe
            // 
            this.cmdCafe.Location = new System.Drawing.Point(300, 19);
            this.cmdCafe.Name = "cmdCafe";
            this.cmdCafe.Size = new System.Drawing.Size(72, 23);
            this.cmdCafe.TabIndex = 8;
            this.cmdCafe.Tag = "2";
            this.cmdCafe.Text = "Cafes";
            this.cmdCafe.UseVisualStyleBackColor = true;
            this.cmdCafe.Click += new System.EventHandler(this.cmdClick_Click);
            // 
            // venuescomboBox2
            // 
            this.venuescomboBox2.FormattingEnabled = true;
            this.venuescomboBox2.Location = new System.Drawing.Point(70, 46);
            this.venuescomboBox2.Name = "venuescomboBox2";
            this.venuescomboBox2.Size = new System.Drawing.Size(154, 21);
            this.venuescomboBox2.TabIndex = 9;
            this.venuescomboBox2.SelectedIndexChanged += new System.EventHandler(this.venuescomboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Venues:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdRest);
            this.groupBox1.Controls.Add(this.cmdBars);
            this.groupBox1.Controls.Add(this.cmdLounges);
            this.groupBox1.Controls.Add(this.cmdCafe);
            this.groupBox1.Controls.Add(this.cmdDiners);
            this.groupBox1.Location = new System.Drawing.Point(20, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 59);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Types";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Category:";
            // 
            // categorycomboBox2
            // 
            this.categorycomboBox2.FormattingEnabled = true;
            this.categorycomboBox2.Location = new System.Drawing.Point(70, 19);
            this.categorycomboBox2.Name = "categorycomboBox2";
            this.categorycomboBox2.Size = new System.Drawing.Size(154, 21);
            this.categorycomboBox2.TabIndex = 12;
            this.categorycomboBox2.SelectedIndexChanged += new System.EventHandler(this.categorycomboBox2_SelectedIndexChanged);
            // 
            // descriptionlabel4
            // 
            this.descriptionlabel4.AutoSize = true;
            this.descriptionlabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlabel4.Location = new System.Drawing.Point(12, 75);
            this.descriptionlabel4.Name = "descriptionlabel4";
            this.descriptionlabel4.Size = new System.Drawing.Size(63, 13);
            this.descriptionlabel4.TabIndex = 14;
            this.descriptionlabel4.Text = "Description:";
            this.descriptionlabel4.Click += new System.EventHandler(this.label4_Click);
            // 
            // websitelabel5
            // 
            this.websitelabel5.AutoSize = true;
            this.websitelabel5.ForeColor = System.Drawing.Color.Blue;
            this.websitelabel5.Location = new System.Drawing.Point(12, 99);
            this.websitelabel5.Name = "websitelabel5";
            this.websitelabel5.Size = new System.Drawing.Size(49, 13);
            this.websitelabel5.TabIndex = 15;
            this.websitelabel5.Text = "Website:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Select on Map";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Flash";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchtextBox1
            // 
            this.searchtextBox1.Location = new System.Drawing.Point(284, 19);
            this.searchtextBox1.Name = "searchtextBox1";
            this.searchtextBox1.Size = new System.Drawing.Size(124, 20);
            this.searchtextBox1.TabIndex = 18;
            this.searchtextBox1.TextChanged += new System.EventHandler(this.searchtextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search:";
            // 
            // searchbutton5
            // 
            this.searchbutton5.Location = new System.Drawing.Point(414, 19);
            this.searchbutton5.Name = "searchbutton5";
            this.searchbutton5.Size = new System.Drawing.Size(63, 23);
            this.searchbutton5.TabIndex = 20;
            this.searchbutton5.Text = "Search";
            this.searchbutton5.UseVisualStyleBackColor = true;
            this.searchbutton5.Click += new System.EventHandler(this.searchbutton5_Click);
            // 
            // frmRestaurantViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 130);
            this.Controls.Add(this.searchbutton5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.websitelabel5);
            this.Controls.Add(this.descriptionlabel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categorycomboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.venuescomboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmRestaurantViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRestaurantViewer";
            this.Load += new System.EventHandler(this.frmRestaurantViewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdRest;
        private System.Windows.Forms.Button cmdBars;
        private System.Windows.Forms.Button cmdLounges;
        private System.Windows.Forms.Button cmdDiners;
        private System.Windows.Forms.Button cmdCafe;
        private System.Windows.Forms.ComboBox venuescomboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categorycomboBox2;
        public System.Windows.Forms.Label descriptionlabel4;
        public System.Windows.Forms.Label websitelabel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox searchtextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchbutton5;
    }
}