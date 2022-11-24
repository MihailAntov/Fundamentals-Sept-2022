using System;
using System.Collections.Generic;

namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();
            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                pieces.Add(inputArgs[0], new Piece(inputArgs[1], inputArgs[2]));

            }

            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmdArgs = input.Split("|", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArgs[0];
                string piece = cmdArgs[1];
                switch (command)
                {
                    case "Add":

                        if (pieces.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            string composer = cmdArgs[2];
                            string key = cmdArgs[3];
                            pieces.Add(piece, new Piece(composer, key));
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        if (pieces.ContainsKey(piece))
                        {
                            string newKey = cmdArgs[2];
                            pieces[piece].Key = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;

                }
            }

            foreach (KeyValuePair<string, Piece> piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }

    public class Piece
    {
        public Piece(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }

        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
