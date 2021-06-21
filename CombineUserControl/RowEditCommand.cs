﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CombineUserControl
{
    public class RowEditCommand : ICommand
    {
        UserControlAViewModel vm;
        public event EventHandler CanExecuteChanged;

        public RowEditCommand(UserControlAViewModel viewModel)
        {
            vm = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string content = parameter as string;
            int count = vm.TableData.Count();
            Console.WriteLine($"content = {content}");

            if (content == "+")
            {
                TableRow tableRow = new TableRow() { Id = count + 1 };
                vm.TableData.Add(tableRow);
            }
            else
            {
                vm.TableData.RemoveAt(count - 1);
            }
        }
    }

}
