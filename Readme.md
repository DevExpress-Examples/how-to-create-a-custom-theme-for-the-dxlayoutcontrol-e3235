<!-- default file list -->
*Files to look at*:

* [Office2007.Silverlight.xaml](./CS/SilverlightApplication27/DevExpress.Xpf.LayoutControl/Office2007.Silverlight.xaml) (VB: [Office2007.Silverlight.xaml](./VB/SilverlightApplication27/DevExpress.Xpf.LayoutControl/Office2007.Silverlight.xaml))
* [Office2007.xaml](./CS/SilverlightApplication27/DevExpress.Xpf.LayoutControl/Office2007.xaml) (VB: [Office2007.xaml](./VB/SilverlightApplication27/DevExpress.Xpf.LayoutControl/Office2007.xaml))
* [Office2007Colors.xaml](./CS/SilverlightApplication27/DevExpress.Xpf.LayoutControl/Office2007Colors.xaml) (VB: [Office2007Colors.xaml](./VB/SilverlightApplication27/DevExpress.Xpf.LayoutControl/Office2007Colors.xaml))
* [MainPage.xaml](./CS/SilverlightApplication27/MainPage.xaml) (VB: [MainPage.xaml](./VB/SilverlightApplication27/MainPage.xaml))
* [MainPage.xaml.cs](./CS/SilverlightApplication27/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/SilverlightApplication27/MainPage.xaml.vb))
* [StandardControls.xaml](./CS/SilverlightApplication27/Themes.SL/StandardControls.xaml) (VB: [StandardControls.xaml](./VB/SilverlightApplication27/Themes.SL/StandardControls.xaml))
<!-- default file list end -->
# How to create a custom theme for the DXLayoutControl


<p>The main idea is to copy our theme templates and accurately modify them. In the attachment, some brushes from the Office2007Colors.xaml file are modified.</p><p>To apply a custom theme, use the following code </p><p> 

```cs
    Theme theme = new Theme("testTheme", new Uri("/SilverlightApplication27;component/DevExpress.Xpf.LayoutControl/Office2007.Silverlight.xaml", UriKind.Relative)) { IsStandard = false, FullName = "Test Theme" };
            ThemeManager.ApplicationTheme = theme;

```

 </p><p>Note that:</p><p>-all theme resource files should be included into the project as resources</p><p>-root theme file uri should be passed to the Theme class constructor</p><p>-root theme file should contain Merged dictionaries' only node; all other content will be ignored.</p><p>-the Source property of the resource dictionaries monitored in the root theme file merged dictionaries collection should have a uri like this "/Assembly;component/ResourceFile.xaml" .<br />
-even if you are not going to change standard controls theme, the custom theme must have the Themes.SL\StandardControls.xaml file.</p>


<h3>Description</h3>

<p><br />
</p>

<br/>


