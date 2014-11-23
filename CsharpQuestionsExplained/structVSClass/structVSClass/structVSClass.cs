using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structVSClass
{
    /// <summary>
    /// A STRUCT that represents a point
    /// </summary>
    public struct PointStruct
    {
        public int x;
        public int y;

        //constructor
        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static void ModifyStruct(PointStruct newStruct )
        {
            var randomNumberGen = new Random();
            newStruct.x = randomNumberGen.Next();
            newStruct.y = randomNumberGen.Next();
        }

    }
    /// <summary>
    /// A CLASS that represents a point
    /// </summary>
    public class PointClass
    {

        public int x;
        public int y;

        //constructor
        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static void ModifyClass(PointClass newStruct)
        {
            var randomNumberGen = new Random();
            newStruct.x = randomNumberGen.Next();
            newStruct.y = randomNumberGen.Next();
        }
    }
}
