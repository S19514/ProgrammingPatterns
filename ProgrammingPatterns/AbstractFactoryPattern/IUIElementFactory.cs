namespace AbstractFactoryPattern
{
    public interface IUiElementFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}