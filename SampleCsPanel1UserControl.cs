using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SampleCsDockBar
{
  /// <summary>
  /// This is the user control that is buried in the tabbed, docking panel.
  /// </summary>
  [Guid("D8F4B06F-89BE-48A8-A5AA-10C7D0ED19B4")]
  public partial class SampleCsPanel1UserControl : UserControl
  {
    public SampleCsPanel1UserControl()
    {
      InitializeComponent();

      // Set the user control property on our plug-in
      SampleCsDockBarPlugIn.Instance.Panel1 = this;

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
      SampleCsDockBarPlugIn.Instance.Panel1 = null;
    }

    /// <summary>
    /// Returns the ID of this panel.
    /// </summary>
    public static System.Guid PanelId
    {
      get
      {
        return typeof(SampleCsPanel1UserControl).GUID;
      }
    }
  }
}
