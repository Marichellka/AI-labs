namespace Lab1;

class StepActivationFunction(float throughput) : IActivationFunction
{
    private readonly float _throughput = throughput;
    
    public float Calculate(float input) => input >= _throughput ? 1 : 0;
}