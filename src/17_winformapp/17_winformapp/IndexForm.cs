namespace _17_winformapp;

public partial class IndexForm : Form
{
    public IndexForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        label1.Text = "Hello World";
        label1.BackColor = Color.PaleGreen;
    }
}