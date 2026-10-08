using System.Globalization;
using WinFormMarkup.Extensions;

namespace BasicApp;

public class MainWindow : Form
{
    private readonly ToolStripStatusLabel _secondTextLabel;
    private readonly ToolStripStatusLabel _statusText;
    private int _counter;

    public MainWindow()
    {
        this.Text("Main Window")
            .Localize(out var resources)
            .Icon(new Icon(GetType(), "AppIcon.ico"))
            .MinimumSize(800, 600)
            .StartPosition(FormStartPosition.CenterScreen)
            .MainMenuStrip(
                new ToolStripMenuItem("&File")
                    .Localize(resources, "fileMenu")
                    .DropDownItems(
                        new ToolStripMenuItem("&New")
                            .Localize(resources, "newMenuItem")
                            .Keys(Keys.Control | Keys.N)
                            .Clicked(_ => CreateFile()),
                        new ToolStripMenuItem("&Open")
                            .Localize(resources, "openMenuItem")
                            .Keys(Keys.Control | Keys.O)
                            .Clicked(_ => OpenFile()),
                        new ToolStripMenuItem("&Save")
                            .Localize(resources, "saveMenuItem")
                            .Keys(Keys.Control | Keys.S)
                            .Clicked(_ => SaveFile()),
                        new ToolStripSeparator(),
                        new ToolStripMenuItem("E&xit")
                            .Localize(resources, "exitMenuItem")
                            .Keys(Keys.Alt | Keys.F4)
                            .Clicked(_ => Application.Exit())
                    ))
            .StatusStrip(
                _statusText = new ToolStripStatusLabel("Ready")
                    .Localize(resources, "statusText")
                    .Alignment(ToolStripItemAlignment.Right)
                    .Also(label =>
                    {
                        label.TextChanged += (s, e) => _secondTextLabel.Text($"Total Changes {++_counter}");
                        label.Padding = new Padding(2, 0, 6, 0);
                        label.Clicked(_ => label.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture));
                    }),
                _secondTextLabel = new ToolStripStatusLabel()
                    .Localize(resources, "changeCountText")
            )
            .Controls(
                new SplitContainer()
                    .Dock(DockStyle.Fill)
                    .Panel1(
                        new TreeView()
                            .Dock(DockStyle.Fill)
                            .Nodes(
                                new TreeNode("Node 1")
                                    .Nodes(
                                        new TreeNode("Node 1.1")
                                            .Nodes(
                                                new TreeNode("Node 1.1.1")
                                            ),
                                        new TreeNode("Node 1.2")
                                    ),
                                new TreeNode("Node 2")
                                    .Nodes(
                                        new TreeNode("Node 2.1")
                                    )
                            )
                            .OnAfterSelect(node => _statusText.Text($"Selected: {node.Text}"))
                    )
                    .Panel2(
                        new TextBox()
                            .Localize(resources, "editor")
                            .Multiline(true)
                            .Dock(DockStyle.Fill)
                            .Text("TextBox")
                            .OnTextChanged(tb => _statusText.Text($"TextChanged: Length = {tb.Text.Length}"))
                    )
                    .SplitterDistance(50)
            )
            .Show();
    }

    private void CreateFile()
    {
        _statusText.Text("Creating");
    }

    private void OpenFile()
    {
        _statusText.Text("opening");
    }

    private void SaveFile()
    {
        _statusText.Text("Saving");
    }
}
