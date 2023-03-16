using IceCreamShop;

Case menu = new Case();
List<Flavor> availableFlavors = menu.Flavors;
List<Cone> availableCones = menu.Cones;
//FlavorComparer comparer = new FlavorComparer();

// TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
//  field.

availableFlavors.Sort(new FlavorComparer());

foreach (var flavors in availableFlavors)
{
    Console.WriteLine(flavors.Name);
}


// TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
//  field.
Console.WriteLine("----------------------------------");
availableCones.Sort(new ConeComparer());


foreach (var cone in availableCones)
{
    Console.WriteLine($"{cone.Name}: {cone.Cost}");
}
// TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.