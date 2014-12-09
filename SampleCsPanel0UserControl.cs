using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SampleCsDockBar
{
  /// <summary>
  /// This is the user control that is buried in the tabbed, docking panel.
  /// </summary>
  [Guid("59443C03-4CB8-423A-9E3C-2030AA279612")]
  public partial class SampleCsPanel0UserControl : UserControl
  {
    public SampleCsPanel0UserControl()
    {
      InitializeComponent();

      // Set the user control property on our plug-in
      SampleCsDockBarPlugIn.Instance.Panel0 = this;

      // Create a visible changed event handler
      this.VisibleChanged += new EventHandler(OnVisibleChanged);

      // Create a dispose event handler
      this.Disposed += new EventHandler(OnDisposed);
    }

    /// <summary>
    /// Occurs when the System.Windows.Forms.Control.Visible 
    /// property value changes.
    /// </summary>
    void OnVisibleChanged(object sender, EventArgs e)
    {
      // TODO...
    }

    /// <summary>
    /// Occurs when the component is disposed by a call to the
    /// System.ComponentModel.Component.Dispose() method.
    /// </summary>
    void OnDisposed(object sender, EventArgs e)
    {
      // Clear the user control property on our plug-in
      SampleCsDockBarPlugIn.Instance.Panel0 = null;
    }

    /// <summary>
    /// Returns the ID of this panel.
    /// </summary>
    public static System.Guid PanelId
    {
      get
      {
        return typeof(SampleCsPanel0UserControl).GUID;
      }
    }
  }
}
