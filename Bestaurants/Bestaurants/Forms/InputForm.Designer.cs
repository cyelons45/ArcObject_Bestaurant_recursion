namespace Bestaurants.Forms
{
    partial class InputForm
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
            this.savebutton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categorycomboBox2 = new System.Windows.Forms.ComboBox();
            this.searchtextBox1 = new System.Windows.Forms.TextBox();
            this.websitetextBox1 = new System.Windows.Forms.TextBox();
            this.descriptiontextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editbutton1 = new System.Windows.Forms.Button();
            this.deletebutton1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.number_of_reviewslabel6 = new System.Windows.Forms.Label();
            this.starRating1 = new Bestaurants.starRating();
            this.reviewgroupBox1 = new System.Windows.Forms.GroupBox();
            this.user_textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.review_textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.submitreview_button1 = new System.Windows.Forms.Button();
            this.rating_comboBox1 = new System.Windows.Forms.ComboBox();
            this.reviewgroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // savebutton1
            // 
            this.savebutton1.Location = new System.Drawing.Point(259, 229);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(75, 23);
            this.savebutton1.TabIndex = 0;
            this.savebutton1.Text = "Save";
            this.savebutton1.UseVisualStyleBackColor = true;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Restaurant Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Restaurant Website:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Restaurant Category:";
            // 
            // categorycomboBox2
            // 
            this.categorycomboBox2.FormattingEnabled = true;
            this.categorycomboBox2.Location = new System.Drawing.Point(137, 187);
            this.categorycomboBox2.Name = "categorycomboBox2";
            this.categorycomboBox2.Size = new System.Drawing.Size(199, 21);
            this.categorycomboBox2.TabIndex = 18;
            this.categorycomboBox2.SelectedIndexChanged += new System.EventHandler(this.categorycomboBox2_SelectedIndexChanged);
            // 
            // searchtextBox1
            // 
            this.searchtextBox1.Location = new System.Drawing.Point(137, 29);
            this.searchtextBox1.Name = "searchtextBox1";
            this.searchtextBox1.Size = new System.Drawing.Size(199, 20);
            this.searchtextBox1.TabIndex = 20;
            // 
            // websitetextBox1
            // 
            this.websitetextBox1.Location = new System.Drawing.Point(137, 57);
            this.websitetextBox1.Name = "websitetextBox1";
            this.websitetextBox1.Size = new System.Drawing.Size(199, 20);
            this.websitetextBox1.TabIndex = 21;
            // 
            // descriptiontextBox1
            // 
            this.descriptiontextBox1.Location = new System.Drawing.Point(137, 85);
            this.descriptiontextBox1.Multiline = true;
            this.descriptiontextBox1.Name = "descriptiontextBox1";
            this.descriptiontextBox1.Size = new System.Drawing.Size(199, 64);
            this.descriptiontextBox1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Restaurant Description:";
            // 
            // editbutton1
            // 
            this.editbutton1.Location = new System.Drawing.Point(259, 229);
            this.editbutton1.Name = "editbutton1";
            this.editbutton1.Size = new System.Drawing.Size(75, 23);
            this.editbutton1.TabIndex = 24;
            this.editbutton1.Text = "Edit";
            this.editbutton1.UseVisualStyleBackColor = true;
            this.editbutton1.Click += new System.EventHandler(this.editbutton1_Click);
            // 
            // deletebutton1
            // 
            this.deletebutton1.Location = new System.Drawing.Point(178, 229);
            this.deletebutton1.Name = "deletebutton1";
            this.deletebutton1.Size = new System.Drawing.Size(75, 23);
            this.deletebutton1.TabIndex = 25;
            this.deletebutton1.Text = "Delete";
            this.deletebutton1.UseVisualStyleBackColor = true;
            this.deletebutton1.Click += new System.EventHandler(this.deletebutton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ratings:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(12, 452);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(13, 13);
            this.lblRating.TabIndex = 27;
            this.lblRating.Text = "0";
            // 
            // number_of_reviewslabel6
            // 
            this.number_of_reviewslabel6.AutoSize = true;
            this.number_of_reviewslabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.number_of_reviewslabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_reviewslabel6.ForeColor = System.Drawing.Color.Blue;
            this.number_of_reviewslabel6.Location = new System.Drawing.Point(232, 165);
            this.number_of_reviewslabel6.Name = "number_of_reviewslabel6";
            this.number_of_reviewslabel6.Size = new System.Drawing.Size(104, 13);
            this.number_of_reviewslabel6.TabIndex = 28;
            this.number_of_reviewslabel6.Text = "(based on x reviews)";
            this.number_of_reviewslabel6.Click += new System.EventHandler(this.number_of_reviewslabel6_Click);
            // 
            // starRating1
            // 
            this.starRating1.Location = new System.Drawing.Point(137, 155);
            this.starRating1.Name = "starRating1";
            this.starRating1.Size = new System.Drawing.Size(97, 22);
            this.starRating1.TabIndex = 29;
            // 
            // reviewgroupBox1
            // 
            this.reviewgroupBox1.Controls.Add(this.rating_comboBox1);
            this.reviewgroupBox1.Controls.Add(this.submitreview_button1);
            this.reviewgroupBox1.Controls.Add(this.review_textBox3);
            this.reviewgroupBox1.Controls.Add(this.label8);
            this.reviewgroupBox1.Controls.Add(this.label7);
            this.reviewgroupBox1.Controls.Add(this.user_textBox1);
            this.reviewgroupBox1.Controls.Add(this.label6);
            this.reviewgroupBox1.Location = new System.Drawing.Point(20, 272);
            this.reviewgroupBox1.Name = "reviewgroupBox1";
            this.reviewgroupBox1.Size = new System.Drawing.Size(319, 177);
            this.reviewgroupBox1.TabIndex = 30;
            this.reviewgroupBox1.TabStop = false;
            this.reviewgroupBox1.Text = "Post Review";
            // 
            // user_textBox1
            // 
            this.user_textBox1.Location = new System.Drawing.Point(70, 29);
            this.user_textBox1.Name = "user_textBox1";
            this.user_textBox1.Size = new System.Drawing.Size(199, 20);
            this.user_textBox1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "User:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rating:";
            // 
            // review_textBox3
            // 
            this.review_textBox3.Location = new System.Drawing.Point(70, 81);
            this.review_textBox3.Multiline = true;
            this.review_textBox3.Name = "review_textBox3";
            this.review_textBox3.Size = new System.Drawing.Size(199, 52);
            this.review_textBox3.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Review:";
            // 
            // submitreview_button1
            // 
            this.submitreview_button1.Location = new System.Drawing.Point(194, 139);
            this.submitreview_button1.Name = "submitreview_button1";
            this.submitreview_button1.Size = new System.Drawing.Size(75, 23);
            this.submitreview_button1.TabIndex = 28;
            this.submitreview_button1.Text = "Add Review";
            this.submitreview_button1.UseVisualStyleBackColor = true;
            this.submitreview_button1.Click += new System.EventHandler(this.submitreview_button1_Click);
            // 
            // rating_comboBox1
            // 
            this.rating_comboBox1.FormattingEnabled = true;
            this.rating_comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rating_comboBox1.Location = new System.Drawing.Point(70, 55);
            this.rating_comboBox1.Name = "rating_comboBox1";
            this.rating_comboBox1.Size = new System.Drawing.Size(199, 21);
            this.rating_comboBox1.TabIndex = 29;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 486);
            this.Controls.Add(this.reviewgroupBox1);
            this.Controls.Add(this.starRating1);
            this.Controls.Add(this.number_of_reviewslabel6);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletebutton1);
            this.Controls.Add(this.editbutton1);
            this.Controls.Add(this.descriptiontextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.websitetextBox1);
            this.Controls.Add(this.searchtextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categorycomboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.savebutton1);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.reviewgroupBox1.ResumeLayout(false);
            this.reviewgroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebutton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox categorycomboBox2;
        public System.Windows.Forms.TextBox searchtextBox1;
        public System.Windows.Forms.TextBox websitetextBox1;
        public System.Windows.Forms.TextBox descriptiontextBox1;
        private System.Windows.Forms.Button editbutton1;
        private System.Windows.Forms.Button deletebutton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label number_of_reviewslabel6;
        private starRating starRating1;
        private System.Windows.Forms.GroupBox reviewgroupBox1;
        private System.Windows.Forms.ComboBox rating_comboBox1;
        private System.Windows.Forms.Button submitreview_button1;
        public System.Windows.Forms.TextBox review_textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox user_textBox1;
        private System.Windows.Forms.Label label6;
    }
}