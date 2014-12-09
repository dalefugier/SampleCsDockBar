using System.Drawing;
using Rhino.PlugIns;
using Rhino.UI;
using RMA.UI;

namespace SampleCsDockBar
{
  /// <summary>
  /// SampleCsDockBarPlugIn plug-in class.
  /// DO NOT create instances of this class yourself. It is the
  /// responsibility of Rhino to create an instance of this class.
  ///</summary>
  public class SampleCsDockBarPlugIn : PlugIn
  {
    // Public constructor
    public SampleCsDockBarPlugIn()
    {
      Instance = this;
    }

    /// <summary>
    /// Returns the one and only instance of the SampleCsDockBarPlugIn plug-in.
    /// </summary>
    public static SampleCsDockBarPlugIn Instance
    {
      get;
      private set;
    }

    /// <summary>
    /// Returns the one and only instance of the SampleCsDockBarDialog panel
    /// </summary>
    public SampleCsDockBarDialog DockBarDialog
    {
      get;
      private set;
    }

    /// <summary>
    /// Returns the one and only instance of the SampleCsDockBarUserControl panel
    /// </summary>
    public SampleCsDockBarUserControl DockBarUserControl
    {
      get;
      private set;
    }

    /// <summary>
    /// Returns the one and only instance of the SampleCsPanel0UserControl panel
    /// </summary>
    public SampleCsPanel0UserControl Panel0
    {
      get;
      set;
    }

    /// <summary>
    /// Returns the one and only instance of the SampleCsPanel1UserControl panel
    /// </summary>
    public SampleCsPanel1UserControl Panel1
    {
      get;
      set;
    }

    /// <summary>
    /// OnLoad override.
    /// Called when the plug-in is being loaded.
    /// </summary>
    protected override LoadReturnCode OnLoad(ref string errorMessage)
    {
      // Create our user control
      DockBarUserControl = new SampleCsDockBarUserControl();

      // Create our dock bar
      DockBarDialog = new SampleCsDockBarDialog(SampleCsDockBarDialog.DockBarId(), "Sample", DockBarUserControl);
      
      // Register our dock bar
      MRhinoDockBarManager.CreateRhinoDockBar(
        this,
        DockBarDialog, 
        false, // Don't show yet...
        MRhinoUiDockBar.DockLocation.top,
        MRhinoUiDockBar.DockStyle.top, 
        new Point(0, 0)
        );

      DockBarDialog.Initialize();
      MRhinoDockBarManager.ShowDockBar(SampleCsDockBarDialog.DockBarId(), true, false);

      // Register panel 0
      var panel0_type = typeof(SampleCsPanel0UserControl);
      Panels.RegisterPanel(this, panel0_type, "Panel 0", SystemIcons.Question);

      // Register panel 1
      var panel1_type = typeof(SampleCsPanel1UserControl);
      Panels.RegisterPanel(this, panel1_type, "Panel 1", SystemIcons.Exclamation);

      return LoadReturnCode.Success;
    }
  }
}