namespace Lab1;

public struct Neuron(Synapse[] synapsesIn, IActivationFunction activationFunction, float bias = 0)
{
    public Synapse[] SynapsesIn { get; } = synapsesIn;

    public IActivationFunction ActivationFunction { get; } = activationFunction;

    public float Bias { get; } = bias;

    public float Value { get; set; }

    public void Accept()
    {
        float value = Value;
        
        foreach (var synapseIn in SynapsesIn)
            value += synapseIn.Source.Value * synapseIn.Weight;

        value += Bias;

        Value = ActivationFunction.Calculate(value);
    }
}
