// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class MyClass
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

List<MyClass> myLIST = new List<MyClass>();
MyClass myClass = new MyClass();

public List<MyClass> AddStudent()
{
    //for each loop
    foreach (var item in myLIST)
    {
        item.Id = item.Id + 1;
        item.FirstName = "Temitayo";
        item.LastName = "Boy";
    }


    //for loop
    for (int i = 0; i < myLIST.Count; i++)
    {
        myLIST[i].Id = i;
        myLIST[i].FirstName = "Temitayo";
        myLIST[i].LastName = "Boy";
    }

    //while loop
    int numberInTheList = myLIST.Count;
    while (numberInTheList > 0)
    {
        /// do something
    }

    //if statement

    if (myClass.FirstName == "Temitayo")
    {
        //do this
    }
    else
    {
        //do this thing
    }

    //if, else if and else

    if (myClass.FirstName == "Temitayo")
    {
        //do this
    }
    else if (myClass.FirstName != "Temitayo" && myClass.LastName == "Boy")
    {
        //do this
    }
    else if (myClass.FirstName != "Temitayo" && myClass.LastName == "Boy")
    {
        //do this
    }
    else if (myClass.FirstName != "Temitayo" && myClass.LastName == "Boy")
    {
        //do this
    }
    else if (myClass.FirstName != "Temitayo" && myClass.LastName == "Boy")
    {
        //do this
    }
    else
    {
        //do this thing
    }
    return myLIST;
}
