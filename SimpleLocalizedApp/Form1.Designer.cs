
namespace SimpleLocalizedApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ActionButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActionButton
            // 
            resources.ApplyResources(this.ActionButton, "ActionButton");
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // WelcomeLabel
            // 
            resources.ApplyResources(this.WelcomeLabel, "WelcomeLabel");
            this.WelcomeLabel.Name = "WelcomeLabel";
            // 
            // ResultLabel
            // 
            resources.ApplyResources(this.ResultLabel, "ResultLabel");
            this.ResultLabel.Name = "ResultLabel";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ActionButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label ResultLabel;
    }
}

