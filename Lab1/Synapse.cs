namespace Lab1;

public struct Synapse(Neuron source, Neuron target, float weight)
{
    public Neuron Source { get; } = source;

    public Neuron Target { get; } = target;

    public float Weight { get; } = weight;
}
