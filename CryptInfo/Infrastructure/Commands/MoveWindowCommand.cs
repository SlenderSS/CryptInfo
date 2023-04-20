using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CryptInfo.Infrastructure.Commands
{
    internal class MoveWindowCommand : Command
    {
        public override bool CanExecute(object parameter)
         => true;
        public override void Execute(object parameter)
        {
            Application.Current.MainWindow.DragMove();
        }
    }
}
