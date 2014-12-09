using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rhino.UI;

namespace SampleCsDockBar
{
  public partial class SampleCsDockBarUserControl : UserControl
  {
    public SampleCsDockBarUserControl()
    {
      InitializeComponent();
    }

    private void btnPanel0_Click(object sender, EventArgs e)
    {
      var panel_id = SampleCsPanel0UserControl.PanelId;
      var visible = Panels.IsPanelVisible(panel_id);
      if (!visible)
        Panels.OpenPanel(panel_id);
    }

    private void btnPanel1_Click(object sender, EventArgs e)
    {
      var panel_id = SampleCsPanel1UserControl.PanelId;
      var visible = Panels.IsPanelVisible(panel_id);
      if (!visible)
        Panels.OpenPanel(panel_id);
    }
  }
}
