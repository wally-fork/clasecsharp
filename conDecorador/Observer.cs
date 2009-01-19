// Observer

using System;

public class Observer : IObserver{
  
  private string subject;
  private string state;

  // public void Observer(){
  //   // jaja
  // }

  public void Update(string updatizacion){

    System.Console.WriteLine("Haz recibido el update: {0}", updatizacion);

  }
}