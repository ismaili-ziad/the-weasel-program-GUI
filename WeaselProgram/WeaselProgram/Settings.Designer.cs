
namespace WeaselProgram
{
    partial class Settings
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
            this.closeButton = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.probs = new System.Windows.Forms.Label();
            this.numberMuts = new System.Windows.Forms.Label();
            this.mutsSelect = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutsSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 194);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(393, 36);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(12, 42);
            this.trackBar.Maximum = 100;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(393, 56);
            this.trackBar.SmallChange = 5;
            this.trackBar.TabIndex = 2;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // probs
            // 
            this.probs.AutoSize = true;
            this.probs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.probs.Location = new System.Drawing.Point(12, 9);
            this.probs.Name = "probs";
            this.probs.Size = new System.Drawing.Size(87, 20);
            this.probs.TabIndex = 3;
            this.probs.Text = "Probability";
            this.probs.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // numberMuts
            // 
            this.numberMuts.AutoSize = true;
            this.numberMuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberMuts.Location = new System.Drawing.Point(16, 96);
            this.numberMuts.Name = "numberMuts";
            this.numberMuts.Size = new System.Drawing.Size(102, 20);
            this.numberMuts.TabIndex = 4;
            this.numberMuts.Text = "numberMuts";
            this.numberMuts.Click += new System.EventHandler(this.numberMuts_Click);
            // 
            // mutsSelect
            // 
            this.mutsSelect.LargeChange = 100;
            this.mutsSelect.Location = new System.Drawing.Point(12, 131);
            this.mutsSelect.Maximum = 1000;
            this.mutsSelect.Minimum = 10;
            this.mutsSelect.Name = "mutsSelect";
            this.mutsSelect.Size = new System.Drawing.Size(393, 56);
            this.mutsSelect.SmallChange = 10;
            this.mutsSelect.TabIndex = 5;
            this.mutsSelect.Value = 10;
            this.mutsSelect.Scroll += new System.EventHandler(this.mutsSelect_Scroll);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 242);
            this.Controls.Add(this.mutsSelect);
            this.Controls.Add(this.numberMuts);
            this.Controls.Add(this.probs);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutsSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label probs;
        private System.Windows.Forms.Label numberMuts;
        private System.Windows.Forms.TrackBar mutsSelect;
    }
}