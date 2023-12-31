﻿using hotel_MVVM.ViewModels;
using Interfaces.Services;
using Microsoft.Win32;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Path = System.IO.Path;

namespace hotel_MVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для AddAdminWindow.xaml
    /// </summary>
    public partial class AddAdminWindow : Window
    {
        private AddRoomViewModel viewModel;
        IRoomService roomService = App.Kernel.Get<IRoomService>();

        public AddAdminWindow()
        {
            InitializeComponent();
            viewModel = new AddRoomViewModel(this, roomService);
            DataContext = viewModel; 
        }
    }
}
