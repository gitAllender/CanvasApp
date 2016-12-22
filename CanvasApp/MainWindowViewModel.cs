using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CanvasApp
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private BitmapImage m_SketcherBackground;

        public BitmapImage SketcherBackground
        {
            get { return m_SketcherBackground; }
            set
            {
                m_SketcherBackground = value;
                RaisePropertyChanged();
            }
        }






















        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
