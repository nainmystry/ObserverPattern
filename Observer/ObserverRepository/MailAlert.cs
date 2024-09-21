class MailAlert : NotificationAlertObserver
{
    IInventoryObservable _inventoryObservable;    
    public MailAlert(IInventoryObservable inventoryObservable)
    {
        _inventoryObservable = inventoryObservable;
    }

    public void update()
    {
        sendMail();
    }

    private void sendMail(){
        if(_inventoryObservable.getInventoryCount() < 10)
        {
            Console.WriteLine("Less than 10, left in stock. Mail sent to user.");
        }
        else
            Console.WriteLine("Mail sent to user.");

    }
}