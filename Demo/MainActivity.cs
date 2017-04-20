using Android.App;
using Android.Widget;
using Android.OS;
using Luseen.Spacenavigation;
using Android.Support.V7.App;

namespace Demo
{
	[Activity(Label = "Demo", Theme="@style/MyTheme", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : AppCompatActivity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
            
			SpaceNavigationView spaceNavigationView = FindViewById<SpaceNavigationView>(Resource.Id.space);
			spaceNavigationView.InitWithSaveInstanceState(savedInstanceState);
			spaceNavigationView.AddSpaceItem(new SpaceItem("HOME", Resource.Mipmap.Icon));
			spaceNavigationView.AddSpaceItem(new SpaceItem("SEARCH", Resource.Mipmap.Icon));
		}
	}
}

