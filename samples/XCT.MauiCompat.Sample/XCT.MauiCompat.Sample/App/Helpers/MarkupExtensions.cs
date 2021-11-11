﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace Xamarin.CommunityToolkit.Sample
{
	public static class MarkupExtensions
	{
		public static TBindable Rainbow<TBindable>(this TBindable bindable) where TBindable : BindableObject
		{
			return bindable;
		}

		public static TVisualElement Background<TVisualElement>(this TVisualElement visualElement, Color color) where TVisualElement : VisualElement
		{
			visualElement.BackgroundColor = color;
			return visualElement;
		}

		public static TStackLayout Horizontal<TStackLayout>(this TStackLayout stackLayout) where TStackLayout : StackLayout
		{
			stackLayout.Orientation = StackOrientation.Horizontal;
			return stackLayout;
		}

		public static TStackLayout Vertical<TStackLayout>(this TStackLayout stackLayout) where TStackLayout : StackLayout
		{
			stackLayout.Orientation = StackOrientation.Vertical;
			return stackLayout;
		}
	}
}