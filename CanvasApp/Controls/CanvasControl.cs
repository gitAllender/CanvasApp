using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CanvasApp.Controls
{
    public class CanvasControl: Canvas
    {
        public int PenWidth
        {
            get { return (int)GetValue(PenWidthProperty); }
            set { SetValue(PenWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LineWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PenWidthProperty =
            DependencyProperty.Register("PenWidth", typeof(int), typeof(CanvasControl), new PropertyMetadata(1));

        public Color PenColor
        {
            get { return (Color)GetValue(PenColorProperty); }
            set { SetValue(PenColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PenColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PenColorProperty =
            DependencyProperty.Register("PenColor", typeof(Color), typeof(CanvasControl), new PropertyMetadata(Colors.Black));
        
        private Polyline PaintedPath { get; set; }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            PaintedPath = new Polyline();
            PaintedPath.Stroke = new SolidColorBrush(PenColor);
            PaintedPath.StrokeThickness = PenWidth;
            Children.Add(PaintedPath);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if ( e.LeftButton == MouseButtonState.Pressed )
            {
                Point aCurrentPosition = e.GetPosition(this);
                PaintedPath.Points.Add(e.GetPosition(this));
            }
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);
        }

        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
        }
    }
}
