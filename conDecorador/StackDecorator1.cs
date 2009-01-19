#define DEBUG

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class StackDecorator1 : IStack{

  IStack component;
  
  public StackDecorator1 (IStack c){
    component = c;
  }

  public void popStack(){
    component.popStack();
    #if DEBUG
    System.Console.WriteLine("stack:[StackImpl1] void popStack()");
    #endif
  }

  public void pushStack(string elemento){
    component.pushStack(elemento);
    #if DEBUG
    System.Console.WriteLine("stack:[StackImpl1] void pushStack({0})",elemento);
    #endif
  }

  public void howMany(){
    component.howMany();
    #if DEBUG
    System.Console.WriteLine("stack:[StackImpl1] void howMany()");
    #endif
  }

  public void notify(int aQuien){
    component.notify(aQuien);
    #if DEBUG
    System.Console.WriteLine("stack:[StackImpl1] void notify(int aQuien)");
    #endif
  }

  public void attach(Observer fisgon){
    component.attach(fisgon);
    #if DEBUG
    System.Console.WriteLine("stack:[StackImpl1] void attach(Observer fisgon)");
    #endif
  }
  public void detach(Observer fisgon){
    component.detach(fisgon);
    #if DEBUG
    System.Console.WriteLine("stack:[StackImpl1] void detach(Observer fisgon)");
    #endif
  }
}



