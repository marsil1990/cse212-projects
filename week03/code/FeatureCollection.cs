public class Properties
{
    public string place { get; set; }
    public Double mag { get; set; }
}

public class Feature
{
    public Properties Properties { get; set; }
}

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features { get; set; }
}