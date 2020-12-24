using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AOC.Day1
{
    public static class Program
    {
        private static readonly List<int> _numbers = new()
        {
            2008,
            1529,
            1594,
            1422,
            1518,
            1278,
            1553,
            1563,
            1911,
            1799,
            1554,
            1247,
            1256,
            1558,
            483,
            1228,
            1931,
            1915,
            1982,
            1823,
            2003,
            1894,
            1388,
            1925,
            1501,
            1236,
            1897,
            1245,
            1386,
            1967,
            1806,
            1861,
            1837,
            1895,
            207,
            2002,
            1688,
            1214,
            1464,
            1905,
            1936,
            1926,
            899,
            245,
            1589,
            1449,
            1190,
            1332,
            1444,
            2000,
            1210,
            1979,
            1472,
            1477,
            1904,
            1354,
            1930,
            1318,
            1981,
            1929,
            1763,
            1840,
            1536,
            1862,
            1262,
            1202,
            1993,
            1963,
            1872,
            1907,
            1287,
            1231,
            1387,
            1555,
            1782,
            1301,
            1468,
            1476,
            1908,
            1436,
            1941,
            1252,
            1824,
            1910,
            1817,
            1818,
            131,
            1201,
            1869,
            1357,
            1983,
            1543,
            1836,
            1860,
            1648,
            1916,
            1825,
            1875,
            1233,
            1289,
            1071,
            1355,
            1761,
            1846,
            1392,
            1966,
            1204,
            1906,
            1830,
            1309,
            1427,
            1347,
            1315,
            1602,
            1323,
            1461,
            313,
            1841,
            1857,
            1741,
            1663,
            1947,
            1600,
            1954,
            1974,
            1922,
            1884,
            1844,
            1463,
            1777,
            1720,
            1888,
            1874,
            1435,
            1816,
            1268,
            1901,
            1945,
            1548,
            1794,
            1886,
            1580,
            1746,
            1958,
            1495,
            1821,
            1538,
            1937,
            584,
            1637,
            1185,
            1540,
            1959,
            1595,
            1523,
            1919,
            1644,
            1478,
            1822,
            1502,
            1466,
            1617,
            1258,
            267,
            1855,
            1887,
            1471,
            1632,
            1726,
            1415,
            1424,
            841,
            1410,
            1393,
            1293,
            1927,
            1934,
            1923,
            1848,
            1847,
            1968,
            1371,
            1497,
            1751,
            1851,
            1882,
            1250,
            1953,
            2004,
            1420,
            1662,
            1519,
            1679,
            1369,
            1964,
            1642,
            1809,
            1609,
            1517,
            1175
        };

        private static void Main()
        {
            var iterations = 1;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (var i = 0; i < iterations; i++)
            {
                PartOne();
            }

            stopwatch.Stop();

            Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms.\nTime per run: {(double) stopwatch.ElapsedMilliseconds / iterations} ms.");

            stopwatch.Start();

            for (var i = 0; i < iterations; i++)
            {
                PartTwo();
            }

            stopwatch.Stop();

            Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms.\nTime per run: {(double) stopwatch.ElapsedMilliseconds / iterations} ms.");
        }

        private static void PartOne()
        {
            var numberToSum = 2020;
            var numbers = new List<int>();

            foreach (var number in _numbers)
            {
                if (number > numberToSum)
                {
                    continue;
                }

                numbers.Add(number);
            }

            var sums = FindSumTwo(numbers, numberToSum);

            if (sums.Count == 0)
            {
                throw new InvalidOperationException($"No numbers add up to {numberToSum}");
            }

            foreach (var (a, b) in sums)
            {
                Console.WriteLine($"Numbers {a} and {b} add up to {numberToSum}. Multiplied: {a * b}");
            }
        }

        private static void PartTwo()
        {
            var numberToSum = 2020;
            var numbers = new List<int>();

            foreach (var number in _numbers)
            {
                if (number > numberToSum)
                {
                    continue;
                }

                numbers.Add(number);
            }

            var sums = FindSumThree(numbers, numberToSum);

            if (sums.Count == 0)
            {
                throw new InvalidOperationException($"No numbers add up to {numberToSum}");
            }

            foreach (var (a, b, c) in sums)
            {
                Console.WriteLine($"Numbers {a}, {b} and {c} add up to {numberToSum}. Multiplied: {a * b * c}");
            }
        }

        private static List<(int a, int b)> FindSumTwo(List<int> numbers, int numberToSum)
        {
            var sums = new List<(int a, int b)>();

            foreach (var i in numbers)
            {
                foreach (var j in numbers)
                {
                    if (i + j == numberToSum)
                    {
                        sums.Add((i, j));
                    }
                }
            }

            return sums;
        }

        private static List<(int a, int b, int c)> FindSumThree(List<int> numbers, int numberToSum)
        {
            var sums = new List<(int a, int b, int c)>();

            foreach (var i in numbers)
            {
                foreach (var j in numbers)
                {
                    foreach (var k in numbers)
                    {
                        if (i + j + k == numberToSum)
                        {
                            sums.Add((i, j, k));
                        }
                    }
                }
            }

            return sums;
        }
    }
}
