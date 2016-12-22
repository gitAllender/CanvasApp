using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CanvasApp.Controls
{
    public class CanvasControl: Canvas
    {
        private Polyline PaintedPath { get; set; }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            PaintedPath = new Polyline();
            PaintedPath.Stroke = Brushes.Black;
            PaintedPath.StrokeThickness = 1;
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
