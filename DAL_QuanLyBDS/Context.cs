﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL_QuanLyBDS
{
    public class Context
    {
        protected const string _conn = "mongodb+srv://tzt55492:5yg1q7u5OTZdZkkV@testcluster.4u0pasa.mongodb.net/?retryWrites=true&w=majority";
        protected static MongoClient client = new MongoClient(_conn);
        protected static dynamic db = client.GetDatabase("QLBatDongSan");
    }
}
