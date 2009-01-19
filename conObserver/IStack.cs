// interfaz IStack.cs
// -Notify()
// +Attach()
// +Detach()

public interface IStack{
  // los métodos que se van a declarar
  // push algo al stack.
  // pop algo al stack.
  // decir cuantos te quedan
   void popStack();
   void pushStack(string elemento);
   void howMany();

  // // para el OBSERVER PATTERN
   void notify(int aQuien);
   void attach(Observer fisgon);
   void detach(Observer fisgon);
  
  // private string state;

}