using System;

//Types can have only 2 access modifiers
//Type members can have 5 access modifiers

/*1.Private
 * 2.Protected
 * 3.Internal
 * 4.Protected Internal
 * 5.Public  */

public class Customer
{
    private int _id; //only available within this type
    public int id
    {
        get { return this._id; }
        set { this._id = value; }
    }

    protected int roll;//available within the class and in any derived class 

}

public class EmpCustomer:Customer
{
    public void Print()
    {
        EmpCustomer emp = new EmpCustomer();
        emp.roll=12;//available min derived class
        base.roll = 45;
    }
    
}

public class Program
{
    public static void Main()
    {

        Customer c1 = new Customer();
        c1.id = 12;
    }
}