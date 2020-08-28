using System;
using ApprovalTests;
using ApprovalTests.Core;
using Microsoft.VisualBasic;
using NUnit.Framework;

namespace ManyOfOne.Examples
{
    public class SlideExamples
    {
        private static string MethodUnderTest(int i)
        {
            return "hi";
        }

        [Test]
        public void Test1()
        {
            var teamMember = "Sulley"; // 1
            {
                var teamMembers = new[] {"Sulley", "Mike"}; // 2
                Console.WriteLine(teamMember + teamMembers);
            }
            {
                var teamMembers = new[] {"Sulley"}; // Many of one
                Console.WriteLine(teamMember + teamMembers);
            }
        }

        [Test, Ignore("samples")]
        public void Test2()
        {
            {
                void printVariables()
                {
                }

                void printMonster(string n)
                {
                }


                printVariables(); // 0 parameters

                printMonster("Sulley"); // 1 parameter
                String name = "Sulley"; // 1 value

                String[] team = new[] {"Sulley", "Mike", "Boo"}; // Many values

                Console.WriteLine(name + team);

            }
            {
                var output = "";
                var number1 = 1;
                output += number1 + ",";
            }
            {
                var output = "";
                var number1 = new[] {1};
                output += number1[0] + ",";
            }
            {
                var output = "";
                var number1 = 1;
                for (int i = 0; i < 1; i++)
                {
                    output += number1 + ",";
                }
            }
            {
                string Merge(string prefix)
                {
                    return prefix + 1 + "\n";
                }
            }
            {
                string Merge(string prefix, int number)
                {
                    return prefix + number + "\n";
                }
            }
            {
                string Merge(string prefix, params int[] number)
                {
                    return prefix + number[0] + "\n";
                }

                Console.WriteLine(Merge("#", 1));
            }

            {
                string Format(int number)
                {
                    return number + " ";
                }

                Console.WriteLine(Format(1));
            }

            {
                var result = MethodUnderTest(1);
                Approvals.Verify(result);

                var forValues = new[] {1};
                Approvals.VerifyAll("MethodUnderTest",
                    forValues,
                    n => $"{n} => {MethodUnderTest(n)}");
            }
        }

        string Format(int number, Options options = default)
        {
            return number + " " + options;
        }


        string Format(int number, string prefix)
        {
            return Format(number, Options.withPrefix(prefix));
        }
        

        class Options
        {
            public static Options withPrefix(string prefix)
            {
                return new Options();
            }
        }
    }
}