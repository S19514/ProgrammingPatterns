namespace AbstractFactoryPattern
{
    public class WindowsFactory : IUiElementFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextbox CreateTextbox()
        {
            return new WindowsTextbox();
        }
    }
}