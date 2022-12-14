class A
{
    public int x;
}
//Single Inheritance
class B: A        //B inherits from A, B is pf type A
{
    public int y;
}
//Multulevel inheritance
class C: B
{
    public int z;
}
//Multiple Inheritance
interface ID
{
  
}
interface IF
{
  
}
class E: B, ID, IF
{
    
}