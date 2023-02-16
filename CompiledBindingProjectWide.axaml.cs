using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace RiderXamlRepros;

public partial class CompiledBindingProjectWide : UserControl
{
    public CompiledBindingProjectWide()
    {
        InitializeComponent();
        DataContext = this;
    }
}