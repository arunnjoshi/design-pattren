namespace AbstractFactory;

public interface IWidgetFactory
{
	IButton CreateButton();
	ITextBox CreateTextBox();
}
