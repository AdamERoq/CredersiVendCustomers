namespace Vend.Tests;

using VendObjects;
using VendDatabase;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void BounderyCheckTestForLeadVersion1()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(0)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Lead");
    }
    [Test]
    public void BounderyCheckTestForLeadVersion2()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(1)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Aluminum");
    }
    [Test]
    public void BounderyCheckTestForLeadVersion3()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(2)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Bronze");
    }
    [Test]
    public void BounderyCheckTestForAluminumVersion1()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(0)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Lead");
    }
    [Test]
    public void BounderyCheckTestForAluminumVersion2()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(1)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Aluminum");
    }
    [Test]
    public void BounderyCheckTestForAluminumVersion3()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(2)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Bronze");
    }
    [Test]
    public void BounderyCheckTestForSilverVersion1()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(5)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Bronze");
    }
    [Test]
    public void BounderyCheckTestForSilverVersion2()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(6)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Silver");
    }
    [Test]
    public void BounderyCheckTestForSilverVersion3()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(7)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Silver");
    }
    [Test]
    public void BounderyCheckTestForGoldVersion1()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(19)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Silver");
    }
    [Test]
    public void BounderyCheckTestForGoldVersion2()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Gold");
    }
    [Test]
    public void BounderyCheckTestForGoldVersion3()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(21)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Gold");
    }
    [Test]
    public void BounderyCheckTestForPlatinumVersion1()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(199)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Gold");
    }
    // [Test]
    // public void BounderyCheckTestForPlatinumVersion2()
    // {
    //     Customer db = new Customer(7, "The Empire");
    //     db.SetContact("Palpatine")
    //     .SetMachines(200)
    //     .SetAddress1("The Throne Room")
    //     .SetAddress2("The Death Star")
    //     .SetAddress3("Space")
    //     .SetPostCode("DE47 H5R");
    //     Assert.That(db.Category == "Platinum");
    // }
    [Test]
    public void BounderyCheckTestForPlatinumVersion3()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(201)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Category == "Platinum");
    }
    [Test]
    public void ColletingTheAddress1()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Address1 == "The Throne Room");
    }
    [Test]
    public void ColletingTheAddress2()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Address2 == "The Death Star");
    }
    [Test]
    public void ColletingTheAddress3()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Address3 == "Space");
    }
    [Test]
    public void ColletingTheContact()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Contact == "Palpatine");
    }
    [Test]
    public void ColletingTheId()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Id == 7);
    }
    [Test]
    public void ColletingTheMachines()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Machines == 20);
    }
    [Test]
    public void ColletingTheName()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Name == "The Empire");
    }
    [Test]
    public void ColletingThePostcode()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.PostCode == "DE47 H5R");
    }
    [Test]
    public void SettingTheAddress1()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Address1 == "The Throne Room");
    }
    [Test]
    public void SettingTheAddress2()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Address2 == "The Death Star");
    }
    [Test]
    public void SettingTheAddress3()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Address3 == "Space");
    }
    [Test]
    public void SettingTheContact()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Contact == "Palpatine");
    }
    [Test]
    public void SettingTheId()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Id == 7);
    }
    [Test]
    public void SettingTheMachines()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Machines == 20);
    }
    [Test]
    public void SettingTheName()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.Name == "The Empire");
    }
    [Test]
    public void SettingThePostcode()
    {
        Customer db = new Customer(7, "The Empire");
        db.SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R");
        Assert.That(db.PostCode == "DE47 H5R");
    }
    [Test]
    public void CreateFuntcion()
    {
        Customers db = new Customers();
        db.RemoveAll();
        db.Add(db.Create(1, "The Empire"));
        Assert.That(db.Query(1).Id, Is.EqualTo(1));
        Assert.That(db.Query(1).Name, Is.EqualTo("The Empire"));
    }
    [Test]
    public void AddFuntcion()
    {
        Customers db = new Customers();
        db.RemoveAll();
        db.Add(db.Create(1, "The Empire")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));
        Assert.That(db.Query(1).Id, Is.EqualTo(1));
        Assert.That(db.Query(1).Name, Is.EqualTo("The Empire"));
        Assert.That(db.Query(1).Contact, Is.EqualTo("Palpatine"));
        Assert.That(db.Query(1).Machines, Is.EqualTo(20));
        Assert.That(db.Query(1).Address1, Is.EqualTo("The Throne Room"));
        Assert.That(db.Query(1).Address2, Is.EqualTo("The Death Star"));
        Assert.That(db.Query(1).Address3, Is.EqualTo("Space"));
        Assert.That(db.Query(1).PostCode, Is.EqualTo("DE47 H5R"));
    }
    [Test]
    public void CountFunction()
    {

        Customers db = new Customers();
        db.RemoveAll();
        db.Add(db.Create(1, "The Empire")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));


        db.Add(db.Create(2, "Uss Enterprise")
        .SetContact("Captin Kerk")
        .SetMachines(20)
        .SetAddress1("The bridge")
        .SetAddress2("Uss Enterprise")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));

        db.Add(db.Create(3, "water")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));

        db.Add(db.Create(4, "Earth")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));
        Assert.That(db.Count() == 4);
    }
    [Test]
    public void ListFunction()
    {

        Customers db = new Customers();
        CustomersDatabase data = new CustomersDatabase();
        db.RemoveAll();
        db.Add(db.Create(1, "Peater")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));


        db.Add(db.Create(2, "Uss Enterprise")
        .SetContact("Captin Kerk")
        .SetMachines(20)
        .SetAddress1("The bridge")
        .SetAddress2("Uss Enterprise")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));

        db.Add(db.Create(3, "water")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));

        db.Add(db.Create(4, "Earth")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));
        List<VendObjects.Customer> list = db.List();
        int i = 1;
        foreach (VendObjects.Customer item in list) {
            int customer = item.Id; 
            Assert.That(customer == i); 
            i++;
        }
        
    }
     [Test]
    public void NextIdFunction()
    {

        Customers db = new Customers();
        CustomersDatabase data = new CustomersDatabase();
        db.RemoveAll();
        db.Add(db.Create(1, "Peater")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));


        db.Add(db.Create(2, "Uss Enterprise")
        .SetContact("Captin Kerk")
        .SetMachines(20)
        .SetAddress1("The bridge")
        .SetAddress2("Uss Enterprise")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));

        db.Add(db.Create(3, "water")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));

        db.Add(db.Create(4, "Earth")
        .SetContact("Palpatine")
        .SetMachines(20)
        .SetAddress1("The Throne Room")
        .SetAddress2("The Death Star")
        .SetAddress3("Space")
        .SetPostCode("DE47 H5R"));
        Assert.That(db.NextId() == 5);;

    }
    [Test]
    public void QueryFunction()
    {
        Customers db = new Customers();
        db.RemoveAll();
        Customer customer = db.Create(7, "Galaxy Ltd")
        .SetContact("Douglas Adams")
        .SetMachines(4)
        .SetAddress1("42 Galaxy Street")
        .SetAddress2("Adamstown")
        .SetAddress3("Shropshire")
        .SetPostCode("GX22 42P");
        db.Add(customer);
        Assert.That(customer.Id, Is.EqualTo(db.Query(7).Id));
        Assert.That(customer.Name, Is.EqualTo(db.Query(7).Name));
        Assert.That(customer.Contact, Is.EqualTo(db.Query(7).Contact));
        Assert.That(customer.Machines, Is.EqualTo(db.Query(7).Machines));
        Assert.That(customer.Address1, Is.EqualTo(db.Query(7).Address1));
        Assert.That(customer.Address2, Is.EqualTo(db.Query(7).Address2));
        Assert.That(customer.Address3, Is.EqualTo(db.Query(7).Address3));
        Assert.That(customer.PostCode, Is.EqualTo(db.Query(7).PostCode));
    }

    [Test]
    public void RemoveAllFunction()
    {
        Customers db = new Customers();
        db.RemoveAll();
        db.Add(db.Create(7, "Galaxy Ltd")
        .SetContact("Douglas Adams")
        .SetMachines(4)
        .SetAddress1("42 Galaxy Street")
        .SetAddress2("Adamstown")
        .SetAddress3("Shropshire")
        .SetPostCode("GX22 42P"));

    db.Add(db.Create(8, "Alpha Ltd")
        .SetContact("Jane Smith")
        .SetMachines(40)
        .SetAddress1("2 Created Wibble")
        .SetAddress2("Hippo")
        .SetAddress3("Obvious")
        .SetPostCode("AL22 42P"));

    db.Add(db.Create(203, "Hello World Limited")
        .SetContact("Floz Martin")
        .SetAddress1("32 Hello World")
        .SetAddress3("Essex")
        .SetPostCode("HW20 22A"));

    db.Add(db.Create(222, "Big Company Ltd")
        .SetMachines(400)
        .SetAddress1("59 Yellow Road")
        .SetAddress3("Bridgnorth")
        .SetPostCode("BC10 19C"));

    db.Add(db.Create(2, "Jones Jumpers Ltd")
        .SetContact("John Jones")
        .SetMachines(4)
        .SetAddress1("99 Ninety Nine")
        .SetAddress2("Jonestown")
        .SetAddress3("Essex")
        .SetPostCode("JJ33 33J"));

    db.RemoveAll();
    try {
    db.List();
    Assert.Fail();
    } catch{
        Assert.Pass();
    }
    }
}