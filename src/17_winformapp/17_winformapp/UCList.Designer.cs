using System.ComponentModel;

namespace _17_winformapp;

partial class UCList
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBox1 = new System.Windows.Forms.TextBox();
        addButton = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        deleteButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(15, 14);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(420, 23);
        textBox1.TabIndex = 0;
        textBox1.Text = "Insert something..";
        // 
        // addButton
        // 
        addButton.Location = new System.Drawing.Point(15, 52);
        addButton.Name = "addButton";
        addButton.Size = new System.Drawing.Size(124, 30);
        addButton.TabIndex = 1;
        addButton.Text = "add";
        addButton.UseVisualStyleBackColor = true;
        addButton.Click += addButton_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(145, 52);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(290, 274);
        listBox1.TabIndex = 2;
        // 
        // deleteButton
        // 
        deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
        deleteButton.ForeColor = System.Drawing.SystemColors.Info;
        deleteButton.Location = new System.Drawing.Point(15, 88);
        deleteButton.Name = "deleteButton";
        deleteButton.Size = new System.Drawing.Size(124, 30);
        deleteButton.TabIndex = 3;
        deleteButton.Text = "delete last";
        deleteButton.UseVisualStyleBackColor = false;
        deleteButton.Click += deleteButton_Click;
        // 
        // UCList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(deleteButton);
        Controls.Add(listBox1);
        Controls.Add(addButton);
        Controls.Add(textBox1);
        Size = new System.Drawing.Size(466, 349);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button deleteButton;

    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.Button addButton;

    private System.Windows.Forms.TextBox textBox1;

    #endregion
}