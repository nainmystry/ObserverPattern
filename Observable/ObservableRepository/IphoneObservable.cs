public class IphoneObservable : IInventoryObservable
{
    List<NotificationAlertObserver> alertObservers = new List<NotificationAlertObserver>();
    int inventoryCount = 0;
    public void add(NotificationAlertObserver alertObserver)
    {
        if(alertObserver == null)
            throw new InvalidOperationException();

        alertObservers.Add(alertObserver);
    }

    public int getInventoryCount()
    {
        return inventoryCount;
    }

    public void notifyObservers()
    {
        foreach (NotificationAlertObserver observer in alertObservers)
        {
            observer.update();
        }
    }

    public void remove(NotificationAlertObserver alertObserver)
    {
        if(alertObserver == null)
            throw new InvalidOperationException();

        alertObservers.Remove(alertObserver);
    }

    public void setInventoryCount(int addedQuantity)
    {
        int prevCount = inventoryCount;
        inventoryCount += addedQuantity;
        if(prevCount == 0)
        {
            notifyObservers();
        }
    }
}