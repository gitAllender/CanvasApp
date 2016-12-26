using CanvasApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace CanvasApp
{
    class MainWindowViewModel : ViewModelBase
    {
        public void InstallViewController(IMainWindowController theController )
        {
            MenuCommands = new ObservableCollection<CommandDescriptor>(theController.GetMenuCommands());

            Colors = new ObservableCollection<ColorDescription>(theController.GetColors());

            LineWidths = new ObservableCollection<LineWidthDescription>(theController.GetLineDescriptions());
        }

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

        private ICommand m_ChangePaintColorCmd;

        public ICommand ChangePaintColorCmd
        {
            get { return m_ChangePaintColorCmd; }
            set
            {
                m_ChangePaintColorCmd = value;
                RaisePropertyChanged();
            }
        }

        private ICommand m_ChangePaintThickCmd;

        public ICommand ChangePaintThickCmd
        {
            get { return m_ChangePaintThickCmd; }
            set
            {
                m_ChangePaintThickCmd = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<CommandDescriptor> MenuCommands
        {
            get
            {
                return m_MenuCommands;
            }

            set
            {
                m_MenuCommands = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<LineWidthDescription> LineWidths
        {
            get
            {
                return m_LineWidths;
            }

            set
            {
                m_LineWidths = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<ColorDescription> Colors
        {
            get
            {
                return m_Colors;
            }

            set
            {
                m_Colors = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<CommandDescriptor> m_MenuCommands;
        private ObservableCollection<ColorDescription> m_Colors;
        private ObservableCollection<LineWidthDescription> m_LineWidths;
    }
}
