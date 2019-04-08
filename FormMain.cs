using System.Drawing;
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
      splitToolSelector.Panel2.Refresh();
    }

    private void splitToolSelector_Panel2_Paint(object sender, PaintEventArgs e)
    {
      var panel = (Panel)sender;
      var g = panel.CreateGraphics();
      var r = panel.ClientRectangle;
      var c = pictureBoxSelectedColor.BackColor;
      g.FillRectangle(new SolidBrush(c), r);
      g.DrawLine(new Pen(Color.FromArgb(0x0080ff - 16777216)), 10, 10, r.Width - 20, r.Height - 20);
    }
  }
}
