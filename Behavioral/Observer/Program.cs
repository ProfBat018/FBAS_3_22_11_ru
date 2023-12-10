using System;

var observer1 = new ObserverWithEvent("Observer 1");
var observer2 = new ObserverWithEvent("Observer 2");

var subject = new SubjectWithEvent();

subject.StateChanged += observer1.HandleStateChanged;
subject.StateChanged += observer2.HandleStateChanged;

subject.DoSomethingImportant();

observer1.Unsubscribe(subject);

subject.DoSomethingImportant();



