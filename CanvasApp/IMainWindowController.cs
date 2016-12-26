using System.Collections.Generic;
using CanvasApp.Model;

namespace CanvasApp
{
    interface IMainWindowController
    {
        List<CommandDescriptor> GetMenuCommands();

        List<ColorDescription> GetColors();

        List<LineWidthDescription> GetLineDescriptions();
    }
}