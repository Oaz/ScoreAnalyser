using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace ScoreAnalyser.Views
{
    public class MusicItemView : UserControl
    {

        public MusicItemView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            var border = this.FindControl<Border>("DominantBorder");
            // border.PointerPressed += DoPress;
            //border.PointerReleased += DoRelease;
        }

        private void DoPress(object sender, PointerPressedEventArgs _)
        {
            // ((DominantViewModel) DataContext).SelectItem(sender);
        }
    }
}