using CanvasApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace CanvasApp
{
    class MainWindowController : IMainWindowController
    {
        public List<ColorDescription> GetColors()
        {
            return new List<ColorDescription>()
            {
                new ColorDescription() { Color = Colors.Red, Name="Red" },
                new ColorDescription() { Color = Colors.Magenta, Name="Magenta" },
                new ColorDescription() { Color = Colors.Orange, Name="Orange" },
                new ColorDescription() { Color = Colors.LimeGreen, Name="LimeGreen" },
                new ColorDescription() { Color = Colors.Cyan, Name="Cyan" }
            };
       }

        public List<LineWidthDescription> GetLineDescriptions()
        {
            return new List<LineWidthDescription>()
            {
                new LineWidthDescription() { Name="Thin 1x", Width = 1 },
                new LineWidthDescription() { Name="Bold 5x", Width = 5 },
                new LineWidthDescription() { Name="Extra Bold 10x", Width = 10 },
            };
        }

        public List<CommandDescriptor> GetMenuCommands()
        {
            return new List<CommandDescriptor>()
            {
                new CommandDescriptor() { Name = "Menu Item 1" },
                new CommandDescriptor () { Name = "Menu Item 2" },
                new CommandDescriptor() { Name = "Editor", Command = null /*TODO init screenshot*/ }
            };
        } 
    }
}
