namespace WindowsFormExam.Forms;

partial class MainForm
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
        toDoesListBox = new ListBox();
        tittleLabel = new Label();
        deleteToDoButton = new Button();
        addToDoButton = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // toDoesListBox
        // 
        toDoesListBox.BackColor = Color.Linen;
        toDoesListBox.Cursor = Cursors.Hand;
        toDoesListBox.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        toDoesListBox.FormattingEnabled = true;
        toDoesListBox.ItemHeight = 25;
        toDoesListBox.Location = new Point(12, 76);
        toDoesListBox.Name = "toDoesListBox";
        toDoesListBox.ScrollAlwaysVisible = true;
        toDoesListBox.Size = new Size(461, 354);
        toDoesListBox.TabIndex = 0;
        // 
        // tittleLabel
        // 
        tittleLabel.AutoSize = true;
        tittleLabel.Font = new Font("Cascadia Code", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        tittleLabel.ForeColor = Color.GreenYellow;
        tittleLabel.Location = new Point(189, 19);
        tittleLabel.Name = "tittleLabel";
        tittleLabel.Size = new Size(95, 35);
        tittleLabel.TabIndex = 1;
        tittleLabel.Text = "TODO:";
        // 
        // deleteToDoButton
        // 
        deleteToDoButton.BackColor = Color.Navy;
        deleteToDoButton.Cursor = Cursors.Hand;
        deleteToDoButton.FlatAppearance.BorderSize = 3;
        deleteToDoButton.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        deleteToDoButton.ForeColor = Color.LawnGreen;
        deleteToDoButton.Location = new Point(12, 466);
        deleteToDoButton.Name = "deleteToDoButton";
        deleteToDoButton.Size = new Size(142, 50);
        deleteToDoButton.TabIndex = 2;
        deleteToDoButton.Text = "Delete TODO";
        deleteToDoButton.UseVisualStyleBackColor = false;
        // 
        // addToDoButton
        // 
        addToDoButton.BackColor = Color.OliveDrab;
        addToDoButton.BackgroundImageLayout = ImageLayout.Center;
        addToDoButton.Cursor = Cursors.Hand;
        addToDoButton.FlatAppearance.BorderSize = 3;
        addToDoButton.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        addToDoButton.ForeColor = Color.GreenYellow;
        addToDoButton.Location = new Point(331, 466);
        addToDoButton.Name = "addToDoButton";
        addToDoButton.Size = new Size(142, 50);
        addToDoButton.TabIndex = 3;
        addToDoButton.Text = "Add TODO";
        addToDoButton.UseVisualStyleBackColor = false;
        addToDoButton.Click += AddToDoButtonClick;
        // 
        // button1
        // 
        button1.BackColor = Color.Chartreuse;
        button1.Cursor = Cursors.Hand;
        button1.FlatAppearance.BorderSize = 3;
        button1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        button1.ForeColor = SystemColors.MenuText;
        button1.Location = new Point(172, 466);
        button1.Name = "button1";
        button1.Size = new Size(142, 50);
        button1.TabIndex = 4;
        button1.Text = "Edit TODO";
        button1.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Teal;
        ClientSize = new Size(484, 539);
        Controls.Add(button1);
        Controls.Add(addToDoButton);
        Controls.Add(deleteToDoButton);
        Controls.Add(tittleLabel);
        Controls.Add(toDoesListBox);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ToDo";
        Load += MainFormLoad;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox toDoesListBox;
    private Label tittleLabel;
    private Button deleteToDoButton;
    private Button addToDoButton;
    private Button button1;
}
