namespace OOP_03
{
    #region Part2 1.Shipment Class Update

    //public struct DeliveryAddress
    //{
    //    public string City;
    //    public string Street;
    //    public int BuildingNumber;

    //    public DeliveryAddress(string city, string street, int buildingNumber)
    //    {
    //        City = city;
    //        Street = street;
    //        BuildingNumber = buildingNumber;
    //    }

    //    public string GetFullAddress()
    //    {
    //        return $"BuildingNumber: {BuildingNumber} Street: {Street} City: {City}";
    //    }
    //}
    //public class Driver
    //{
    //    public string Name { get; set; }
    //    public Driver(string name) { Name = name; }
    //}
    //public class Shipment
    //{
    //    public string TrackingCode { get; private set; }
    //    public string Description { get; set; }
    //    public double Weight { get; protected set; }
    //    public decimal DeliveryFee { get; protected set; }
    //    public DeliveryAddress Destination { get; set; }

    //    public virtual decimal EstimatedCost
    //    {
    //        get { return DeliveryFee + (decimal)(Weight * 5); }
    //    }

    //    public Shipment() { }

    //    public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
    //    {
    //        TrackingCode = trackingCode;
    //        Description = description;
    //        Weight = weight > 0 ? weight : 1;
    //        DeliveryFee = deliveryFee >= 0 ? deliveryFee : 0;
    //        Destination = destination;
    //    }

    //    public void UpdateWeight(double newWeight)
    //    {
    //        if (newWeight > 0)
    //            Weight = newWeight;
    //    }
    //    public void UpdateWeight(double newWeight, double packingWeight)
    //    {
    //        if (newWeight > 0 && packingWeight > 0)
    //            Weight = newWeight + packingWeight;
    //    }

    //    public virtual void PrintShipment()
    //    {
    //        Console.WriteLine($"Tracking Code : {TrackingCode}");
    //        Console.WriteLine($"Description   : {Description}");
    //        Console.WriteLine($"Weight        : {Weight} KG");
    //        Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
    //    }
    //}

    #endregion
    #region Part2  2,3,4.Constructor Chaining&Overrides
    //public class StandardShipment : Shipment
    //{
    //    // 2. Constructor Chaining -> base(...)
    //    public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
    //        : base(trackingCode, description, weight, deliveryFee, destination)
    //    {
    //    }
    //    public override void PrintShipment()
    //    {
    //        Console.WriteLine("Standard Shipment\n");
    //        base.PrintShipment();
    //        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
    //        Console.WriteLine("------------------------------------------");
    //    }
    //}

    //public class ExpressShipment : Shipment
    //{
    //    public decimal ExtraFee { get; set; }

    //    public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
    //        : base(trackingCode, description, weight, deliveryFee, destination)
    //    {
    //        ExtraFee = extraFee >= 0 ? extraFee : 0;
    //    }

    //    public override decimal EstimatedCost
    //    {
    //        get { return base.EstimatedCost + ExtraFee; }
    //    }
    //    public override void PrintShipment()
    //    {
    //        Console.WriteLine("Express Shipment\n");
    //        base.PrintShipment();
    //        Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
    //        Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
    //        Console.WriteLine("\n------------------------------------------\n");
    //    }
    //}
    //public class InternationalShipment : Shipment
    //{
    //    public string DestinationCountry { get; set; }
    //    public decimal CustomsFee { get; set; }
    //    public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
    //        : base(trackingCode, description, weight, deliveryFee, destination)
    //    {
    //        DestinationCountry = string.IsNullOrWhiteSpace(destinationCountry) ? "Unknown" : destinationCountry;
    //        CustomsFee = customsFee >= 0 ? customsFee : 0;
    //    }
    //    public override decimal EstimatedCost
    //    {
    //        get { return base.EstimatedCost + CustomsFee; }
    //    }
    //    public override void PrintShipment()
    //    {
    //        Console.WriteLine("International Shipment\n");
    //        base.PrintShipment();
    //        Console.WriteLine($"Destination Country   : {DestinationCountry}");
    //        Console.WriteLine($"Customs Fee           : {CustomsFee} EGP");
    //        Console.WriteLine($"Estimated Cost        : {EstimatedCost} EGP");
    //        Console.WriteLine("\n==========================================\n");
    //    }
    //    public virtual void GenerateCustomsReport()
    //    {
    //        Console.WriteLine("Generating Standard Customs Report...");
    //    }
    //}
    #endregion
    #region Part2 5.Update DeliveryCenter
    //public class DeliveryCenter
    //{
    //    public Driver CenterDriver { get; set; }
    //    private Shipment[] Shipments = new Shipment[20];
    //    public Shipment this[int index]
    //    {
    //        get
    //        {
    //            if (index >= 0 && index < shipments.Length)
    //            {
    //                return shipments[index];
    //            }
    //            return null;
    //        }
    //        set
    //        {
    //            if (index >= 0 && index < shipments.Length)
    //            {
    //                shipments[index] = value;
    //            }
    //        }
    //    }

    //    public Shipment this[string trackingCode]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < shipments.Length; i++)
    //            {
    //                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
    //                {
    //                    return shipments[i];
    //                }
    //            }
    //            return null;
    //        }
    //    }
    //    public bool RemoveShipment(string trackingCode)
    //    {
    //        for (int i = 0; i < shipments.Length; i++)
    //        {
    //            if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
    //            {
    //                for (int j = i; j < shipments.Length - 1; j++)
    //                {
    //                    shipments[j] = shipments[j + 1];
    //                }
    //                shipments[shipments.Length - 1] = null;
    //                return true;
    //            }
    //        }
    //        return false;
    //    }
    //    public bool AddShipment(Shipment shipment)
    //    {
    //        for (int i = 0; i < Shipments.Length; i++)
    //        {
    //            if (Shipments[i] == null)
    //            {
    //                Shipments[i] = shipment;
    //                return true;
    //            }
    //        }
    //        return false;
    //    }

    //    public void PrintAllShipments()
    //    {
    //        Console.WriteLine("==========================================");
    //        Console.WriteLine("Delivery Center");
    //        Console.WriteLine("==========================================");
    //        if (CenterDriver != null)
    //            Console.WriteLine($"Driver : {CenterDriver.Name}");
    //        Console.WriteLine("\n------------------------------------------\n");

    //        foreach (Shipment s in Shipments)
    //        {
    //            if (s != null)
    //            {
    //                s.PrintShipment(); 
    //            }
    //        }
    //    }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1 question1
            ////a)Method Overloading:Occurs when multiple methods in the same class share the same name but have different parameters
            ////(different type, number, or order of parameters)It does not require inheritance.

            ////Method Overriding:Occurs when a child (derived) class provides a specific implementation for a method that is already defined
            //// in its parent(base)class The method must have the exact same name, return type, and parameters
            ////It requires inheritance and the use of virtual or abstract in the parent class, and override in the child class.

            ////b)Static Binding (Early Binding):The method call is resolved by the compiler at compile-time
            ////This happens with normal methods and method overloading.The compiler knows exactly which method to execute based on the reference type.

            ////Dynamic Binding (Late Binding):The method call is resolved at run-time based on the actual object type created in memory,
            //// not the reference type. This happens with method overriding (when virtual/override keywords are used).
            #endregion
            #region Part1 question2
            ////a)The sealed keyword prevents a class from being inherited. When a class is marked as sealed, no other class can derive from it
            ////It is used to protect the code from being altered via inheritance and can occasionally provide minor performance optimizations.

            ////b)Sealed Class: Prevents the entire class from being inherited. You cannot create a child class from it.

            ////Sealed Method: Prevents a specific overridden method from being overridden further by classes lower in the inheritance hierarchy.

            ////c)No. A sealed method cannot be overridden.The fundamental reason for applying the sealed keyword to a method 
            ////is to explicitly stop the inheritance chain for that specific behavior
            #endregion

        }
    }
}
