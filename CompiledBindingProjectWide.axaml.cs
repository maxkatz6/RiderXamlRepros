using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RiderXamlRepros;

public partial class CompiledBindingProjectWide : UserControl
{
    public CompiledBindingProjectWide()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}