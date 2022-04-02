namespace AbstractFactoryPattern
{
    public class Application
    {
        private IUiElementFactory _elementFactory;

        public Application(IUiElementFactory elementFactory)
        {
            _elementFactory = elementFactory;
        }

        public void RenderUi()
        {
            var createNewFileButton = _elementFactory.CreateButton();
            createNewFileButton.Render();
            var textBox = _elementFactory.CreateTextbox();
            textBox.Render();
        }
    }
}