# Xamarin Android Binding Library
Xamarin Binding Library for [Armcha SpaceNavigationView](https://github.com/armcha/Space-Navigation-View)

```
Install-Package Naxam.Armcha.SpaceNavigationView
```

## How to use

In your AXML
```xml
<com.luseen.spacenavigation.SpaceNavigationView
        android:id="@+id/space"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        android:layout_gravity="bottom" /> 
```

In your Activity
```C#
SpaceNavigationView spaceNavigationView = FindViewById<SpaceNavigationView>(Resource.Id.space);
spaceNavigationView.InitWithSaveInstanceState(savedInstanceState);
spaceNavigationView.AddSpaceItem(new SpaceItem("HOME", Resource.Mipmap.Icon));
spaceNavigationView.AddSpaceItem(new SpaceItem("SEARCH", Resource.Mipmap.Icon));
```
