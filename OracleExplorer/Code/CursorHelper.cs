using System;
using System.Windows.Forms;
/// <summary>
/// A helper object that allows to set and restore the cursor on a control easily.
/// From:
/// http://jelle.druyts.net/2003/11/12/Cursors.aspx
/// </summary>
/// <example>
/// This will create a WaitCursor on a control and restore it to the previous state after the "using" block:
/// <code>
///   using( new CursorHelper( this ) )
///   {
///      // time consuming code...
///   }
/// </code>
/// </example>
public class CursorHelper : IDisposable
{
  /// <summary>
  /// The previous cursor of the associated control.
  /// </summary>
  private Cursor m_OldCursor;
  /// <summary>
  /// The control of which to set the cursor.
  /// </summary>
  private Control m_Control;
  /// <summary>
  /// Creates a new CursorHelper for the given control. Sets the current cursor to
  /// a WaitCursor and restores the previous cursor on Dispose or destruction.
  /// </summary>
  /// <param name="ctrl">The control of which to set the cursor.</param>
  public CursorHelper(Control ctrl)
  {
    m_OldCursor = ctrl.Cursor;
    m_Control = ctrl;
    ctrl.Cursor = Cursors.WaitCursor;
  }
  /// <summary>
  /// Creates a new CursorHelper for the given control. Sets the current cursor to
  /// the given cursor and restores the previous cursor on Dispose or destruction.
  /// </summary>
  /// <param name="ctrl">The control of which to set the cursor.</param>
  /// <param name="newCursor">The new cursor to set.</param>
  public CursorHelper(Control ctrl, Cursor newCursor)
  {
    m_OldCursor = ctrl.Cursor;
    m_Control = ctrl;
    ctrl.Cursor = newCursor;
  }
  /// <summary>
  /// Restores the cursor on the associated control.
  /// </summary>
  public void Dispose()
  {
    m_Control.Cursor = m_OldCursor;
    GC.SuppressFinalize(this);
  }
  /// <summary>
  /// Restores the cursor on the associated control.
  /// </summary>
  ~CursorHelper()
  {
    Dispose();
  }
}
