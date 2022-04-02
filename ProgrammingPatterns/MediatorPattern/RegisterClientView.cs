namespace MediatorPattern
{
    public class RegisterClientView : IMediator
    {
        private Checkbox _clientType;
        private Button _submitButton;

        public RegisterClientView(Checkbox clientType,Button submitButton) //actual mediator
        {
            _submitButton = submitButton;
            _clientType = clientType;
            
            _submitButton.SetMediator(this);
            _clientType.SetMediator(this);
        }
        public void Notify(Component sender, string @event)
        {
            if (@event == "checkboxSelected")
            {
                _submitButton.Render();
            }
            else if (@event == "click")
            {
                _clientType.SaveValue();
            }
        }
    }
}