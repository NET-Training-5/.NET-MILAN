using System;
class Abc
{
    void Learn()
    {
        // Arrays
        // One dimensional
        byte[] personAges = new byte[5];
        personAges[0] = 89;
        personAges[1] = 9;
        personAges[2] = 18;
        personAges[3] = 67;
        personAges[4] = 23;
        var x = personAges[2];

        byte[] peopleAges = { 89, 9, 18, 67, 23 };

        // Write an array to hold student names
        string[] names = { "Ram", "Shyam", "Lakhan", "Pranish" };

        // Multi dimensinal

        //  3   8   9
        //  8   7   3

        int[,] mat = new int[2, 3];
        mat[0, 0] = 3;
        mat[0, 1] = 8;
        mat[0, 2] = 9;
        mat[1, 0] = 8;
        mat[1, 1] = 7;
        mat[1, 2] = 3;

        int[,] table = { { 3, 8, 9, 5 }, { 8, 7, 3, 7 } };

        // Jagged array
        //  2   4   7
        //  1   5
        //  9   8   4   5
        short[][] items = new short[3][];
        items[0] = new short[] { 2, 4, 7 };
        items[1] = new short[] { 1, 5 };
        items[2] = new short[] { 9, 8, 4, 5 };
    }
}