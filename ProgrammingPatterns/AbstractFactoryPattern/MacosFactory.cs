namespace AbstractFactoryPattern
{
    public class MacosFactory : IUiElementFactory
    {
        public IButton CreateButton()
        {
            return new MacOsButton();
        }

        public ITextbox CreateTextbox()
        {
            return new MacosTextbox();
        }
    }
}