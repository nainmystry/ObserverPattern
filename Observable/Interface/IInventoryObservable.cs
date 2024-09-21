public interface IInventoryObservable
{
    void add(NotificationAlertObserver alertObserver);

    void remove(NotificationAlertObserver alertObserver);

    void notifyObservers();

    void setInventoryCount(int addedQuantity);
    
    int getInventoryCount();
} 