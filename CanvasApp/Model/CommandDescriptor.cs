﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CanvasApp.Model
{
    public class CommandDescriptor
    {
        public string Name { get; set; }

        public ICommand Command { get; set; }
    }
}
