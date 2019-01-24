﻿/*
* Groupe      : Groupe4
* Membres     : Martig Joey, Lorentz Florian, Calunsag Iya Katherine
* Programme   : Traffic Light
* Description : Créer un simulation réaliste du carrefour des esserts
* Version     : 1.0.0 
* Date        : 21.01.2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightsGroupe4
{
    public class Routes
    {
        private int _direction;
        private string _nom;
        public int Direction { get => _direction; set => _direction = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public Routes(int direction, string nom)
        {
            Direction = direction;
            Nom = nom;
        }
    }
}
