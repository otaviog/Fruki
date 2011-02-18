﻿using Fruki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestSAN
{


    /// <summary>
    ///This is a test class for SANTest and is intended
    ///to contain all SANTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SANTest
    {

        private TestContext testContextInstance;
        private SAN san;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //

        [TestInitialize()]
        public void TestInitialize()
        {
            san = new SAN();

            Autonomus aut1 = new Autonomus("A");
            aut1.AddNode(0);
            aut1.AddNode(1);
            aut1.AddEdge("ev1", 0, 1, 1.0f);
            aut1.AddEdge("ev2", 1, 0, 1.0f);
            san.AddAutonomus(aut1);

            Autonomus aut2 = new Autonomus("B");
            aut2.AddNode(0);
            aut2.AddNode(1);
            aut2.AddEdge("ev3", 0, 1, 1.0f);
            aut2.AddEdge("ev4", 1, 0, 1.0f);
            san.AddAutonomus(aut2);

            Autonomus aut3 = new Autonomus("C");
            aut3.AddNode(0);
            aut3.AddNode(1);
            aut3.AddEdge("ev2", 0, 1, 1.0f);
            aut3.AddEdge("ev3", 1, 0, 1.0f);

            san.AddAutonomus(aut3);

            san.AddEvent("ev1", Event.EventType.LOC, null);
            san.AddEvent("ev2", Event.EventType.LOC, null);
            san.AddEvent("ev3", Event.EventType.LOC, null);
            san.AddEvent("ev4", Event.EventType.LOC, null);

        }

        [TestCleanup()]
        public void TestCleanup()
        {
        }

        #endregion


        /// <summary>
        ///A test for AddAutonomus
        ///</summary>
        [TestMethod()]
        public void AddAutonomusTest()
        {

        }

        /// <summary>
        ///A test for AddEvent
        ///</summary>
        [TestMethod()]
        public void AddEventTest()
        {

        }

        /// <summary>
        ///A test for GenerateDotVis
        ///</summary>
        [TestMethod()]
        public void GenerateDotVisTest()
        {

            TextWriter writer = new StreamWriter(new FileStream("t.txt", FileMode.CreateNew));
            san.GenerateDotVis(writer);
            writer.Close();
        }
    }
}
