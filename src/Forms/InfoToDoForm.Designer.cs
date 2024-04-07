﻿namespace WindowsFormExam.Forms
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
            createDateLable = new Label();
            createDateInfoLabel = new Label();
            endingDateLabel = new Label();
            endingDateInfoLabel = new Label();
            descriptionRichTextBox = new RichTextBox();
            descriptionInfoLable = new Label();
            readDescriptionButton = new Button();
            readAllInfoButton = new Button();
            pauseReadingButton = new Button();
            SuspendLayout();
            // 
            // infoTitleLabel
            // 
            infoTitleLabel.AutoSize = true;
            infoTitleLabel.BackColor = SystemColors.Info;
            infoTitleLabel.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            infoTitleLabel.ForeColor = SystemColors.InfoText;
            infoTitleLabel.Location = new Point(310, 20);
            infoTitleLabel.Name = "infoTitleLabel";
            infoTitleLabel.Size = new Size(84, 28);
            infoTitleLabel.TabIndex = 0;
            infoTitleLabel.Text = "Title:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = SystemColors.Info;
            titleLabel.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            titleLabel.ForeColor = SystemColors.InfoText;
            titleLabel.Location = new Point(400, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(60, 28);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "TEMP";
            // 
            // createDateLable
            // 
            createDateLable.AutoSize = true;
            createDateLable.BackColor = SystemColors.Info;
            createDateLable.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            createDateLable.ForeColor = SystemColors.InfoText;
            createDateLable.Location = new Point(206, 72);
            createDateLable.Name = "createDateLable";
            createDateLable.Size = new Size(56, 25);
            createDateLable.TabIndex = 3;
            createDateLable.Text = "TEMP";
            // 
            // createDateInfoLabel
            // 
            createDateInfoLabel.AutoSize = true;
            createDateInfoLabel.BackColor = SystemColors.Info;
            createDateInfoLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            createDateInfoLabel.ForeColor = SystemColors.InfoText;
            createDateInfoLabel.Location = new Point(23, 72);
            createDateInfoLabel.Name = "createDateInfoLabel";
            createDateInfoLabel.Size = new Size(177, 25);
            createDateInfoLabel.TabIndex = 2;
            createDateInfoLabel.Text = "Date of create:";
            // 
            // endingDateLabel
            // 
            endingDateLabel.AutoSize = true;
            endingDateLabel.BackColor = SystemColors.Info;
            endingDateLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endingDateLabel.ForeColor = SystemColors.InfoText;
            endingDateLabel.Location = new Point(594, 72);
            endingDateLabel.Name = "endingDateLabel";
            endingDateLabel.Size = new Size(56, 25);
            endingDateLabel.TabIndex = 5;
            endingDateLabel.Text = "TEMP";
            // 
            // endingDateInfoLabel
            // 
            endingDateInfoLabel.AutoSize = true;
            endingDateInfoLabel.BackColor = SystemColors.Info;
            endingDateInfoLabel.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endingDateInfoLabel.ForeColor = SystemColors.InfoText;
            endingDateInfoLabel.Location = new Point(444, 72);
            endingDateInfoLabel.Name = "endingDateInfoLabel";
            endingDateInfoLabel.Size = new Size(144, 25);
            endingDateInfoLabel.TabIndex = 4;
            endingDateInfoLabel.Text = "Complete by:";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.BackColor = Color.FloralWhite;
            descriptionRichTextBox.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            descriptionRichTextBox.ForeColor = SystemColors.InfoText;
            descriptionRichTextBox.Location = new Point(12, 168);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.ReadOnly = true;
            descriptionRichTextBox.Size = new Size(810, 331);
            descriptionRichTextBox.TabIndex = 6;
            descriptionRichTextBox.Text = "";
            // 
            // descriptionInfoLable
            // 
            descriptionInfoLable.AutoSize = true;
            descriptionInfoLable.BackColor = SystemColors.Info;
            descriptionInfoLable.Font = new Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            descriptionInfoLable.ForeColor = SystemColors.InfoText;
            descriptionInfoLable.Location = new Point(321, 120);
            descriptionInfoLable.Name = "descriptionInfoLable";
            descriptionInfoLable.Size = new Size(156, 28);
            descriptionInfoLable.TabIndex = 7;
            descriptionInfoLable.Text = "Description:";
            // 
            // readDescriptionButton
            // 
            readDescriptionButton.BackColor = Color.DarkSeaGreen;
            readDescriptionButton.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            readDescriptionButton.ForeColor = SystemColors.InactiveCaptionText;
            readDescriptionButton.Location = new Point(12, 508);
            readDescriptionButton.Name = "readDescriptionButton";
            readDescriptionButton.Size = new Size(188, 47);
            readDescriptionButton.TabIndex = 8;
            readDescriptionButton.Text = "Read Description";
            readDescriptionButton.UseVisualStyleBackColor = false;
            readDescriptionButton.Click += ReadDescriptionButtonClick;
            // 
            // readAllInfoButton
            // 
            readAllInfoButton.BackColor = Color.DarkSeaGreen;
            readAllInfoButton.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            readAllInfoButton.ForeColor = SystemColors.InactiveCaptionText;
            readAllInfoButton.Location = new Point(634, 508);
            readAllInfoButton.Name = "readAllInfoButton";
            readAllInfoButton.Size = new Size(188, 47);
            readAllInfoButton.TabIndex = 9;
            readAllInfoButton.Text = "Read all info";
            readAllInfoButton.UseVisualStyleBackColor = false;
            // 
            // pauseReadingButton
            // 
            pauseReadingButton.BackColor = Color.DarkSeaGreen;
            pauseReadingButton.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            pauseReadingButton.ForeColor = SystemColors.InactiveCaptionText;
            pauseReadingButton.Location = new Point(310, 508);
            pauseReadingButton.Name = "pauseReadingButton";
            pauseReadingButton.Size = new Size(188, 47);
            pauseReadingButton.TabIndex = 10;
            pauseReadingButton.Text = "Pause Reading";
            pauseReadingButton.UseVisualStyleBackColor = false;
            pauseReadingButton.Click += PauseReadingButtonClick;
            // 
            // InfoToDoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(834, 564);
            Controls.Add(pauseReadingButton);
            Controls.Add(readAllInfoButton);
            Controls.Add(readDescriptionButton);
            Controls.Add(descriptionInfoLable);
            Controls.Add(descriptionRichTextBox);
            Controls.Add(endingDateLabel);
            Controls.Add(endingDateInfoLabel);
            Controls.Add(createDateLable);
            Controls.Add(createDateInfoLabel);
            Controls.Add(titleLabel);
            Controls.Add(infoTitleLabel);
            Name = "InfoToDoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfoToDoForm";
            Load += InfoToDoFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoTitleLabel;
        private Label titleLabel;
        private Label createDateLable;
        private Label createDateInfoLabel;
        private Label endingDateLabel;
        private Label endingDateInfoLabel;
        private RichTextBox descriptionRichTextBox;
        private Label descriptionInfoLable;
        private Button readDescriptionButton;
        private Button readAllInfoButton;
        private Button pauseReadingButton;
    }
}