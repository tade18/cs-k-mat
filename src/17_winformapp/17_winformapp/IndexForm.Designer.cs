using System.ComponentModel;

namespace _17_winformapp;

partial class IndexForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        userControl11 = new _17_winformapp.UCList();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.SystemColors.Info;
        label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        label1.Location = new System.Drawing.Point(18, 31);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(139, 82);
        label1.TabIndex = 0;
        label1.Text = "\r\n";
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(18, 125);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(139, 32);
        button1.TabIndex = 1;
        button1.Text = "Click here!";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // userControl11
        // 
        userControl11.Location = new System.Drawing.Point(163, 18);
        userControl11.Name = "userControl11";
        userControl11.Size = new System.Drawing.Size(569, 357);
        userControl11.TabIndex = 2;
        // 
        // IndexForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 517);
        Controls.Add(userControl11);
        Controls.Add(button1);
        Controls.Add(label1);
        Text = "IndexForm";
        ResumeLayout(false);
    }

    private _17_winformapp.UCList userControl11;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label1;

    #endregion
}