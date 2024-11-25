namespace graphics2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDebug = new System.Windows.Forms.Label();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.picPressStart = new System.Windows.Forms.PictureBox();
            this.tmrLoader = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPressStart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.BackColor = System.Drawing.Color.Red;
            this.lblDebug.Enabled = false;
            this.lblDebug.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDebug.ForeColor = System.Drawing.Color.Black;
            this.lblDebug.Location = new System.Drawing.Point(12, 9);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(49, 14);
            this.lblDebug.TabIndex = 0;
            this.lblDebug.Text = "label1";
            this.lblDebug.Visible = false;
            // 
            // picLoading
            // 
            this.picLoading.BackgroundImage = global::graphics2.Properties.Resources.LOADING;
            this.picLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLoading.Location = new System.Drawing.Point(337, 98);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(160, 20);
            this.picLoading.TabIndex = 1;
            this.picLoading.TabStop = false;
            // 
            // picPressStart
            // 
            this.picPressStart.BackgroundImage = global::graphics2.Properties.Resources.PRESSSTART;
            this.picPressStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPressStart.Location = new System.Drawing.Point(270, 535);
            this.picPressStart.Name = "picPressStart";
            this.picPressStart.Size = new System.Drawing.Size(276, 40);
            this.picPressStart.TabIndex = 2;
            this.picPressStart.TabStop = false;
            this.picPressStart.Visible = false;
            // 
            // tmrLoader
            // 
            this.tmrLoader.Enabled = true;
            this.tmrLoader.Interval = 10000;
            this.tmrLoader.Tick += new System.EventHandler(this.tmrLoader_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::graphics2.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 660);
            this.Controls.Add(this.picPressStart);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.lblDebug);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Drive Loading Screen Remake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPressStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblDebug;
        private PictureBox picLoading;
        private PictureBox picPressStart;
        private System.Windows.Forms.Timer tmrLoader;
    }
}