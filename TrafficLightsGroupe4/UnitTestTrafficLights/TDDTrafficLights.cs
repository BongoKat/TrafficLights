﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficLightsGroupe4;

namespace UnitTestTrafficLights
{
    [TestClass]
    public class TDDTrafficLights
    {
        List<Vehicules> vehicules;

        [TestInitialize]
        public void InitialisationListVehicules()
        {
            vehicules = new List<Vehicules> {
            new Velo(),
            new Voiture(),
            new Tram(),
            new Moto(),
            new Camion()
            };
        }

        [TestMethod]
        public void CheckAccelerer()
        {
            foreach (var item in vehicules)
            {
                double oldSpeed = item.Vitesse;
                item.Accelerer();
                Assert.AreNotEqual(oldSpeed, item.Vitesse);
            }
        }

        [TestMethod]
        public void CheckFreiner()
        {
            foreach (var item in vehicules)
            {
                double oldSpeed = item.Vitesse;
                item.Freiner();
                Assert.AreNotEqual(oldSpeed, item.Vitesse);
            }
        }

        [TestCleanup]
        public void CleanListVehicules()
        {
            vehicules = null;
        }
    }
}
