﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Laboratorio10.viewModels;

namespace Laboratorio10.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Operaciones : ContentPage
	{
		public Operaciones ()
		{
            InitializeComponent();
            this.BindingContext = new OperacionesViewModel();
        }
    }
}