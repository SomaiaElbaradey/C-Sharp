
namespace HotalManagement
{
    partial class Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Food));
            this.foodBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.breakfast = new System.Windows.Forms.CheckBox();
            this.lunch = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dinner = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cleaning = new System.Windows.Forms.CheckBox();
            this.towels = new System.Windows.Forms.CheckBox();
            this.sweats = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.breakfastQuantity = new System.Windows.Forms.NumericUpDown();
            this.lunchQuantity = new System.Windows.Forms.NumericUpDown();
            this.dinnerQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // foodBtn
            // 
            this.foodBtn.BackColor = System.Drawing.Color.Black;
            this.foodBtn.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foodBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.foodBtn.Location = new System.Drawing.Point(192, 455);
            this.foodBtn.Name = "foodBtn";
            this.foodBtn.Size = new System.Drawing.Size(156, 39);
            this.foodBtn.TabIndex = 46;
            this.foodBtn.Text = "Submit";
            this.foodBtn.UseVisualStyleBackColor = false;
            this.foodBtn.Click += new System.EventHandler(this.foodBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(46)))));
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(183, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Food and Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // breakfast
            // 
            this.breakfast.AutoSize = true;
            this.breakfast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.breakfast.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.breakfast.Location = new System.Drawing.Point(72, 235);
            this.breakfast.Name = "breakfast";
            this.breakfast.Size = new System.Drawing.Size(109, 24);
            this.breakfast.TabIndex = 48;
            this.breakfast.Text = "Breakfast";
            this.breakfast.UseVisualStyleBackColor = false;
            this.breakfast.CheckedChanged += new System.EventHandler(this.breakfast_CheckedChanged);
            // 
            // lunch
            // 
            this.lunch.AutoSize = true;
            this.lunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.lunch.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lunch.Location = new System.Drawing.Point(240, 235);
            this.lunch.Name = "lunch";
            this.lunch.Size = new System.Drawing.Size(79, 24);
            this.lunch.TabIndex = 51;
            this.lunch.Text = "Lunch";
            this.lunch.UseVisualStyleBackColor = false;
            this.lunch.CheckedChanged += new System.EventHandler(this.lunch_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(229, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // dinner
            // 
            this.dinner.AutoSize = true;
            this.dinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.dinner.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dinner.Location = new System.Drawing.Point(405, 235);
            this.dinner.Name = "dinner";
            this.dinner.Size = new System.Drawing.Size(85, 24);
            this.dinner.TabIndex = 54;
            this.dinner.Text = "Dinner";
            this.dinner.UseVisualStyleBackColor = false;
            this.dinner.CheckedChanged += new System.EventHandler(this.dinner_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(377, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(46)))));
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 55;
            this.label2.Text = "Menu";
            // 
            // cleaning
            // 
            this.cleaning.AutoSize = true;
            this.cleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.cleaning.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cleaning.Location = new System.Drawing.Point(69, 389);
            this.cleaning.Name = "cleaning";
            this.cleaning.Size = new System.Drawing.Size(101, 24);
            this.cleaning.TabIndex = 56;
            this.cleaning.Text = "Cleaning";
            this.cleaning.UseVisualStyleBackColor = false;
            // 
            // towels
            // 
            this.towels.AutoSize = true;
            this.towels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.towels.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.towels.Location = new System.Drawing.Point(212, 389);
            this.towels.Name = "towels";
            this.towels.Size = new System.Drawing.Size(85, 24);
            this.towels.TabIndex = 57;
            this.towels.Text = "Towels";
            this.towels.UseVisualStyleBackColor = false;
            // 
            // sweats
            // 
            this.sweats.AutoSize = true;
            this.sweats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.sweats.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sweats.Location = new System.Drawing.Point(343, 389);
            this.sweats.Name = "sweats";
            this.sweats.Size = new System.Drawing.Size(176, 24);
            this.sweats.TabIndex = 58;
            this.sweats.Text = "Sweatest Surprise";
            this.sweats.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-16, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(628, 518);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // breakfastQuantity
            // 
            this.breakfastQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.breakfastQuantity.Location = new System.Drawing.Point(72, 265);
            this.breakfastQuantity.Name = "breakfastQuantity";
            this.breakfastQuantity.Size = new System.Drawing.Size(109, 27);
            this.breakfastQuantity.TabIndex = 60;
            // 
            // lunchQuantity
            // 
            this.lunchQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.lunchQuantity.Location = new System.Drawing.Point(240, 265);
            this.lunchQuantity.Name = "lunchQuantity";
            this.lunchQuantity.Size = new System.Drawing.Size(97, 27);
            this.lunchQuantity.TabIndex = 61;
            // 
            // dinnerQuantity
            // 
            this.dinnerQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(204)))));
            this.dinnerQuantity.Location = new System.Drawing.Point(405, 265);
            this.dinnerQuantity.Name = "dinnerQuantity";
            this.dinnerQuantity.Size = new System.Drawing.Size(97, 27);
            this.dinnerQuantity.TabIndex = 62;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 517);
            this.Controls.Add(this.dinnerQuantity);
            this.Controls.Add(this.lunchQuantity);
            this.Controls.Add(this.breakfastQuantity);
            this.Controls.Add(this.sweats);
            this.Controls.Add(this.towels);
            this.Controls.Add(this.cleaning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dinner);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lunch);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.breakfast);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.foodBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button foodBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.CheckBox breakfast;
        public System.Windows.Forms.CheckBox lunch;
        public System.Windows.Forms.CheckBox dinner;
        public System.Windows.Forms.CheckBox cleaning;
        public System.Windows.Forms.CheckBox towels;
        public System.Windows.Forms.CheckBox sweats;
        public System.Windows.Forms.NumericUpDown breakfastQuantity;
        public System.Windows.Forms.NumericUpDown lunchQuantity;
        public System.Windows.Forms.NumericUpDown dinnerQuantity;
    }
}