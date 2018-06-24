**ScriptUserControl** is used to define complex user controls which support ASP.NET AJAX script extensions.
It allows for combining aspx controls together and adding client script.\
**ScriptUserControl** originally available in **AjaxControlToolkit** was removed from the package since DevExpress-driven version 15.1.\
Adding this class back was finally made possible thanks to the changes introduced in version 18.1 - see issue [#347](https://github.com/DevExpress/AjaxControlToolkit/pull/347) for the full story.\
The orginal demo application has been posted back in 2007: [How to preserve my Sys.UI.Control properties across postbacks??](https://forums.asp.net/t/1119462.aspx?How+to+preserve+my+Sys+UI+Control+properties+across+postbacks+)

Installation packege is available from NuGet: `PM> Install-Package AjaxControlToolkit.ScriptUserControl`

> **Note**: breaking change was introuduced to the namespace. You may need to modify the last line of your control java scripts and reqister control class using **Sys.Extended.UI.ControlBase** instead of **AjaxControlToolkit.ControlBase**. Example: change\
> `MyApplication.MyWebUserControl.registerClass('MyApplication.MyWebUserControl', AjaxControlToolkit.ControlBase);`\
> to\
> `MyApplication.MyWebUserControl.registerClass('MyApplication.MyWebUserControl', Sys.Extended.UI.ControlBase);`
