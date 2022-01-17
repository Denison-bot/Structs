using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        struct Vector3
        {
            public float x;
            public float y;
            public float z;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Structs:");
            Console.WriteLine("");

            Console.WriteLine("BeforeStructs:");
            Console.WriteLine("");

            // gamepad (2D)
            float gamepadX;
            float gamepadY;

            gamepadX = 0.0f;
            gamepadY = 0.0f;

            // player movement (3D)
            float playerMovementX;
            float playerMovementY;
            float playerMovementZ;

            playerMovementX = gamepadX;
            playerMovementY = 0.0f;
            playerMovementZ = gamepadY;

            Console.WriteLine("AfterStructs:");
            Console.WriteLine("");


            Console.ReadKey(true);
        }
    }
}
