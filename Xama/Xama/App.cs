﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xama.Pages;
using Xamarin.Forms;

namespace Xama {
	public class App : Application {
		public App() {
			// The root page of your application
			MainPage = new NavigationPage(new HomePage());
		}

		protected override void OnStart() {
			// Handle when your app starts
		}

		protected override void OnSleep() {
			// Handle when your app sleeps
		}

		protected override void OnResume() {
			// Handle when your app resumes
		}
	}
}
