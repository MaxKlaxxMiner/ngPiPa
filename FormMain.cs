using System;
using System.Drawing;
using System.Windows.Forms;

namespace ngPiPa
{
  public sealed partial class FormMain : Form
  {
    int[] pix = null;

    public FormMain()
    {
      InitializeComponent();
      var rnd = new Random();
      pix = new int[2048 * 2048];
      for (int i = 0; i < pix.Length; i++) pix[i] = (rnd.Next() & 0xffffff) - 16777216;
    }

    private void buttonColor_Select_Click(object sender, EventArgs e)
    {
      pictureBoxSelectedColor.BackColor = ((Button)sender).BackColor;
      splitToolSelector.Panel2.Refresh();
    }

    int cellSize = 16;

    private void splitToolSelector_Panel2_Paint(object sender, PaintEventArgs e)
    {
      var panel = (Panel)sender;
      var g = e.Graphics;
      int startX = 0;
      int startY = 0;
      int endX = panel.Width;
      int endY = panel.Height;

    }
  }
}
