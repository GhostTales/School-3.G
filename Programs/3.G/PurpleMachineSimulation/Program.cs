using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleMachineSimulation
{
    // Usage example
    internal class Program
    {
        static void Main()
        {
            // Example wiring - in reality, the wiring would be based on Purple's actual configuration
            Rotor rotor1 = new Rotor(new int[] { 4, 10, 12, 5, 11, 6, 3, 16, 21, 25, 13, 19, 14, 22, 24, 7, 23, 20, 18, 15, 0, 8, 1, 17, 2, 9 });
            Rotor rotor2 = new Rotor(new int[] { 0, 9, 3, 10, 18, 8, 17, 20, 23, 1, 11, 7, 22, 19, 12, 2, 16, 6, 25, 13, 5, 21, 14, 4, 24, 15 });
            Rotor rotor3 = new Rotor(new int[] { 1, 3, 5, 7, 9, 11, 2, 15, 17, 19, 23, 21, 25, 13, 24, 4, 8, 16, 6, 0, 10, 12, 20, 18, 14, 22 });
            Rotor[] rotors = { rotor1, rotor2, rotor3 };
            RotorSet rotorSet = new RotorSet(rotors);
            Reflector reflector = new Reflector(new int[] { 24, 17, 20, 7, 16, 18, 11, 3, 15, 23, 13, 6, 14, 10, 12, 8, 4, 1, 5, 25, 2, 19, 22, 9, 0, 21 });
            Dictionary<char, char> plugboardConnections = new Dictionary<char, char>
        {
            {'A', 'B'}, {'C', 'D'}, {'E', 'F'}, {'G', 'H'}, {'I', 'J'}, {'K', 'L'},
            {'M', 'N'}, {'O', 'P'}, {'Q', 'R'}, {'S', 'T'}, {'U', 'V'}, {'W', 'X'},
            {'Y', 'Z'}
        };
            Plugboard plugboard = new Plugboard(plugboardConnections);
            CipherMachine cipherMachine = new CipherMachine(plugboard, rotorSet, reflector);

            string secretMessage = "ATTACKATDAWN";
            string encryptedMessage = cipherMachine.Encrypt(secretMessage);
            Console.WriteLine($"Encrypted message: {encryptedMessage}");

            string decryptedMessage = cipherMachine.Decrypt(encryptedMessage);
            Console.WriteLine($"Decrypted message: {decryptedMessage}");
        }
    }
}
