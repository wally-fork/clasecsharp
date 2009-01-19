// implementacion de la interfaz IStack.cs
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
// using IStack;

// public class StackImpl1 : IStack{
public class StackImpl1 : IStack{

  static private int cosasEnStack;
  private Stack elStack = new Stack(100);
  private string elementoAlaMano;
  // para el OBSERVER ---------------------------------------------
  // private string state;

  // agregarle dos observer en un arreglo  
  // private Observer[] observadores = new Observer[2];
  // hacer una lista
  List<Observer> observadores = new List<Observer>();
  
  public void popStack(){
    if (elStack.Count > 0) {
      elementoAlaMano = (String)elStack.Peek();
      System.Console.WriteLine("sacando el elemento {0}", elementoAlaMano);
      elStack.Pop();

      // update a las cosas que hay en el stack
      cosasEnStack = elStack.Count;
      notify(0);
      notify(1);

    } else {
      System.Console.WriteLine("No hay nada en el Stack!!!");
    }
  }

  public void pushStack(string elemento){
    elStack.Push(elemento);
    notify(0);
    notify(1);
    // System.Console.WriteLine("metiendo el elemento {0}", elemento);
    cosasEnStack = elStack.Count;
  }

  public void howMany(){
    cosasEnStack = elStack.Count;
    // notify(0);
    // System.Console.WriteLine("Hay {0} cosas en el Stack", cosasEnStack);
  }
  
  public void notify(int aQuien){
    // 0 : CHANGED!!!
    // 1 : status
    
    //Console.WriteLine("args.Length={0}", args.Length);
    switch (aQuien)
      {
      case 0:
	
	// le va a mandar un mensaje de que se hizo un POP un PUSH
	this.observadores[0].Update("CHANGED!!!");

	break;
      case 1:
	// le va a decir cuántos hay en el Stack
	this.observadores[1].Update(cosasEnStack.ToString());
	break;
      default:
	System.Console.WriteLine("No existe ese observer");
	break;
      }
  }

  // para crear el Observador
  public void attach(Observer fisgon){
    
    observadores.Add(fisgon);
    // observadores[Observer.]
    // observadores.Append(fisgon);
    // Array.AsReadOnly
    // que hace esto?

  }
  public void detach(Observer fisgon){
    // que hace esto?
    // observadores.Pop(fisgon);
    observadores.Remove(fisgon);
  }
}

