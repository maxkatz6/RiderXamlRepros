using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RiderXamlRepros;

public partial class InheritDataTypeFromItems : UserControl
{
    public InheritDataTypeFromItems()
    {
        InitializeComponent();
        DataContext = this;
    }

    public IEnumerable<Inner> Items { get; } = new[]
    {
        new Inner { Text = "1" },
        new Inner { Text = "2" }
    };
}
public class Inner
{
    public string Text { get; init; }
}