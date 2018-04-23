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


