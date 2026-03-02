namespace _17_winformapp;

public partial class UCList : UserControl
{
    public UCList()
    {
        InitializeComponent();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(textBox1.Text))
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }
    }

    private void deleteButton_Click(object sender, EventArgs e)
    {
        if (listBox1.Items.Count > 0)
                {
                    listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
                }
                else
                {
                    MessageBox.Show("List is empty");
                }
    }
}