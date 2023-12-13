using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleMachineSimulation
{

    internal class Rotor
    {
        private readonly int[] wiring;
        private int position;

        public Rotor(int[] wiring)
        {
            this.wiring = (int[])wiring.Clone();
            position = 0;
        }

        public int Position
        {
            set { position = value % wiring.Length; }
            get { return position; }
        }

        public int Encrypt(int input)
        {
            return (wiring[(input + position) % wiring.Length] + wiring.Length - position) % wiring.Length;
        }

        public int Decrypt(int output)
        {
            int adjustedOutput = (output + position) % wiring.Length;
            int index = Array.IndexOf(wiring, adjustedOutput);
            if (index == -1)
            {
                throw new InvalidOperationException("The wiring configuration is invalid.");
            }
            return (index + wiring.Length - position) % wiring.Length;
        }
    }

    internal class RotorSet
    {
        private readonly Rotor[] rotors;

        public RotorSet(Rotor[] rotors)
        {
            this.rotors = rotors;
        }

        public int Encrypt(int input)
        {
            return rotors.Aggregate(input, (current, rotor) => rotor.Encrypt(current));
        }

        public int Decrypt(int output)
        {
            return rotors.Reverse().Aggregate(output, (current, rotor) => rotor.Decrypt(current));
        }

        // Simple rotation logic for illustration; real Purple machine rotation was more complex
        public void Rotate()
        {
            rotors[0].Position += 1;
        }
    }

    internal class Reflector
    {
        private readonly int[] wiring;

        public Reflector(int[] wiring)
        {
            this.wiring = wiring;
        }

        public int Reflect(int input)
        {
            return wiring[input];
        }
    }

    internal class Plugboard
    {
        private readonly Dictionary<char, char> plugboardConnections;

        public Plugboard(Dictionary<char, char> connections)
        {
            plugboardConnections = connections;
        }

        public char Swap(char input)
        {
            return plugboardConnections.TryGetValue(input, out char output) ? output : input;
        }
    }

    internal class CipherMachine
    {
        private readonly Plugboard plugboard;
        private readonly RotorSet rotorSet;
        private readonly Reflector reflector;

        public CipherMachine(Plugboard plugboard, RotorSet rotorSet, Reflector reflector)
        {
            this.plugboard = plugboard;
            this.rotorSet = rotorSet;
            this.reflector = reflector;
        }

        private string Process(string inputString, bool isEncrypting)
    {
        string outputString = string.Empty;
        foreach (char letter in inputString.ToUpper())
        {
            if (!char.IsLetter(letter))
            {
                outputString += letter;
                continue;
            }

            char substitutedLetter = plugboard.Swap(letter);
            int charPosition = substitutedLetter - 'A';
            int processedPosition = isEncrypting ? rotorSet.Encrypt(charPosition) : rotorSet.Decrypt(charPosition);
            processedPosition = reflector.Reflect(processedPosition);
            processedPosition = isEncrypting ? rotorSet.Encrypt(processedPosition) : rotorSet.Decrypt(processedPosition);
            char processedChar = (char)('A' + processedPosition);
            processedChar = plugboard.Swap(processedChar);

            outputString += processedChar;

            rotorSet.Rotate();
        }
        return outputString;
    }

    public string Encrypt(string plaintext)
    {
        return Process(plaintext, true);
    }

    public string Decrypt(string ciphertext)
    {
        return Process(ciphertext, false);
    }
}
}
