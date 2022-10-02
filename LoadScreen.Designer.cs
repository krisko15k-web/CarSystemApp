namespace CarSystemApp
{
    partial class LoadScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadScreen));
            this.myCar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.myProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Percentage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).BeginInit();
            this.myProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // myCar
            // 
            this.myCar.FillColor = System.Drawing.Color.Transparent;
            this.myCar.Image = ((System.Drawing.Image)(resources.GetObject("myCar.Image")));
            this.myCar.ImageRotate = 0F;
            this.myCar.Location = new System.Drawing.Point(56, 106);
            this.myCar.Name = "myCar";
            this.myCar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myCar.Size = new System.Drawing.Size(276, 182);
            this.myCar.TabIndex = 0;
            this.myCar.TabStop = false;
            this.myCar.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // myProgress
            // 
            this.myProgress.Controls.Add(this.Percentage);
            this.myProgress.Controls.Add(this.myCar);
            this.myProgress.FillColor = System.Drawing.Color.DarkRed;
            this.myProgress.FillThickness = 15;
            this.myProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myProgress.ForeColor = System.Drawing.Color.White;
            this.myProgress.Location = new System.Drawing.Point(305, 88);
            this.myProgress.Minimum = 0;
            this.myProgress.Name = "myProgress";
            this.myProgress.ProgressThickness = 7;
            this.myProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.myProgress.Size = new System.Drawing.Size(379, 379);
            this.myProgress.TabIndex = 1;
            this.myProgress.Text = "guna2CircleProgressBar1";
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Percentage.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Percentage.ForeColor = System.Drawing.Color.White;
            this.Percentage.Location = new System.Drawing.Point(148, 256);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(42, 34);
            this.Percentage.TabIndex = 4;
            this.Percentage.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(254, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAR RENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(749, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кристиян Пързулов ФН:18621794";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1007, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).EndInit();
            this.myProgress.ResumeLayout(false);
            this.myProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox myCar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar myProgress;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label Percentage;
    }
}