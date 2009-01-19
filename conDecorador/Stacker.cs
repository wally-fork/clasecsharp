#define TESTING

class Stacker{

  static void Main(){
    IStack stacy = new StackImpl1();
    StackDecorator1 orrico = new StackDecorator1(stacy);
    Observer StackObserver1 = new Observer();
    Observer StackObserver2 = new Observer();
    orrico.attach(StackObserver1);
    orrico.attach(StackObserver2);
    orrico.howMany();
    orrico.pushStack("Stella");
    orrico.pushStack("was");
    orrico.pushStack("a");
    orrico.pushStack("Diver");

    // Sin decorar
    stacy.pushStack("and");
    stacy.pushStack("she");
    stacy.pushStack("was");
    stacy.pushStack("always");
    stacy.pushStack("down");
    // decorar Sin

    orrico.howMany();
    orrico.popStack();
    orrico.howMany();
  }

}
