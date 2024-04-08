namespace WindowsFormExam.Forms;

partial class AddToDoForm
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
        newTODOTitleTextBox = new TextBox();
        newTODOTitleLabel = new Label();
        newTODODescriptionLabel = new Label();
        newTODODescriptionTextBox = new TextBox();
        newTODOEndingDateTimePicker = new DateTimePicker();
        newTODOEndingDateLabel = new Label();
        SaveButton = new Button();
        SuspendLayout();
        // 
        // newTODOTitleTextBox
        // 
        newTODOTitleTextBox.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        newTODOTitleTextBox.Location = new Point(12, 67);
        newTODOTitleTextBox.Name = "newTODOTitleTextBox";
        newTODOTitleTextBox.Size = new Size(426, 30);
        newTODOTitleTextBox.TabIndex = 0;
        // 
        // newTODOTitleLabel
        // 
        newTODOTitleLabel.AutoSize = true;
        newTODOTitleLabel.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        newTODOTitleLabel.ForeColor = Color.Yellow;
        newTODOTitleLabel.Location = new Point(12, 30);
        newTODOTitleLabel.Name = "newTODOTitleLabel";
        newTODOTitleLabel.Size = new Size(78, 25);
        newTODOTitleLabel.TabIndex = 1;
        newTODOTitleLabel.Text = "Title:";
        // 
        // newTODODescriptionLabel
        // 
        newTODODescriptionLabel.AutoSize = true;
        newTODODescriptionLabel.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        newTODODescriptionLabel.ForeColor = Color.Yellow;
        newTODODescriptionLabel.Location = new Point(12, 116);
        newTODODescriptionLabel.Name = "newTODODescriptionLabel";
        newTODODescriptionLabel.Size = new Size(144, 25);
        newTODODescriptionLabel.TabIndex = 3;
        newTODODescriptionLabel.Text = "Description:";
        // 
        // newTODODescriptionTextBox
        // 
        newTODODescriptionTextBox.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        newTODODescriptionTextBox.Location = new Point(12, 153);
        newTODODescriptionTextBox.Name = "newTODODescriptionTextBox";
        newTODODescriptionTextBox.Size = new Size(426, 30);
        newTODODescriptionTextBox.TabIndex = 2;
        // 
        // newTODOEndingDateTimePicker
        // 
        newTODOEndingDateTimePicker.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
        newTODOEndingDateTimePicker.CalendarTitleForeColor = Color.PaleTurquoise;
        newTODOEndingDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        newTODOEndingDateTimePicker.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        newTODOEndingDateTimePicker.Format = DateTimePickerFormat.Custom;
        newTODOEndingDateTimePicker.Location = new Point(168, 212);
        newTODOEndingDateTimePicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        newTODOEndingDateTimePicker.Name = "newTODOEndingDateTimePicker";
        newTODOEndingDateTimePicker.ShowUpDown = true;
        newTODOEndingDateTimePicker.Size = new Size(270, 30);
        newTODOEndingDateTimePicker.TabIndex = 4;
        newTODOEndingDateTimePicker.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        // 
        // newTODOEndingDateLabel
        // 
        newTODOEndingDateLabel.AutoSize = true;
        newTODOEndingDateLabel.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        newTODOEndingDateLabel.ForeColor = Color.Yellow;
        newTODOEndingDateLabel.Location = new Point(12, 212);
        newTODOEndingDateLabel.Name = "newTODOEndingDateLabel";
        newTODOEndingDateLabel.Size = new Size(133, 25);
        newTODOEndingDateLabel.TabIndex = 5;
        newTODOEndingDateLabel.Text = "Execute to:";
        // 
        // SaveButton
        // 
        SaveButton.BackColor = Color.LawnGreen;
        SaveButton.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        SaveButton.ForeColor = Color.DarkGreen;
        SaveButton.Location = new Point(145, 275);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(129, 50);
        SaveButton.TabIndex = 6;
        SaveButton.Text = "Save";
        SaveButton.UseVisualStyleBackColor = false;
        SaveButton.Click += SaveBtnClick;
        // 
        // AddToDoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.SteelBlue;
        ClientSize = new Size(450, 360);
        Controls.Add(SaveButton);
        Controls.Add(newTODOEndingDateLabel);
        Controls.Add(newTODOEndingDateTimePicker);
        Controls.Add(newTODODescriptionLabel);
        Controls.Add(newTODODescriptionTextBox);
        Controls.Add(newTODOTitleLabel);
        Controls.Add(newTODOTitleTextBox);
        Name = "AddToDoForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "New TODO";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox newTODOTitleTextBox;
    private Label newTODOTitleLabel;
    private Label newTODODescriptionLabel;
    private TextBox newTODODescriptionTextBox;
    private DateTimePicker newTODOEndingDateTimePicker;
    private Label newTODOEndingDateLabel;
    private Button SaveButton;
}