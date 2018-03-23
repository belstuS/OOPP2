How to use Surviveplus.WpfLocalization

1. Install "Surviveplus.WpfLocalization" to class library project from NuGet Package Manager.
2. Add x:Uid attribute to XAML of WPF page or control, like this example...

        <TextBlock x:Uid="aboutTitle">About</TextBlock>

3. Add text to Resources.resx (and other language files), like this example...

	Resources.resx :
		Name	Value
		aboutTitle.Text	About

	Resources.fr.resx :
		Name	Value
		aboutTitle.Text	De

	Resources.jp.resx :
		Name	Value
		aboutTitle.Text	バージョン情報	

4. Add code to call WpfLocalization.ApplyResources method, after InitializeComponent in constructor.

    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
            WpfLocalization.ApplyResources(this, Properties.Resources.ResourceManager);
        } 
    }

In this version, the following classes and properties are supported.

	TexBlock.Text
	TextBox.Text
	Button.Content
	CheckBox.Content, CheckBox.ToolTip
	RadioButton.Content, RadioButton.ToolTip
