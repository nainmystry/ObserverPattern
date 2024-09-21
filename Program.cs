// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


IphoneObservable iphoneObservable = new IphoneObservable();

NotificationAlertObserver obsMail1 = new MailAlert(iphoneObservable);
NotificationAlertObserver obsMail2 = new MailAlert(iphoneObservable);
NotificationAlertObserver obsMobile = new MobileAlert(iphoneObservable);

iphoneObservable.add(obsMail1);
iphoneObservable.add(obsMail2);
iphoneObservable.add(obsMobile);


iphoneObservable.setInventoryCount(5);
iphoneObservable.setInventoryCount(-5);
iphoneObservable.setInventoryCount(11);

