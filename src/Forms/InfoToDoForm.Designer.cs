namespace WindowsFormExam.Forms
{
    partial class InfoToDoForm
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
            infoTitleLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // infoTitleLabel
            // 
            infoTitleLabel.AutoSize = true;
            infoTitleLabel.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoTitleLabel.Location = new Point(57, 50);
            infoTitleLabel.Name = "infoTitleLabel";
            infoTitleLabel.Size = new Size(84, 28);
            infoTitleLabel.TabIndex = 0;
            infoTitleLabel.Text = "Title:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.Location = new Point(178, 50);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(0, 28);
            titleLabel.TabIndex = 1;
            // 
            // InfoToDoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleLabel);
            Controls.Add(infoTitleLabel);
            Name = "InfoToDoForm";
            Text = "InfoToDoForm";
            Load += InfoToDoFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoTitleLabel;
        private Label titleLabel;
    }
}