using Lab1;

float x = float.Parse(Console.ReadLine()!);
float y = float.Parse(Console.ReadLine()!);

Neuron xNeuron = new([], new DefaultActivationFunction())
{
    Value = x
};

Neuron yNeuron = new([], new DefaultActivationFunction())
{
    Value = y
};

Neuron outNeuron = new(new Synapse[2], new StepActivationFunction(0), -100);

Synapse xOut = new(xNeuron, outNeuron, 1);
Synapse yOut = new(yNeuron, outNeuron, 1);

outNeuron.SynapsesIn[0] = xOut;
outNeuron.SynapsesIn[1] = yOut;

outNeuron.Accept();

Console.WriteLine(outNeuron.Value);
