class Stacker{
  static void Main(){
    StackImpl1 stacy = new StackImpl1();
    stacy.howMany();
    stacy.pushStack("Stella");
    stacy.pushStack("was");
    stacy.pushStack("a");
    stacy.pushStack("Diver");
    stacy.pushStack("and");
    stacy.pushStack("she");
    stacy.pushStack("was");
    stacy.pushStack("always");
    stacy.pushStack("down");

    stacy.howMany();
    stacy.popStack();
    stacy.howMany();
  }
}
// crear un arreglo al que le vamos a meter diez cosas