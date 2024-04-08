namespace WindowsFormExam.Forms;

partial class EditToDoForm
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
        editTODOTitleTextBox = new TextBox();
        editTODOTitleLabel = new Label();
        editTODODescriptionLabel = new Label();
        editTODODescriptionTextBox = new TextBox();
        editTODOEndingDateTimePicker = new DateTimePicker();
        editTODOEndingDateLabel = new Label();
        UpdateButton = new Button();
        SuspendLayout();
        // 
        // editTODOTitleTextBox
        // 
        editTODOTitleTextBox.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        editTODOTitleTextBox.Location = new Point(12, 67);
        editTODOTitleTextBox.Name = "editTODOTitleTextBox";
        editTODOTitleTextBox.Size = new Size(426, 30);
        editTODOTitleTextBox.TabIndex = 0;
        // 
        // editTODOTitleLabel
        // 
        editTODOTitleLabel.AutoSize = true;
        editTODOTitleLabel.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        editTODOTitleLabel.ForeColor = Color.Yellow;
        editTODOTitleLabel.Location = new Point(12, 30);
        editTODOTitleLabel.Name = "editTODOTitleLabel";
        editTODOTitleLabel.Size = new Size(122, 25);
        editTODOTitleLabel.TabIndex = 1;
        editTODOTitleLabel.Text = "New Title:";
        // 
        // editTODODescriptionLabel
        // 
        editTODODescriptionLabel.AutoSize = true;
        editTODODescriptionLabel.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        editTODODescriptionLabel.ForeColor = Color.Yellow;
        editTODODescriptionLabel.Location = new Point(12, 116);
        editTODODescriptionLabel.Name = "editTODODescriptionLabel";
        editTODODescriptionLabel.Size = new Size(188, 25);
        editTODODescriptionLabel.TabIndex = 3;
        editTODODescriptionLabel.Text = "New Description:";
        // 
        // editTODODescriptionTextBox
        // 
        editTODODescriptionTextBox.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        editTODODescriptionTextBox.Location = new Point(12, 153);
        editTODODescriptionTextBox.Name = "editTODODescriptionTextBox";
        editTODODescriptionTextBox.Size = new Size(426, 30);
        editTODODescriptionTextBox.TabIndex = 2;
        // 
        // editTODOEndingDateTimePicker
        // 
        editTODOEndingDateTimePicker.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
        editTODOEndingDateTimePicker.CalendarTitleForeColor = Color.PaleTurquoise;
        editTODOEndingDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        editTODOEndingDateTimePicker.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        editTODOEndingDateTimePicker.Format = DateTimePickerFormat.Custom;
        editTODOEndingDateTimePicker.Location = new Point(168, 212);
        editTODOEndingDateTimePicker.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        editTODOEndingDateTimePicker.Name = "editTODOEndingDateTimePicker";
        editTODOEndingDateTimePicker.ShowUpDown = true;
        editTODOEndingDateTimePicker.Size = new Size(270, 30);
        editTODOEndingDateTimePicker.TabIndex = 4;
        editTODOEndingDateTimePicker.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        // 
        // editTODOEndingDateLabel
        // 
        editTODOEndingDateLabel.AutoSize = true;
        editTODOEndingDateLabel.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        editTODOEndingDateLabel.ForeColor = Color.Yellow;
        editTODOEndingDateLabel.Location = new Point(12, 212);
        editTODOEndingDateLabel.Name = "editTODOEndingDateLabel";
        editTODOEndingDateLabel.Size = new Size(133, 25);
        editTODOEndingDateLabel.TabIndex = 5;
        editTODOEndingDateLabel.Text = "Execute to:";
        // 
        // UpdateButton
        // 
        UpdateButton.BackColor = Color.LawnGreen;
        UpdateButton.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        UpdateButton.ForeColor = Color.DarkGreen;
        UpdateButton.Location = new Point(145, 275);
        UpdateButton.Name = "UpdateButton";
        UpdateButton.Size = new Size(129, 50);
        UpdateButton.TabIndex = 6;
        UpdateButton.Text = "Update";
        UpdateButton.UseVisualStyleBackColor = false;
        UpdateButton.Click += UpdateBtnClick;
        // 
        // EditToDoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.SteelBlue;
        ClientSize = new Size(450, 360);
        Controls.Add(editTODOTitleTextBox);
        Controls.Add(UpdateButton);
        Controls.Add(editTODOTitleLabel);
        Controls.Add(editTODODescriptionLabel);
        Controls.Add(editTODODescriptionTextBox);
        Controls.Add(editTODOEndingDateTimePicker);
        Controls.Add(editTODOEndingDateLabel);
        Name = "EditToDoForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "EditToDoForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox editTODOTitleTextBox;
    private Label editTODOTitleLabel;
    private Label editTODODescriptionLabel;
    private TextBox editTODODescriptionTextBox;
    private DateTimePicker editTODOEndingDateTimePicker;
    private Label editTODOEndingDateLabel;
    private Button UpdateButton;
}