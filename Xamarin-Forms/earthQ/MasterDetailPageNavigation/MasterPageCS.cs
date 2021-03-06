﻿using System.Collections.Generic;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class MasterPageCS : ContentPage
	{
		public ListView ListView { get { return listView; } }

		ListView listView;

		public MasterPageCS ()
		{
			var masterPageItems = new List<MasterPageItem> ();
			masterPageItems.Add (new MasterPageItem {
				Title = "Home",
				IconSource = "home.png",
				TargetType = typeof(HomePageCS)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Eartquake",
				IconSource = "earth.png",
				TargetType = typeof(earthQPageCS)
			});
			masterPageItems.Add (new MasterPageItem {
				Title = "Setting",
				IconSource = "setting.png",
				TargetType = typeof(SettingPageCS)
			});

			listView = new ListView {
				ItemsSource = masterPageItems,
				ItemTemplate = new DataTemplate (() => {
					var imageCell = new ImageCell ();
					imageCell.SetBinding (TextCell.TextProperty, "Title");
					imageCell.SetBinding (ImageCell.ImageSourceProperty, "IconSource");
					return imageCell;
				}),
				VerticalOptions = LayoutOptions.FillAndExpand,
				SeparatorVisibility = SeparatorVisibility.None
			};

			Padding = new Thickness (0, 40, 0, 0);
			Icon = "hamburger.png";
			Title = "Personal Organiser";
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					listView
				}	
			};
		}
	}
}
