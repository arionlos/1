﻿using BrickController2.UI.Services.Background;
using BrickController2.UI.ViewModels;

namespace BrickController2.UI.Pages
{
	public partial class CreationListPage
	{
		public CreationListPage(PageViewModelBase vm, IBackgroundService backgroundService) : base(backgroundService)
        {
			InitializeComponent();
		    BindingContext = vm;
		}
	}
}