﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AdditionalTask
{
    [Serializable]
    class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }

    class Program
    {
        static void Main()
        {
            Car auto = new Car("Mercedes",250);

            FileStream stream = File.Create("CarData.data");

            BinaryFormatter formatter = new BinaryFormatter();

            // Cериализация.
            formatter.Serialize(stream, auto);
            stream.Close();
        }
    }
}
