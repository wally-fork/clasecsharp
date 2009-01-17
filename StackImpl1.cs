// implementacion de la interfaz IStack.cs
using System;
using System.Collections;
// using IStack;

// public class StackImpl1 : IStack{
public class StackImpl1 : IStack{

  private int cosasEnStack;
  private Stack elStack = new Stack(100);
  private string elementoAlaMano;
   
  public void popStack(){
    if (elStack.Count > 0) {
      elementoAlaMano = (String)elStack.Peek();
      System.Console.WriteLine("sacando el elemento {0}", elementoAlaMano);
      elStack.Pop();
    } else {
      System.Console.WriteLine("No hay nada en el Stack!!!");
    }


  }

  public void pushStack(string elemento){
    elStack.Push(elemento);
    System.Console.WriteLine("metiendo el elemento {0}", elemento);
  }

  public void howMany(){
    cosasEnStack = elStack.Count;
    System.Console.WriteLine("Hay {0} cosas en el Stack", cosasEnStack);
  }

}

