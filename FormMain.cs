using System.Windows.Forms;

namespace ngPiPa
{
  public sealed partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void buttonColor_Select_Click(object sender, System.EventArgs e)
    {
      pictureBoxSelectedColor.BackColor = ((Button)sender).BackColor;
    }
  }
}
