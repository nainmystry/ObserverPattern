class MobileAlert : NotificationAlertObserver
{
    IInventoryObservable _inventoryObservable;    
    public MobileAlert(IInventoryObservable inventoryObservable)
    {
        _inventoryObservable = inventoryObservable;
    }

    public void update()
    {
        sendMsg();
    }

    private void sendMsg(){
        Console.WriteLine("Msg sent to Mobile;");
    }
}