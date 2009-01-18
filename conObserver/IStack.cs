// interfaz IStack.cs
// -Notify()
// +Attach()
// +Detach()

public interface IStack{
  // los métodos que se van a declarar
  // push algo al stack.
  // pop algo al stack.
  // decir cuantos te quedan
  public void popStack();
  public void pushStack(string elemento);
  public void howMany();

  // para el OBSERVER PATTERN
  private string notify();
  public void attach();
  public void detach();
  
  // static private string state;

}