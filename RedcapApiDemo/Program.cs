﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Redcap;
using Redcap.Models;

namespace RedcapApiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Redcap Api Demo Started!");

            var redcap_api = new RedcapApi("3D57A7FA57C8A43F6C8803A84BB3957B", "http://localhost/redcap/api/");

            var armList = new List<int> {2 }.ToArray();
            var result = redcap_api.DeleteArms(armList).Result;
            var data = JsonConvert.DeserializeObject(result);
            Console.WriteLine(data);
            Console.ReadLine();

        }
    }
}