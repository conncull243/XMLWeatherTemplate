namespace XMLWeather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityOutput = new System.Windows.Forms.Label();
            this.tempOutput = new System.Windows.Forms.Label();
            this.windDescription = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.cloudOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.Location = new System.Drawing.Point(96, 9);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(86, 31);
            this.cityOutput.TabIndex = 0;
            this.cityOutput.Text = "label1";
            // 
            // tempOutput
            // 
            this.tempOutput.AutoSize = true;
            this.tempOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempOutput.Location = new System.Drawing.Point(10, 50);
            this.tempOutput.Name = "tempOutput";
            this.tempOutput.Size = new System.Drawing.Size(109, 39);
            this.tempOutput.TabIndex = 1;
            this.tempOutput.Text = "label1";
            // 
            // windDescription
            // 
            this.windDescription.AutoSize = true;
            this.windDescription.Location = new System.Drawing.Point(12, 164);
            this.windDescription.Name = "windDescription";
            this.windDescription.Size = new System.Drawing.Size(35, 13);
            this.windDescription.TabIndex = 2;
            this.windDescription.Text = "label1";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.Location = new System.Drawing.Point(248, 60);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(35, 13);
            this.maxOutput.TabIndex = 3;
            this.maxOutput.Text = "label1";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.Location = new System.Drawing.Point(248, 87);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(35, 13);
            this.minOutput.TabIndex = 4;
            this.minOutput.Text = "label1";
            // 
            // cloudOutput
            // 
            this.cloudOutput.AutoSize = true;
            this.cloudOutput.Location = new System.Drawing.Point(99, 201);
            this.cloudOutput.Name = "cloudOutput";
            this.cloudOutput.Size = new System.Drawing.Size(35, 13);
            this.cloudOutput.TabIndex = 7;
            this.cloudOutput.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(89, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 139);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cloudOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.windDescription);
            this.Controls.Add(this.tempOutput);
            this.Controls.Add(this.cityOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label tempOutput;
        private System.Windows.Forms.Label windDescription;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label cloudOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

